namespace WinFormsApp1
{
    partial class Ayarlar_ve_Güvenlik
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
            FirebaseEntegrasyonuTextBox = new Button();
            VeriGuvenligiTextBox = new Button();
            VeriYedeklemeTextBox = new Button();
            SistemAyarlariTextBox = new Button();
            SuspendLayout();
            // 
            // FirebaseEntegrasyonuTextBox
            // 
            FirebaseEntegrasyonuTextBox.Location = new Point(12, 20);
            FirebaseEntegrasyonuTextBox.Name = "FirebaseEntegrasyonuTextBox";
            FirebaseEntegrasyonuTextBox.Size = new Size(115, 53);
            FirebaseEntegrasyonuTextBox.TabIndex = 0;
            FirebaseEntegrasyonuTextBox.Text = "Firebase Entegrasyonu";
            FirebaseEntegrasyonuTextBox.UseVisualStyleBackColor = true;
            // 
            // VeriGuvenligiTextBox
            // 
            VeriGuvenligiTextBox.Location = new Point(143, 20);
            VeriGuvenligiTextBox.Name = "VeriGuvenligiTextBox";
            VeriGuvenligiTextBox.Size = new Size(115, 53);
            VeriGuvenligiTextBox.TabIndex = 1;
            VeriGuvenligiTextBox.Text = "Veri Güvenliği";
            VeriGuvenligiTextBox.UseVisualStyleBackColor = true;
            // 
            // VeriYedeklemeTextBox
            // 
            VeriYedeklemeTextBox.Location = new Point(274, 20);
            VeriYedeklemeTextBox.Name = "VeriYedeklemeTextBox";
            VeriYedeklemeTextBox.Size = new Size(115, 53);
            VeriYedeklemeTextBox.TabIndex = 2;
            VeriYedeklemeTextBox.Text = "Veri Yedekleme";
            VeriYedeklemeTextBox.UseVisualStyleBackColor = true;
            // 
            // SistemAyarlariTextBox
            // 
            SistemAyarlariTextBox.Location = new Point(407, 20);
            SistemAyarlariTextBox.Name = "SistemAyarlariTextBox";
            SistemAyarlariTextBox.Size = new Size(115, 53);
            SistemAyarlariTextBox.TabIndex = 3;
            SistemAyarlariTextBox.Text = "Sistem Ayarları";
            SistemAyarlariTextBox.UseVisualStyleBackColor = true;
            // 
            // Ayarlar_ve_Güvenlik
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SistemAyarlariTextBox);
            Controls.Add(VeriYedeklemeTextBox);
            Controls.Add(VeriGuvenligiTextBox);
            Controls.Add(FirebaseEntegrasyonuTextBox);
            Name = "Ayarlar_ve_Güvenlik";
            Text = "Ayarlar_ve_Güvenlik";
            ResumeLayout(false);
        }

        #endregion

        private Button FirebaseEntegrasyonuTextBox;
        private Button VeriGuvenligiTextBox;
        private Button VeriYedeklemeTextBox;
        private Button SistemAyarlariTextBox;
    }
}