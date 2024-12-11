namespace WinFormsApp1
{
    partial class Depoİslemleri
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
            StokGirisiTextBox = new Button();
            StokCikisiTextBox = new Button();
            İslemGecmisiTextBox = new Button();
            StokHareketleriTextBox = new Button();
            SuspendLayout();
            // 
            // StokGirisiTextBox
            // 
            StokGirisiTextBox.Location = new Point(49, 27);
            StokGirisiTextBox.Name = "StokGirisiTextBox";
            StokGirisiTextBox.Size = new Size(122, 61);
            StokGirisiTextBox.TabIndex = 0;
            StokGirisiTextBox.Text = "Stok Girişi";
            StokGirisiTextBox.UseVisualStyleBackColor = true;
            // 
            // StokCikisiTextBox
            // 
            StokCikisiTextBox.Location = new Point(239, 27);
            StokCikisiTextBox.Name = "StokCikisiTextBox";
            StokCikisiTextBox.Size = new Size(122, 61);
            StokCikisiTextBox.TabIndex = 1;
            StokCikisiTextBox.Text = "Stok Çıkışı";
            StokCikisiTextBox.UseVisualStyleBackColor = true;
            // 
            // İslemGecmisiTextBox
            // 
            İslemGecmisiTextBox.Location = new Point(418, 27);
            İslemGecmisiTextBox.Name = "İslemGecmisiTextBox";
            İslemGecmisiTextBox.Size = new Size(122, 61);
            İslemGecmisiTextBox.TabIndex = 2;
            İslemGecmisiTextBox.Text = "İşlem Geçmişi";
            İslemGecmisiTextBox.UseVisualStyleBackColor = true;
            // 
            // StokHareketleriTextBox
            // 
            StokHareketleriTextBox.Location = new Point(605, 27);
            StokHareketleriTextBox.Name = "StokHareketleriTextBox";
            StokHareketleriTextBox.Size = new Size(122, 61);
            StokHareketleriTextBox.TabIndex = 3;
            StokHareketleriTextBox.Text = "Stok Hareketleri";
            StokHareketleriTextBox.UseVisualStyleBackColor = true;
            // 
            // Depoislemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(StokHareketleriTextBox);
            Controls.Add(İslemGecmisiTextBox);
            Controls.Add(StokCikisiTextBox);
            Controls.Add(StokGirisiTextBox);
            Name = "Depoislemleri";
            Text = "Depoislemleri";
            ResumeLayout(false);
        }

        #endregion

        private Button StokGirisiTextBox;
        private Button StokCikisiTextBox;
        private Button İslemGecmisiTextBox;
        private Button StokHareketleriTextBox;
    }
}