namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            nameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            girisButton = new Button();
            kayitButton = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(61, 108);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 11;
            label2.Text = "Parola";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(61, 79);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 10;
            label1.Text = "Kullanıcı Adı";
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.Location = new Point(140, 76);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(92, 23);
            nameTextBox.TabIndex = 9;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PasswordTextBox.Location = new Point(140, 105);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(92, 23);
            PasswordTextBox.TabIndex = 8;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // girisButton
            // 
            girisButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            girisButton.Location = new Point(261, 73);
            girisButton.Name = "girisButton";
            girisButton.Size = new Size(93, 26);
            girisButton.TabIndex = 7;
            girisButton.Text = "Giriş Yap";
            girisButton.UseVisualStyleBackColor = true;
            girisButton.Click += girisButton_Click;
            // 
            // kayitButton
            // 
            kayitButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kayitButton.Location = new Point(261, 108);
            kayitButton.Name = "kayitButton";
            kayitButton.Size = new Size(93, 26);
            kayitButton.TabIndex = 6;
            kayitButton.Text = "Kayıt Ol";
            kayitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 201);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nameTextBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(girisButton);
            Controls.Add(kayitButton);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox nameTextBox;
        private TextBox PasswordTextBox;
        private Button girisButton;
        private Button kayitButton;
    }
}
