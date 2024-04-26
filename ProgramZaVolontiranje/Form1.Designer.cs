namespace ProgramZaVolontiranje
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            rtbText = new RichTextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // rtbText
            // 
            rtbText.Location = new Point(25, 74);
            rtbText.Name = "rtbText";
            rtbText.Size = new Size(740, 199);
            rtbText.TabIndex = 1;
            rtbText.Text = "";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(485, 296);
            button1.Name = "button1";
            button1.Size = new Size(124, 41);
            button1.TabIndex = 2;
            button1.Text = "Kreiraj fajl";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnCreateFile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 32);
            label1.Name = "label1";
            label1.Size = new Size(346, 20);
            label1.TabIndex = 3;
            label1.Text = "Upiši što si radio u skolpu volontiranja ovaj mjesec:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 306);
            label2.Name = "label2";
            label2.Size = new Size(207, 20);
            label2.TabIndex = 4;
            label2.Text = "Prevuci fajl sa satnicom ovdje.";
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(641, 296);
            button2.Name = "button2";
            button2.Size = new Size(124, 41);
            button2.TabIndex = 5;
            button2.Text = "Pošalji mail";
            button2.UseVisualStyleBackColor = false;
            button2.Click += showMailForm_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 357);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(rtbText);
            Name = "Main Form";
            Text = "Volonterski izvještaj";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private RichTextBox rtbText;
        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
    }
}