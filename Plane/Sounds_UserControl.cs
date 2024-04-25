using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Plane
{
    public partial class Sounds_UserControl : UserControl
    {
        SoundPlayer soundPlayer;
        public Sounds_UserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer(Resource1.inishazirliklari);
            soundPlayer.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer(Resource1.turbulans);
            soundPlayer.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer(Resource1.kemerler);
            soundPlayer.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer(Resource1.tesekkurler);
            soundPlayer.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer(Resource1.beep);
            soundPlayer.Play();
        }
    }
}
