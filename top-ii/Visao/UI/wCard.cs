using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visao.UI
{
    public partial class wCard : Panel
    {

        public const String _c = "Card";

        [Category(_c), Description("Cor do fundo")]
        public Color BackgroudColor { get; set; }

        [Category(_c), Description("Posição da sombra")]
        public int BackgroudX { get; set; }
        [Category(_c), Description("Posição da sombra")]
        public int BackgroudY { get; set; }
        [Category(_c), Description("Posição da sombra")]
        public int BackgroudW { get; set; }
        [Category(_c), Description("Posição da sombra")]
        public int BackgroudH { get; set; }

        [Category(_c), Description("Cor da Sombra")]
        public Color ShadowColor { get; set; }
        [Category(_c), Description("Opacidade da sombra")]
        public int ShadowOpacity { get; set; }

        public wCard()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;

            Padding = new Padding(4);

            BackgroudX = 0;
            BackgroudY = 0;
            BackgroudW = 2;
            BackgroudH = 2;

            //BackgroudX = 1;
            //BackgroudY = 3;
            //BackgroudW = 3;
            //BackgroudH = 3;

            ShadowOpacity = 10;
            BackgroudColor = Color.White;
            ShadowColor = Color.Black;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(pe);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;


            for (int i = 0; i < ShadowOpacity; i++)
            {
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(i * 10, ShadowColor)))
                {
                    g.FillRectangle(brush, BackgroudX + i, BackgroudY + i, this.Width - i * BackgroudW, this.Height - i * BackgroudH);
                }
            }

            using (SolidBrush brush = new SolidBrush(BackgroudColor))
            {
                g.FillRectangle(brush, 0 + 5, 0 + 5, this.Width - 10, this.Height - 10);
            }

            //g.Dispose();
        }
    }
}
