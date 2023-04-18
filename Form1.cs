namespace Tooltips
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtName_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Enter a name between 3 and 12 characters", txtName);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            cmbNames.Items.Add(txtName.Text);
            txtName.Text = "";
        }
    }
}