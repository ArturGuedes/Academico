using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Visao.UI
{
    public partial class wForm : Form
    {
        // Propriedades
        private Color 
            borderColor, 
            titlebarColor, 
            windowbarColor, 
            ColorTop, 
            ColorBottom;
        private int borderSize;
        private bool 
            titlebarActive, 
            darkActive, 
            resizeActive, 
            windowbarActive;

        // Configurações
        private Point _mouseLocation;
        private const String _category = "Custom Window";



        #region Métodos

        [Category(_category), Description("Cor da borda")]
        public Color BorderColor { get { return borderColor; } set { borderColor = value; FormUpdate(); } }
        [Category(_category), Description("Tamanho da borda")]
        public int BorderSize { get { return borderSize; } set { borderSize = value; FormUpdate(); } }

        [Category(_category), Description("Estilo escuro")]
        public bool DarkStyle { get { return darkActive; } set { darkActive = value; FormUpdate(); } }

        [Category(_category), Description("Cor da borda")]
        public Color GradientColorTop { get { return ColorTop; } set { ColorTop = value; FormUpdate(); } }
        [Category(_category), Description("Cor da borda")]
        public Color GradientColorBottom { get { return ColorBottom; } set { ColorBottom = value; FormUpdate(); } }

        [Category(_category), Description("Visibilidade da Barra de Título")]
        public bool TitleBar { get { return titlebarActive; } set { titlebarActive = value; FormUpdate(); } }
        [Category(_category), Description("Cor da Barra de Título")]
        public Color TitleBarColor { get { return titlebarColor; } set { titlebarColor = value; FormUpdate(); } }

        [Category(_category), Description("Barra da janela")]
        public bool WindowBar { get { return windowbarActive; } set { windowbarActive = value; FormUpdate(); } }
        [Category(_category), Description("Cor da Janela")]
        public Color WindowBarColor {  get { return windowbarColor; } set { windowbarColor = value; FormUpdate(); } }
        [Category(_category), Description("Redimensionamento de janela")]
        public bool WindowResize { get { return resizeActive; } set { resizeActive = value; FormUpdate(); } }

        #endregion

        public wForm()
        {
            InitializeComponent();

            borderColor = Color.DarkGray;
            borderSize = 2;
            darkActive = false;
            resizeActive = true;
            titlebarActive = true;
            titlebarColor = Color.DarkGray;
            windowbarActive = true;
            windowbarColor = Color.Gray;

            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        // ----------------------------------------------------

        private void FormUpdate()
        {
            if (darkActive)
            {
                btnMin.Image = Properties.Resources.min_black;
                btnMax.Image = Properties.Resources.maximizar_black;
                btnClose.Image = Properties.Resources.fechar_black;
            }
            if (resizeActive)
            {
                btnMin.Visible = true;
                btnMax.Visible = true;
            }
            else
            {
                btnMin.Visible = false;
                btnMax.Visible = false;
            }
            if (windowbarActive)
            {
                _windowbar.Visible = true;
            }
            else
            {
                _windowbar.Visible = false;
            }

            title.Text = this.Text;
            if (titlebarActive == false) { _titlebar.Visible = false; } else { _titlebar.Visible = true; }
            _windowbar.BackColor = windowbarColor;
            _titlebar.BackColor = titlebarColor;

            this.Padding = new System.Windows.Forms.Padding(borderSize);
        }

        // --------------------------------------------

        #region Botões de controle da Janela

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                FormUpdate();
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                FormUpdate();
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region Movimentação da Janela

        private void _windowbar_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLocation = new Point(-e.X, -e.Y);
        }

        private void _windowbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                if (e.Button == MouseButtons.Left)
                {
                    Point mousePos = Control.MousePosition;
                    mousePos.Offset(_mouseLocation.X, _mouseLocation.Y);
                    Location = mousePos;
                }
            }
        }

        #endregion

        #region Configurações de Borda

        Rectangle _Top { get { return new Rectangle(0, 0, this.ClientSize.Width, borderSize); } }
        Rectangle _Left { get { return new Rectangle(0, 0, borderSize, this.ClientSize.Height); } }
        Rectangle _Bottom { get { return new Rectangle(0, this.ClientSize.Height - borderSize, this.ClientSize.Width, borderSize); } }
        Rectangle _Right { get { return new Rectangle(this.ClientSize.Width - borderSize, 0, borderSize, this.ClientSize.Height); } }

        Rectangle _TopLeft { get { return new Rectangle(0, 0, borderSize, borderSize); } }
        Rectangle _TopRight { get { return new Rectangle(this.ClientSize.Width - borderSize, 0, borderSize, borderSize); } }
        Rectangle _BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - borderSize, borderSize, borderSize); } }
        Rectangle _BottomRight { get { return new Rectangle(this.ClientSize.Width - borderSize, this.ClientSize.Height - borderSize, borderSize, borderSize); } }

        private const int
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17;

        #endregion

        #region Configurações de Sombreamento

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        private bool m_aeroEnabled;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]

        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }

        #endregion

        // --------------------------------------------

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, this.ColorTop, this.ColorBottom, 90F);
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, this.ClientRectangle);

            Brush cor = new SolidBrush(borderColor);
            e.Graphics.FillRectangle(cor, _Top);
            e.Graphics.FillRectangle(cor, _Left);
            e.Graphics.FillRectangle(cor, _Right);
            e.Graphics.FillRectangle(cor, _Bottom);

            //base.OnPaint(e);
        }

        private void Window_Load(object sender, EventArgs e)
        { 
            FormUpdate(); 
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            //Borda
            if (resizeActive)
            {
                if (m.Msg == 0x84) // WM_NCHITTEST
                {
                    var cursor = this.PointToClient(Cursor.Position);

                    if (_TopLeft.Contains(cursor)) m.Result = (IntPtr)HTTOPLEFT;
                    else if (_TopRight.Contains(cursor)) m.Result = (IntPtr)HTTOPRIGHT;
                    else if (_BottomLeft.Contains(cursor)) m.Result = (IntPtr)HTBOTTOMLEFT;
                    else if (_BottomRight.Contains(cursor)) m.Result = (IntPtr)HTBOTTOMRIGHT;

                    else if (_Top.Contains(cursor)) m.Result = (IntPtr)HTTOP;
                    else if (_Left.Contains(cursor)) m.Result = (IntPtr)HTLEFT;
                    else if (_Right.Contains(cursor)) m.Result = (IntPtr)HTRIGHT;
                    else if (_Bottom.Contains(cursor)) m.Result = (IntPtr)HTBOTTOM;
                }
            }

            //Sombra
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default: break;
            }
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }
    }
}
