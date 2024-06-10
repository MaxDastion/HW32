namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender != radioButton3)
            {
                groupBox6.Enabled = true;
                groupBox6.Visible = true;
            }
            else {
                groupBox6.Enabled = false;
                groupBox6.Visible = false;
            }
        }
    }
}
