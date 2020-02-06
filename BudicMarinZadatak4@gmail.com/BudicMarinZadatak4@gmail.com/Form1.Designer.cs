namespace BudicMarinZadatak4_gmail.com
{
    partial class Form1
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
            this.labelPrviBroj = new System.Windows.Forms.Label();
            this.labelDrugiBroj = new System.Windows.Forms.Label();
            this.buttonZbroj = new System.Windows.Forms.Button();
            this.textBoxPrviBroj = new System.Windows.Forms.TextBox();
            this.textBoxDrugiBroj = new System.Windows.Forms.TextBox();
            this.buttonRazlika = new System.Windows.Forms.Button();
            this.buttonKoeficijent = new System.Windows.Forms.Button();
            this.buttonUmnožak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPrviBroj
            // 
            this.labelPrviBroj.AutoSize = true;
            this.labelPrviBroj.Location = new System.Drawing.Point(13, 13);
            this.labelPrviBroj.Name = "labelPrviBroj";
            this.labelPrviBroj.Size = new System.Drawing.Size(25, 17);
            this.labelPrviBroj.TabIndex = 0;
            this.labelPrviBroj.Text = "A=";
            // 
            // labelDrugiBroj
            // 
            this.labelDrugiBroj.AutoSize = true;
            this.labelDrugiBroj.Location = new System.Drawing.Point(13, 34);
            this.labelDrugiBroj.Name = "labelDrugiBroj";
            this.labelDrugiBroj.Size = new System.Drawing.Size(25, 17);
            this.labelDrugiBroj.TabIndex = 1;
            this.labelDrugiBroj.Text = "B=";
            // 
            // buttonZbroj
            // 
            this.buttonZbroj.Location = new System.Drawing.Point(181, 5);
            this.buttonZbroj.Name = "buttonZbroj";
            this.buttonZbroj.Size = new System.Drawing.Size(75, 23);
            this.buttonZbroj.TabIndex = 2;
            this.buttonZbroj.Text = "Zbroj";
            this.buttonZbroj.UseVisualStyleBackColor = true;
            this.buttonZbroj.Click += new System.EventHandler(this.ButtonZbroj_Click);
            // 
            // textBoxPrviBroj
            // 
            this.textBoxPrviBroj.Location = new System.Drawing.Point(45, 6);
            this.textBoxPrviBroj.Name = "textBoxPrviBroj";
            this.textBoxPrviBroj.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrviBroj.TabIndex = 3;
            this.textBoxPrviBroj.Text = "Unesite broj";
            this.textBoxPrviBroj.TextChanged += new System.EventHandler(this.TextBoxPrviBroj_TextChanged);
            // 
            // textBoxDrugiBroj
            // 
            this.textBoxDrugiBroj.Location = new System.Drawing.Point(45, 35);
            this.textBoxDrugiBroj.Name = "textBoxDrugiBroj";
            this.textBoxDrugiBroj.Size = new System.Drawing.Size(100, 22);
            this.textBoxDrugiBroj.TabIndex = 4;
            this.textBoxDrugiBroj.Text = "Drugi broj";
            this.textBoxDrugiBroj.TextChanged += new System.EventHandler(this.TextBoxDrugiBroj_TextChanged);
            // 
            // buttonRazlika
            // 
            this.buttonRazlika.Location = new System.Drawing.Point(181, 35);
            this.buttonRazlika.Name = "buttonRazlika";
            this.buttonRazlika.Size = new System.Drawing.Size(75, 23);
            this.buttonRazlika.TabIndex = 5;
            this.buttonRazlika.Text = "Razlika";
            this.buttonRazlika.UseVisualStyleBackColor = true;
            this.buttonRazlika.Click += new System.EventHandler(this.ButtonRazlika_Click);
            // 
            // buttonKoeficijent
            // 
            this.buttonKoeficijent.Location = new System.Drawing.Point(262, 35);
            this.buttonKoeficijent.Name = "buttonKoeficijent";
            this.buttonKoeficijent.Size = new System.Drawing.Size(87, 23);
            this.buttonKoeficijent.TabIndex = 7;
            this.buttonKoeficijent.Text = "Koeficijent";
            this.buttonKoeficijent.UseVisualStyleBackColor = true;
            this.buttonKoeficijent.Click += new System.EventHandler(this.ButtonKoeficijent_Click);
            // 
            // buttonUmnožak
            // 
            this.buttonUmnožak.Location = new System.Drawing.Point(262, 5);
            this.buttonUmnožak.Name = "buttonUmnožak";
            this.buttonUmnožak.Size = new System.Drawing.Size(87, 23);
            this.buttonUmnožak.TabIndex = 6;
            this.buttonUmnožak.Text = "Umnožak";
            this.buttonUmnožak.UseVisualStyleBackColor = true;
            this.buttonUmnožak.Click += new System.EventHandler(this.ButtonUmnožak_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 86);
            this.Controls.Add(this.buttonKoeficijent);
            this.Controls.Add(this.buttonUmnožak);
            this.Controls.Add(this.buttonRazlika);
            this.Controls.Add(this.textBoxDrugiBroj);
            this.Controls.Add(this.textBoxPrviBroj);
            this.Controls.Add(this.buttonZbroj);
            this.Controls.Add(this.labelDrugiBroj);
            this.Controls.Add(this.labelPrviBroj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrviBroj;
        private System.Windows.Forms.Label labelDrugiBroj;
        private System.Windows.Forms.Button buttonZbroj;
        private System.Windows.Forms.TextBox textBoxPrviBroj;
        private System.Windows.Forms.TextBox textBoxDrugiBroj;
        private System.Windows.Forms.Button buttonRazlika;
        private System.Windows.Forms.Button buttonKoeficijent;
        private System.Windows.Forms.Button buttonUmnožak;
    }
}

