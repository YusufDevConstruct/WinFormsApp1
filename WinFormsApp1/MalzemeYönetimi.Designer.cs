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
            button4 = new Button();
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
            MalzemesilTextBox.Click += this.button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(377, 12);
            button3.Name = "button3";
            button3.Size = new Size(109, 72);
            button3.TabIndex = 2;
            button3.Text = "Malzeme Güncelle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += this.button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(492, 12);
            button4.Name = "button4";
            button4.Size = new Size(109, 72);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // MalzemeYönetimi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(MalzemesilTextBox);
            Controls.Add(MalzemeekleTextBox);
            Name = "MalzemeYönetimi";
            Text = "Form3";
            ResumeLayout(false);
        }

        #endregion

        private Button MalzemeekleTextBox;
        private Button MalzemesilTextBox;
        private Button button3;
        private Button button4;
    }
}