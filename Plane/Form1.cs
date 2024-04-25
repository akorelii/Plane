using System.Media;

namespace Plane
{
    public partial class Form1 : Form
    {
        SoundPlayer player = new SoundPlayer(Resource1.isikacmakapamasesi);
        bool thrustOn;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            thrustOn = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            thrustOn = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ucakIsik.Visible == true)
            {
                ucakIsik.Visible = false;
                button1.Text = "TURN ON THE LIGHTS";
            }
            else
            {
                ucakIsik.Visible = true;
                button1.Text = "TURN OFF THE LIGHTS";
            }
            player.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (thrustOn)
            {
                ucak.Location = new Point(ucak.Location.X, ucak.Location.Y - 1);
                ucakIsik.Location = new Point(ucakIsik.Location.X, ucakIsik.Location.Y - 1);
            }else
            {
                ucak.Location = new Point(ucak.Location.X, ucak.Location.Y + 1);
                ucakIsik.Location = new Point(ucakIsik.Location.X, ucakIsik.Location.Y + 1);
            }
        }
    }
}
