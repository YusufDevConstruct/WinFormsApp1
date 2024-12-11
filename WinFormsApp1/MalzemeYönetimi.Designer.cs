
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
            MalzemeekleTextBox = new Button();
            MalzemesilTextBox = new Button();
            button3 = new Button();
            StokMiktarTextBox = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // MalzemeekleTextBox
            // 
            MalzemeekleTextBox.Location = new Point(147, 12);
            MalzemeekleTextBox.Name = "MalzemeekleTextBox";
            MalzemeekleTextBox.Size = new Size(109, 72);
            MalzemeekleTextBox.TabIndex = 0;
            MalzemeekleTextBox.Text = "Malzeme Ekle";
            MalzemeekleTextBox.UseVisualStyleBackColor = true;
            MalzemeekleTextBox.Click += button1_Click;
            // 
            // MalzemesilTextBox
            // 
            MalzemesilTextBox.Location = new Point(262, 12);
            MalzemesilTextBox.Name = "MalzemesilTextBox";
            MalzemesilTextBox.Size = new Size(109, 72);
            MalzemesilTextBox.TabIndex = 1;
            MalzemesilTextBox.Text = "Malzeme Sil";
            MalzemesilTextBox.UseVisualStyleBackColor = true;
            MalzemesilTextBox.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(377, 12);
            button3.Name = "button3";
            button3.Size = new Size(109, 72);
            button3.TabIndex = 2;
            button3.Text = "Malzeme Güncelle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // StokMiktarTextBox
            // 
            StokMiktarTextBox.Location = new Point(492, 12);
            StokMiktarTextBox.Name = "StokMiktarTextBox";
            StokMiktarTextBox.Size = new Size(109, 72);
            StokMiktarTextBox.TabIndex = 3;
            StokMiktarTextBox.Text = "Stok Miktarını Kontrol Et";
            StokMiktarTextBox.UseVisualStyleBackColor = true;
            StokMiktarTextBox.Click += button4_Click;
            // 
            // MalzemeYönetimi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(StokMiktarTextBox);
            Controls.Add(button3);
            Controls.Add(MalzemesilTextBox);
            Controls.Add(MalzemeekleTextBox);
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

        private Button MalzemeekleTextBox;
        private Button MalzemesilTextBox;
        private Button button3;
        private Button StokMiktarTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}