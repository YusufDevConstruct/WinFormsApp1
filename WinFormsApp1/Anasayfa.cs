namespace WinFormsApp1
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void girisButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "gamegamegame31" && PasswordTextBox.Text == "aslan1212")
            {
                MessageBox.Show("Giri� Ba�ar�l�!", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Nah Girersin!", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
