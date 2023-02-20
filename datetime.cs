namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
  
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            london_photo.Visible = false;
            baku_photo.Visible = true;
            Text = DateTime.Now.ToLongTimeString();

        }

        private void london_button_Click(object sender, EventArgs e)
        {
            baku_photo.Visible=false;
            london_photo.Visible = true;
            Text = DateTime.UtcNow.ToLongTimeString();
        }
    }
}