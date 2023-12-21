namespace metodlar
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
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.rtbSonuclar = new System.Windows.Forms.RichTextBox();
            this.Btnbuyuk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMetin
            // 
            this.txtMetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMetin.Location = new System.Drawing.Point(91, 107);
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(599, 31);
            this.txtMetin.TabIndex = 0;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(91, 157);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(291, 58);
            this.btnHesapla.TabIndex = 1;
            this.btnHesapla.Text = "Metni Analiz Et";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click_1);
            // 
            // rtbSonuclar
            // 
            this.rtbSonuclar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtbSonuclar.Location = new System.Drawing.Point(91, 242);
            this.rtbSonuclar.Name = "rtbSonuclar";
            this.rtbSonuclar.Size = new System.Drawing.Size(599, 196);
            this.rtbSonuclar.TabIndex = 2;
            this.rtbSonuclar.Text = "";
            // 
            // Btnbuyuk
            // 
            this.Btnbuyuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Btnbuyuk.Location = new System.Drawing.Point(388, 157);
            this.Btnbuyuk.Name = "Btnbuyuk";
            this.Btnbuyuk.Size = new System.Drawing.Size(302, 58);
            this.Btnbuyuk.TabIndex = 3;
            this.Btnbuyuk.Text = "Noktadan sonra Gelen Büyük Harf Hatalarını Düzelt";
            this.Btnbuyuk.UseVisualStyleBackColor = true;
            this.Btnbuyuk.Click += new System.EventHandler(this.Btnbuyuk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.Location = new System.Drawing.Point(293, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Metninizi Giriniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btnbuyuk);
            this.Controls.Add(this.rtbSonuclar);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtMetin);
            this.Name = "Form1";
            this.Text = "yazım analiz uygulaması";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.RichTextBox rtbSonuclar;
        private System.Windows.Forms.Button Btnbuyuk;
        private System.Windows.Forms.Label label1;
    }
}

