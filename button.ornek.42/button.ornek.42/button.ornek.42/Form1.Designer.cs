namespace button.ornek._42
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
            this.txtYazili1 = new System.Windows.Forms.TextBox();
            this.txtYazili2 = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yazılı 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yazılı 2";
            // 
            // txtYazili1
            // 
            this.txtYazili1.Location = new System.Drawing.Point(97, 35);
            this.txtYazili1.Name = "txtYazili1";
            this.txtYazili1.Size = new System.Drawing.Size(100, 20);
            this.txtYazili1.TabIndex = 2;
            // 
            // txtYazili2
            // 
            this.txtYazili2.Location = new System.Drawing.Point(97, 65);
            this.txtYazili2.Name = "txtYazili2";
            this.txtYazili2.Size = new System.Drawing.Size(100, 20);
            this.txtYazili2.TabIndex = 3;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(97, 118);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Location = new System.Drawing.Point(272, 55);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(49, 13);
            this.lblOrtalama.TabIndex = 5;
            this.lblOrtalama.Text = "Ortalama";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(272, 94);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(61, 13);
            this.lblDurum.TabIndex = 6;
            this.lblDurum.Text = "Kaldı_Geçti";
            this.lblDurum.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 406);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblOrtalama);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtYazili2);
            this.Controls.Add(this.txtYazili1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYazili1;
        private System.Windows.Forms.TextBox txtYazili2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.Label lblDurum;
    }
}

