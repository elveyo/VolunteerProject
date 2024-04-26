

namespace ProgramZaVolontiranje
{
    using DotNetEnv;
    using Microsoft.Office.Interop.Word;
    using PdfSharp.Pdf;
    using PdfSharp.Pdf.IO;
    using System.Diagnostics;

    public partial class Form1 : Form
    {

        private string? draggedFilePath;
        private string? finalFilePath;
        public Form1()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(DragEnterFunc);
            this.DragDrop += new DragEventHandler(DragDropFunc);
        }

        private void DragEnterFunc(object? sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;

        }

        private void DragDropFunc(object? sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in files)
            {
                if (file.EndsWith(".pdf")) draggedFilePath = file;

            }
            MessageBox.Show("Fajl je prenesen!");


        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(draggedFilePath))
            {
                MessageBox.Show("Prije kreiranja finalnog fajla prevucite vaše satnice.");
                return;
            }
            //defaultni formular
            string mainFilePath = "C:\\Users\\Elvir\\Desktop\\Osnovni_Formular.docx";
            Application wordApp = new Application();
            wordApp.DisplayAlerts = WdAlertLevel.wdAlertsNone;
            Document doc = wordApp.Documents.Open(mainFilePath);

            //pravim kopiju;
            string desktop = "C:\\Users\\Elvir\\Desktop";
            string copy = Path.Combine(desktop, $"Volonterski_Izvještaj_{DateTime.Now.Month}_{DateTime.Now.Year}.docx");
            doc.SaveAs2(copy);
            doc.Close();

            //otvaranje kopije na kojoj cemo raditi
            Document izvjestaj = wordApp.Documents.Open(copy);
            fillDataIntoFile(izvjestaj);
            izvjestaj.Save();

            //prije zatvaranja fajla, konvertujemo .docx fajl u .pdf fajl
            string pdfPutanja = Path.ChangeExtension(copy, "pdf");
            izvjestaj.ExportAsFixedFormat(pdfPutanja, WdExportFormat.wdExportFormatPDF);

            //mergamo dva pdf-a
            MergePDFs(draggedFilePath, pdfPutanja);

            //sada zatvaramo sve te brisemo fajl jer nam vise ne treba
            izvjestaj.Close();
            File.Delete(copy);
            wordApp.Quit();

            //finalna poruka
            MessageBox.Show("Fajl je spremljen na desktop!");
            rtbText.Clear();

        }

        private void fillDataIntoFile(Document file)
        { 
            //postavljanje podataka
            Paragraph last = file.Paragraphs[4];
            Paragraph info = file.Paragraphs[29];
            Paragraph dateParagraph = file.Paragraphs[file.Paragraphs.Count - 1];
            string date = $"Datum: {DateTime.Now.ToString("d.M.yyyy")}\n\n";

            last.Range.Delete();
            last.Range.Text = date;
            info.Range.Delete();
            info.Range.Text = rtbText.Text;
            info.Range.Bold = 0;
            dateParagraph.Range.Delete();
            dateParagraph.Range.Text = date;

        }

        private void MergePDFs(string draggedFile, string pdfPutanja)
        {
            PdfDocument pdf1 = PdfReader.Open(draggedFile, PdfDocumentOpenMode.Import);
            PdfDocument pdf2 = PdfReader.Open(pdfPutanja, PdfDocumentOpenMode.Import);

            PdfDocument mergedPDF = new PdfDocument();

            foreach (PdfPage page in pdf1.Pages)
            {
                mergedPDF.AddPage(page);
            }
            foreach (PdfPage page in pdf2.Pages)
            {
                mergedPDF.AddPage(page);
            }

            string filePath = $"C:\\Users\\Elvir\\Desktop\\Volonterski_Izvještaj_{DateTime.Now.Month}_{DateTime.Now.Year}.pdf";
            mergedPDF.Save(filePath);
            mergedPDF.Close();
            finalFilePath = filePath;
         

        }

        private void showMailForm_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(finalFilePath))
            {
                MessageBox.Show("Niste kreirali mjesecni izvještaj!");
                return;
            }
            new MailForm(finalFilePath).ShowDialog();
        }
    }
}