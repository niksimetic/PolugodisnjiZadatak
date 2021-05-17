namespace nikSimeticPolugodisnjiZadatak1
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
            this.Marka = new System.Windows.Forms.Label();
            this.ž = new System.Windows.Forms.Label();
            this.list2 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtGodiste = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnObradi = new System.Windows.Forms.Button();
            this.btnIspisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Marka
            // 
            this.Marka.AutoSize = true;
            this.Marka.Location = new System.Drawing.Point(37, 17);
            this.Marka.Name = "Marka";
            this.Marka.Size = new System.Drawing.Size(37, 13);
            this.Marka.TabIndex = 0;
            this.Marka.Text = "Marka";
            // 
            // ž
            // 
            this.ž.AutoSize = true;
            this.ž.Location = new System.Drawing.Point(37, 95);
            this.ž.Name = "ž";
            this.ž.Size = new System.Drawing.Size(43, 13);
            this.ž.TabIndex = 1;
            this.ž.Text = "Godiste";
            // 
            // list2
            // 
            this.list2.AutoSize = true;
            this.list2.Location = new System.Drawing.Point(37, 56);
            this.list2.Name = "list2";
            this.list2.Size = new System.Drawing.Size(36, 13);
            this.list2.TabIndex = 2;
            this.list2.Text = "Model";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(40, 33);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(153, 20);
            this.txtMarka.TabIndex = 4;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(40, 72);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(153, 20);
            this.txtModel.TabIndex = 5;
            // 
            // txtGodiste
            // 
            this.txtGodiste.Location = new System.Drawing.Point(40, 111);
            this.txtGodiste.Name = "txtGodiste";
            this.txtGodiste.Size = new System.Drawing.Size(153, 20);
            this.txtGodiste.TabIndex = 6;
            this.txtGodiste.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(40, 164);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(644, 264);
            this.listBox1.TabIndex = 9;
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(244, 19);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(123, 109);
            this.btnUnesi.TabIndex = 10;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnObradi
            // 
            this.btnObradi.Location = new System.Drawing.Point(393, 21);
            this.btnObradi.Name = "btnObradi";
            this.btnObradi.Size = new System.Drawing.Size(123, 107);
            this.btnObradi.TabIndex = 11;
            this.btnObradi.Text = "Obradi";
            this.btnObradi.UseVisualStyleBackColor = true;
            this.btnObradi.Click += new System.EventHandler(this.btnObradi_Click);
            // 
            // btnIspisi
            // 
            this.btnIspisi.Location = new System.Drawing.Point(550, 21);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(122, 107);
            this.btnIspisi.TabIndex = 12;
            this.btnIspisi.Text = "Ispiši";
            this.btnIspisi.UseVisualStyleBackColor = true;
            this.btnIspisi.Click += new System.EventHandler(this.btnIspisi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 455);
            this.Controls.Add(this.btnIspisi);
            this.Controls.Add(this.btnObradi);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtGodiste);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.list2);
            this.Controls.Add(this.ž);
            this.Controls.Add(this.Marka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Marka;
        private System.Windows.Forms.Label ž;
        private System.Windows.Forms.Label list2;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtGodiste;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnObradi;
        private System.Windows.Forms.Button btnIspisi;
    }
}

