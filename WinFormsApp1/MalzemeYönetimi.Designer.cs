
namespace WinFormsApp1
{
    partial class MalzemeYönetimi
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
            MalzemeEkleTextBox = new Button();
            MalzemesilTextBox = new Button();
            button3 = new Button();
            StokMiktarTextBox = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // MalzemeEkleTextBox
            // 
            MalzemeEkleTextBox.Location = new Point(168, 16);
            MalzemeEkleTextBox.Margin = new Padding(3, 4, 3, 4);
            MalzemeEkleTextBox.Name = "MalzemeEkleTextBox";
            MalzemeEkleTextBox.Size = new Size(125, 96);
            MalzemeEkleTextBox.TabIndex = 0;
            MalzemeEkleTextBox.Text = "Malzeme Ekle";
            MalzemeEkleTextBox.UseVisualStyleBackColor = true;
            MalzemeEkleTextBox.Click += button1_Click;
            // 
            // MalzemesilTextBox
            // 
            MalzemesilTextBox.Location = new Point(299, 16);
            MalzemesilTextBox.Margin = new Padding(3, 4, 3, 4);
            MalzemesilTextBox.Name = "MalzemesilTextBox";
            MalzemesilTextBox.Size = new Size(125, 96);
            MalzemesilTextBox.TabIndex = 1;
            MalzemesilTextBox.Text = "Malzeme Sil";
            MalzemesilTextBox.UseVisualStyleBackColor = true;
            MalzemesilTextBox.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(431, 16);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(125, 96);
            button3.TabIndex = 2;
            button3.Text = "Malzeme Güncelle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // StokMiktarTextBox
            // 
            StokMiktarTextBox.Location = new Point(562, 16);
            StokMiktarTextBox.Margin = new Padding(3, 4, 3, 4);
            StokMiktarTextBox.Name = "StokMiktarTextBox";
            StokMiktarTextBox.Size = new Size(125, 96);
            StokMiktarTextBox.TabIndex = 3;
            StokMiktarTextBox.Text = "Stok Miktarını Kontrol Et";
            StokMiktarTextBox.UseVisualStyleBackColor = true;
            StokMiktarTextBox.Click += button4_Click;
            // 
            // MalzemeYönetimi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(StokMiktarTextBox);
            Controls.Add(button3);
            Controls.Add(MalzemesilTextBox);
            Controls.Add(MalzemeEkleTextBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MalzemeYönetimi";
            Text = "Form3";
            ResumeLayout(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button MalzemeEkleTextBox;

        private Button MalzemesilTextBox;
        private Button button3;
        private Button StokMiktarTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}