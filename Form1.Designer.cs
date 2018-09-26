namespace Haier_Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNilaiA = new System.Windows.Forms.TextBox();
            this.textNilaiB = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttHitung = new System.Windows.Forms.Button();
            this.buttAbout = new System.Windows.Forms.Button();
            this.textHasilAB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operasi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nilai A";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nilai B";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // textNilaiA
            // 
            this.textNilaiA.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.textNilaiA.Location = new System.Drawing.Point(73, 80);
            this.textNilaiA.Name = "textNilaiA";
            this.textNilaiA.Size = new System.Drawing.Size(133, 23);
            this.textNilaiA.TabIndex = 1;
            // 
            // textNilaiB
            // 
            this.textNilaiB.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.textNilaiB.Location = new System.Drawing.Point(73, 120);
            this.textNilaiB.Name = "textNilaiB";
            this.textNilaiB.Size = new System.Drawing.Size(133, 23);
            this.textNilaiB.TabIndex = 1;
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Penjumlahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.comboBox.Location = new System.Drawing.Point(73, 33);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(133, 23);
            this.comboBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label4.Location = new System.Drawing.Point(12, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hasil";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttHitung
            // 
            this.buttHitung.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.buttHitung.Location = new System.Drawing.Point(102, 161);
            this.buttHitung.Name = "buttHitung";
            this.buttHitung.Size = new System.Drawing.Size(75, 23);
            this.buttHitung.TabIndex = 3;
            this.buttHitung.Text = "Hitung";
            this.buttHitung.UseVisualStyleBackColor = true;
            this.buttHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // buttAbout
            // 
            this.buttAbout.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.buttAbout.Location = new System.Drawing.Point(263, 201);
            this.buttAbout.Name = "buttAbout";
            this.buttAbout.Size = new System.Drawing.Size(75, 23);
            this.buttAbout.TabIndex = 3;
            this.buttAbout.Text = "About";
            this.buttAbout.UseVisualStyleBackColor = true;
            this.buttAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // textHasilAB
            // 
            this.textHasilAB.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.textHasilAB.Location = new System.Drawing.Point(73, 202);
            this.textHasilAB.Name = "textHasilAB";
            this.textHasilAB.Size = new System.Drawing.Size(133, 23);
            this.textHasilAB.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 228);
            this.Controls.Add(this.buttAbout);
            this.Controls.Add(this.buttHitung);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.textHasilAB);
            this.Controls.Add(this.textNilaiB);
            this.Controls.Add(this.textNilaiA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNilaiA;
        private System.Windows.Forms.TextBox textNilaiB;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttHitung;
        private System.Windows.Forms.Button buttAbout;
        private System.Windows.Forms.TextBox textHasilAB;
    }
}

