﻿namespace WinFormsApp1
{
    partial class Anasayfa
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
            MalzemeTextBox = new Button();
            DepoTextBox = new Button();
            RaporTextBox = new Button();
            KullaniciTextBox = new Button();
            AyarlarTextBox = new Button();
            SuspendLayout();
            // 
            // MalzemeTextBox
            // 
            MalzemeTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MalzemeTextBox.Location = new Point(87, 30);
            MalzemeTextBox.Name = "MalzemeTextBox";
            MalzemeTextBox.Size = new Size(120, 27);
            MalzemeTextBox.TabIndex = 0;
            MalzemeTextBox.Text = "Malzeme Yönetimi";
            MalzemeTextBox.UseVisualStyleBackColor = true;
            MalzemeTextBox.Click += MalzemeTextBox_Click;
            // 
            // DepoTextBox
            // 
            DepoTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DepoTextBox.Location = new Point(213, 30);
            DepoTextBox.Name = "DepoTextBox";
            DepoTextBox.Size = new Size(120, 27);
            DepoTextBox.TabIndex = 1;
            DepoTextBox.Text = "Depo İşlemleri";
            DepoTextBox.UseVisualStyleBackColor = true;
            DepoTextBox.Click += DepoTextBox_Click;
            // 
            // RaporTextBox
            // 
            RaporTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RaporTextBox.Location = new Point(339, 30);
            RaporTextBox.Name = "RaporTextBox";
            RaporTextBox.Size = new Size(120, 27);
            RaporTextBox.TabIndex = 2;
            RaporTextBox.Text = "Stok Raporları";
            RaporTextBox.UseVisualStyleBackColor = true;
            RaporTextBox.Click += RaporTextBox_Click;
            // 
            // KullaniciTextBox
            // 
            KullaniciTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            KullaniciTextBox.Location = new Point(465, 30);
            KullaniciTextBox.Name = "KullaniciTextBox";
            KullaniciTextBox.Size = new Size(120, 27);
            KullaniciTextBox.TabIndex = 3;
            KullaniciTextBox.Text = "Kullanıcı Yönetimi";
            KullaniciTextBox.UseVisualStyleBackColor = true;
            KullaniciTextBox.Click += KullaniciTextBox_Click;
            // 
            // AyarlarTextBox
            // 
            AyarlarTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AyarlarTextBox.Location = new Point(591, 30);
            AyarlarTextBox.Name = "AyarlarTextBox";
            AyarlarTextBox.Size = new Size(129, 27);
            AyarlarTextBox.TabIndex = 4;
            AyarlarTextBox.Text = "Ayarlar ve Güvenlik";
            AyarlarTextBox.UseVisualStyleBackColor = true;
            AyarlarTextBox.Click += AyarlarTextBox_Click;
            // 
            // Anasayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(AyarlarTextBox);
            Controls.Add(KullaniciTextBox);
            Controls.Add(RaporTextBox);
            Controls.Add(DepoTextBox);
            Controls.Add(MalzemeTextBox);
            Name = "Anasayfa";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button MalzemeTextBox;
        private Button DepoTextBox;
        private Button RaporTextBox;
        private Button KullaniciTextBox;
        private Button AyarlarTextBox;
    }
}