namespace ProgramZaVolontiranje
{
    partial class MailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            tbPosiljalac = new TextBox();
            tbPrimatelj = new TextBox();
            rtbMail = new RichTextBox();
            label3 = new Label();
            btnPosalji = new Button();
            label4 = new Label();
            tbPredmet = new TextBox();
            label6 = new Label();
            lblDatoteka = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 36);
            label1.Name = "label1";
            label1.Size = new Size(87, 23);
            label1.TabIndex = 0;
            label1.Text = "Pošiljalac:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 110);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 1;
            label2.Text = "Primatelj:";
            // 
            // tbPosiljalac
            // 
            tbPosiljalac.Location = new Point(27, 65);
            tbPosiljalac.Name = "tbPosiljalac";
            tbPosiljalac.Size = new Size(721, 27);
            tbPosiljalac.TabIndex = 2;
            // 
            // tbPrimatelj
            // 
            tbPrimatelj.Location = new Point(27, 145);
            tbPrimatelj.Name = "tbPrimatelj";
            tbPrimatelj.Size = new Size(721, 27);
            tbPrimatelj.TabIndex = 3;
            // 
            // rtbMail
            // 
            rtbMail.Location = new Point(27, 311);
            rtbMail.Name = "rtbMail";
            rtbMail.Size = new Size(718, 139);
            rtbMail.TabIndex = 4;
            rtbMail.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(27, 273);
            label3.Name = "label3";
            label3.Size = new Size(74, 23);
            label3.TabIndex = 5;
            label3.Text = "Sadržaj:";
            // 
            // btnPosalji
            // 
            btnPosalji.BackColor = SystemColors.ActiveCaption;
            btnPosalji.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnPosalji.Location = new Point(626, 540);
            btnPosalji.Name = "btnPosalji";
            btnPosalji.Size = new Size(119, 36);
            btnPosalji.TabIndex = 6;
            btnPosalji.Text = "Pošalji";
            btnPosalji.UseVisualStyleBackColor = false;
            btnPosalji.Click += btnSend_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(27, 195);
            label4.Name = "label4";
            label4.Size = new Size(84, 23);
            label4.TabIndex = 7;
            label4.Text = "Predmet:";
            // 
            // tbPredmet
            // 
            tbPredmet.Location = new Point(27, 227);
            tbPredmet.Name = "tbPredmet";
            tbPredmet.Size = new Size(721, 27);
            tbPredmet.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(27, 475);
            label6.Name = "label6";
            label6.Size = new Size(89, 23);
            label6.TabIndex = 10;
            label6.Text = "Datoteke:";
            // 
            // lblDatoteka
            // 
            lblDatoteka.AutoSize = true;
            lblDatoteka.Location = new Point(122, 478);
            lblDatoteka.Name = "lblDatoteka";
            lblDatoteka.Size = new Size(50, 20);
            lblDatoteka.TabIndex = 11;
            lblDatoteka.Text = "label5";
            // 
            // MailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 601);
            Controls.Add(lblDatoteka);
            Controls.Add(label6);
            Controls.Add(tbPredmet);
            Controls.Add(label4);
            Controls.Add(btnPosalji);
            Controls.Add(label3);
            Controls.Add(rtbMail);
            Controls.Add(tbPrimatelj);
            Controls.Add(tbPosiljalac);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MailForm";
            Text = "MailForm";
            Load += MailForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbPosiljalac;
        private TextBox tbPrimatelj;
        private RichTextBox rtbMail;
        private Label label3;
        private Button btnPosalji;
        private Label label4;
        private TextBox tbPredmet;
        private Label label6;
        private Label lblDatoteka;
    }
}