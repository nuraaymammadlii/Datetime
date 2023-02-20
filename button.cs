namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            Random a = new Random();
            int location_A = a.Next(0, 672);
            int location_B = a.Next(0, 445);

            button1.Location = new Point(location_A, location_B);
        }
    }
}