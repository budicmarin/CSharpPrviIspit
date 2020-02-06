namespace BudicMarinZadatak3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelPrvi = new System.Windows.Forms.Label();
            this.labelDrugi = new System.Windows.Forms.Label();
            this.buttonZbir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // labelPrvi
            // 
            this.labelPrvi.AutoSize = true;
            this.labelPrvi.Location = new System.Drawing.Point(13, 13);
            this.labelPrvi.Name = "labelPrvi";
            this.labelPrvi.Size = new System.Drawing.Size(61, 17);
            this.labelPrvi.TabIndex = 2;
            this.labelPrvi.Text = "Prvi Broj";
            // 
            // labelDrugi
            // 
            this.labelDrugi.AutoSize = true;
            this.labelDrugi.Location = new System.Drawing.Point(16, 54);
            this.labelDrugi.Name = "labelDrugi";
            this.labelDrugi.Size = new System.Drawing.Size(70, 17);
            this.labelDrugi.TabIndex = 3;
            this.labelDrugi.Text = "Drugi broj";
            // 
            // buttonZbir
            // 
            this.buttonZbir.Location = new System.Drawing.Point(109, 102);
            this.buttonZbir.Name = "buttonZbir";
            this.buttonZbir.Size = new System.Drawing.Size(75, 23);
            this.buttonZbir.TabIndex = 4;
            this.buttonZbir.Text = "Zbroji";
            this.buttonZbir.UseVisualStyleBackColor = true;
            this.buttonZbir.Click += new System.EventHandler(this.ButtonZbir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 201);
            this.Controls.Add(this.buttonZbir);
            this.Controls.Add(this.labelDrugi);
            this.Controls.Add(this.labelPrvi);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelPrvi;
        private System.Windows.Forms.Label labelDrugi;
        private System.Windows.Forms.Button buttonZbir;
    }
}

