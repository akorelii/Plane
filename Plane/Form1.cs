namespace Plane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            while (true)
            {
                ucak.Location = new Point(ucak.Location.X, ucak.Location.Y - 1);
                ucakIsik.Location = new Point(ucakIsik.Location.X, ucakIsik.Location.Y - 1);

                Thread.Sleep(50);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            while (true)
            {
                ucak.Location = new Point(ucak.Location.X, ucak.Location.Y + 1);
                ucakIsik.Location = new Point(ucakIsik.Location.X, ucakIsik.Location.Y + 1);

                Thread.Sleep(50);
            }
        }
    }
}
