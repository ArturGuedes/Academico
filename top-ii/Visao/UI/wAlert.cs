using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visao.UI
{
    public partial class wAlert : UI.wForm
    {
        private static String _text = "";
        private static int _timerInt = 100;
        private static bool _timerEna = true;

        private wAlert()
        {
            InitializeComponent();
            label1.Text = _text;
            timer1.Interval = _timerInt;
            timer1.Enabled = _timerEna;
        }

        public static void Show(String text, int timer)
        {
            _text = text;
            if ( timer <= 0 )
            {
                _timerEna = false;
            }
            else
            {
                _timerInt = timer;  
            }

            wAlert n = new wAlert();

            n.label1.AutoSize = true;
            n.Size = new Size(n.label1.Width + 60, n.label1.Height + 60);
            n.ShowDialog();  
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
