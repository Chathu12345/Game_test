using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAME_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int vdir = +1;
        private void vert_Tick(object sender, EventArgs e)
        {
            if (ball.Top < 0)
            {
                vdir = +1;
            }
            else if (ball.Top > (this.Height - ball.Height - slid.Height))
            {
                vdir = -1;
            }
            else
            {
                ball.Top += vdir;
            }

        }

        int hdir = +1;
        private void horz_Tick(object sender, EventArgs e)
        {
            if (ball.Left < 0)
            {
                hdir = +1;
            }
            else if (ball.Left > (this.Width - ball.Width))
            {
                hdir = -1;
            }
            else
            {
                ball.Left += hdir;
            }
        }

        private void ball_Click(object sender, EventArgs e)
        {

        }
    }
}
