namespace WinFormsApp1
{
    partial class StokRaporları
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
            GunlukRaporTextBox = new Button();
            HaftalıkRaporTextBox = new Button();
            AylıkRaporTextBox = new Button();
            YıllıkRaporTextBox = new Button();
            SuspendLayout();
            // 
            // GunlukRaporTextBox
            // 
            GunlukRaporTextBox.Location = new Point(17, 30);
            GunlukRaporTextBox.Name = "GunlukRaporTextBox";
            GunlukRaporTextBox.Size = new Size(109, 47);
            GunlukRaporTextBox.TabIndex = 0;
            GunlukRaporTextBox.Text = "Günlük Raporlar";
            GunlukRaporTextBox.UseVisualStyleBackColor = true;
            // 
            // HaftalıkRaporTextBox
            // 
            HaftalıkRaporTextBox.Location = new Point(142, 30);
            HaftalıkRaporTextBox.Name = "HaftalıkRaporTextBox";
            HaftalıkRaporTextBox.Size = new Size(109, 47);
            HaftalıkRaporTextBox.TabIndex = 1;
            HaftalıkRaporTextBox.Text = "Haftalık Raporlar";
            HaftalıkRaporTextBox.UseVisualStyleBackColor = true;
            // 
            // AylıkRaporTextBox
            // 
            AylıkRaporTextBox.Location = new Point(257, 30);
            AylıkRaporTextBox.Name = "AylıkRaporTextBox";
            AylıkRaporTextBox.Size = new Size(109, 47);
            AylıkRaporTextBox.TabIndex = 2;
            AylıkRaporTextBox.Text = "Aylık Raporlar";
            AylıkRaporTextBox.UseVisualStyleBackColor = true;
            // 
            // YıllıkRaporTextBox
            // 
            YıllıkRaporTextBox.Location = new Point(372, 30);
            YıllıkRaporTextBox.Name = "YıllıkRaporTextBox";
            YıllıkRaporTextBox.Size = new Size(109, 47);
            YıllıkRaporTextBox.TabIndex = 3;
            YıllıkRaporTextBox.Text = "Yıllık Raporlar";
            YıllıkRaporTextBox.UseVisualStyleBackColor = true;
            // 
            // StokRaporları
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(YıllıkRaporTextBox);
            Controls.Add(AylıkRaporTextBox);
            Controls.Add(HaftalıkRaporTextBox);
            Controls.Add(GunlukRaporTextBox);
            Name = "StokRaporları";
            Text = "StokRaporları";
            ResumeLayout(false);
        }

        #endregion

        private Button GunlukRaporTextBox;
        private Button HaftalıkRaporTextBox;
        private Button AylıkRaporTextBox;
        private Button YıllıkRaporTextBox;
    }
}