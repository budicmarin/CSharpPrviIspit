namespace BudicMarinZadatak2
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
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.labelIme = new System.Windows.Forms.Label();
            this.labelPrezime = new System.Windows.Forms.Label();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.buttonPosalji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(90, 13);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(100, 22);
            this.textBoxIme.TabIndex = 0;
            this.textBoxIme.TextChanged += new System.EventHandler(this.TextBoxIme_TextChanged);
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Location = new System.Drawing.Point(13, 17);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(34, 17);
            this.labelIme.TabIndex = 1;
            this.labelIme.Text = "Ime:";
            // 
            // labelPrezime
            // 
            this.labelPrezime.AutoSize = true;
            this.labelPrezime.Location = new System.Drawing.Point(13, 38);
            this.labelPrezime.Name = "labelPrezime";
            this.labelPrezime.Size = new System.Drawing.Size(63, 17);
            this.labelPrezime.TabIndex = 2;
            this.labelPrezime.Text = "Prezime:";
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(90, 42);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrezime.TabIndex = 3;
            this.textBoxPrezime.TextChanged += new System.EventHandler(this.TextBoxPrezime_TextChanged);
            // 
            // buttonPosalji
            // 
            this.buttonPosalji.Location = new System.Drawing.Point(90, 86);
            this.buttonPosalji.Name = "buttonPosalji";
            this.buttonPosalji.Size = new System.Drawing.Size(75, 23);
            this.buttonPosalji.TabIndex = 4;
            this.buttonPosalji.Text = "Prikaz Podataka";
            this.buttonPosalji.UseVisualStyleBackColor = true;
            this.buttonPosalji.Click += new System.EventHandler(this.ButtonPosalji_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 144);
            this.Controls.Add(this.buttonPosalji);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.labelPrezime);
            this.Controls.Add(this.labelIme);
            this.Controls.Add(this.textBoxIme);
            this.Name = "Form1";
            this.Text = "Upotreba Text Box Kontrole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label labelPrezime;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.Button buttonPosalji;
    }
}

