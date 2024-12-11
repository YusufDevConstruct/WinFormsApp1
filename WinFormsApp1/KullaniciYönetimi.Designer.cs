namespace WinFormsApp1
{
    partial class KullaniciYönetimi
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
            KullaniciEkleTextBox = new Button();
            KullanıcıSilTextBox = new Button();
            YetkiDuzenleTextBox = new Button();
            HesapAyarlariTextBox = new Button();
            SuspendLayout();
            // 
            // KullaniciEkleTextBox
            // 
            KullaniciEkleTextBox.Location = new Point(36, 32);
            KullaniciEkleTextBox.Name = "KullaniciEkleTextBox";
            KullaniciEkleTextBox.Size = new Size(122, 55);
            KullaniciEkleTextBox.TabIndex = 0;
            KullaniciEkleTextBox.Text = "KullanıcıEkle";
            KullaniciEkleTextBox.UseVisualStyleBackColor = true;
            // 
            // KullanıcıSilTextBox
            // 
            KullanıcıSilTextBox.Location = new Point(228, 32);
            KullanıcıSilTextBox.Name = "KullanıcıSilTextBox";
            KullanıcıSilTextBox.Size = new Size(122, 55);
            KullanıcıSilTextBox.TabIndex = 1;
            KullanıcıSilTextBox.Text = "KullanıcıSil";
            KullanıcıSilTextBox.UseVisualStyleBackColor = true;
            // 
            // YetkiDuzenleTextBox
            // 
            YetkiDuzenleTextBox.Location = new Point(426, 32);
            YetkiDuzenleTextBox.Name = "YetkiDuzenleTextBox";
            YetkiDuzenleTextBox.Size = new Size(122, 55);
            YetkiDuzenleTextBox.TabIndex = 2;
            YetkiDuzenleTextBox.Text = "YetkiDüzenle";
            YetkiDuzenleTextBox.UseVisualStyleBackColor = true;
            // 
            // HesapAyarlariTextBox
            // 
            HesapAyarlariTextBox.Location = new Point(616, 32);
            HesapAyarlariTextBox.Name = "HesapAyarlariTextBox";
            HesapAyarlariTextBox.Size = new Size(122, 55);
            HesapAyarlariTextBox.TabIndex = 3;
            HesapAyarlariTextBox.Text = "HesapAyarları";
            HesapAyarlariTextBox.UseVisualStyleBackColor = true;
            // 
            // KullaniciYönetimi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(HesapAyarlariTextBox);
            Controls.Add(YetkiDuzenleTextBox);
            Controls.Add(KullanıcıSilTextBox);
            Controls.Add(KullaniciEkleTextBox);
            Name = "KullaniciYönetimi";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button KullaniciEkleTextBox;
        private Button KullanıcıSilTextBox;
        private Button YetkiDuzenleTextBox;
        private Button HesapAyarlariTextBox;
    }
}