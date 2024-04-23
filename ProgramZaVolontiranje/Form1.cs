

namespace ProgramZaVolontiranje
{
    using Microsoft.Office.Interop.Word;
    using PdfSharp.Pdf;
    using PdfSharp.Pdf.IO;
    using System.Diagnostics;

    public partial class Form1 : Form
    {

        private string draggedFilePath;
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
            }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\Elvir\\Desktop\\Osnovni_Formular.docx";
            Application wordApp = new Application();
            wordApp.DisplayAlerts = WdAlertLevel.wdAlertsNone;
            //defaultni formular
            Document doc = wordApp.Documents.Open(filePath);
            //pravim kopiju;
            string desktopPutanja = "C:\\Users\\Elvir\\Desktop";
            string kopijaPutanja = Path.Combine(desktopPutanja, $"Volonterski_Izvještaj_{DateTime.Now.Month}_{DateTime.Now.Year}.docx");
            doc.SaveAs2(kopijaPutanja);
            doc.Close();

            //otvaranje kopije na kojoj cemo raditi
            Document izvjestaj = wordApp.Documents.Open(kopijaPutanja);

            //postavljanje podataka
            Paragraph last = izvjestaj.Paragraphs[4];
            Paragraph opis = izvjestaj.Paragraphs[29];
            Paragraph datumDole = izvjestaj.Paragraphs[izvjestaj.Paragraphs.Count - 1];

            last.Range.Delete();
            last.Range.Text = $"Datum: {DateTime.Now.ToString("d.M.yyyy")}\n\n";
            opis.Range.Delete();
            opis.Range.Text = rtbText.Text;
            opis.Range.Bold = 0;
            datumDole.Range.Delete();
            datumDole.Range.Text = $"Datum: {DateTime.Now.ToString("d.M.yyyy")}\n\n";


            //spremamo promjene
            izvjestaj.Save();
            //prije zatvaranja fajla, konvertujemo .docx fajl u .pdf fajl
            string pdfPutanja = Path.ChangeExtension(kopijaPutanja, "pdf");
            izvjestaj.ExportAsFixedFormat(pdfPutanja, WdExportFormat.wdExportFormatPDF);
            
            //mergamo dva pdf-a
            MergePDFs(draggedFilePath, pdfPutanja);

            //sada zatvaramo sve
            izvjestaj.Close();
            wordApp.Quit();

            MessageBox.Show("Fajl je spremljen na desktop!");
            rtbText.Clear();

        }

        private void MergePDFs(string draggedFile, string pdfPutanja)
        {
            PdfDocument pdf1 = PdfReader.Open(draggedFile, PdfDocumentOpenMode.Import);
            PdfDocument pdf2 = PdfReader.Open(pdfPutanja, PdfDocumentOpenMode.Import);

            PdfDocument mergedPDF = new PdfDocument();

            foreach (PdfPage page in pdf1.Pages) {
                mergedPDF.AddPage(page);
            }
            foreach (PdfPage page in pdf2.Pages)
            {
                mergedPDF.AddPage(page);
            }

            string filePath = "C:\\Users\\Elvir\\Desktop\\ElvirPeder.pdf";
            mergedPDF.Save(filePath);

        }
    }
}