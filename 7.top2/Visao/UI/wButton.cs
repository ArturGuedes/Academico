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
    public partial class wButton : Button
    {
        public wButton()
        {
            InitializeComponent();

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            BackColor = Color.FromArgb(41, 44, 51);
            ForeColor = Color.White;
            Padding = new Padding(4);
            Font = new Font("Roboto",9.5f);
            AutoSize = true;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe); Text = Text.ToUpper();
        }

    }
}
