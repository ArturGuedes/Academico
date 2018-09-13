namespace Visao
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.webView = new System.Windows.Forms.WebBrowser();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wButton2 = new Visao.UI.wButton();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.pMain = new System.Windows.Forms.Panel();
            this.pContainer = new System.Windows.Forms.SplitContainer();
            this.pLeft = new System.Windows.Forms.Panel();
            this.pCard = new System.Windows.Forms.Panel();
            this.wCard1 = new Visao.UI.wCard();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblContato = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pEditar = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCadastrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnRemover = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lpExibição = new System.Windows.Forms.Panel();
            this.btbSplit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMapaView = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnListView = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pTop = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.itemAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.itemLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSair = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.itemCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.itemRemover = new System.Windows.Forms.ToolStripMenuItem();
            this.itemExibir = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMapaView = new System.Windows.Forms.ToolStripMenuItem();
            this.itemGridView = new System.Windows.Forms.ToolStripMenuItem();
            this.janelaDivididaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemBD = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemImprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.Document = new System.Drawing.Printing.PrintDocument();
            this.Print = new System.Windows.Forms.PrintDialog();
            this.Save = new System.Windows.Forms.SaveFileDialog();
            this.Open = new System.Windows.Forms.OpenFileDialog();
            this.itemInformacoes = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.pMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pContainer)).BeginInit();
            this.pContainer.Panel1.SuspendLayout();
            this.pContainer.Panel2.SuspendLayout();
            this.pContainer.SuspendLayout();
            this.pLeft.SuspendLayout();
            this.pCard.SuspendLayout();
            this.wCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pEditar.SuspendLayout();
            this.lpExibição.SuspendLayout();
            this.pTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // webView
            // 
            this.webView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView.IsWebBrowserContextMenuEnabled = false;
            this.webView.Location = new System.Drawing.Point(0, 0);
            this.webView.Margin = new System.Windows.Forms.Padding(0);
            this.webView.MinimumSize = new System.Drawing.Size(20, 20);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(696, 342);
            this.webView.TabIndex = 2;
            this.webView.Url = new System.Uri("https://www.openstreetmap.org/export/embed.html?bbox=-43.062458038330085%2C-22.88" +
        "3806184972904%2C-43.03889751434327%2C-22.869591635249325&amp;layer=mapnik", System.UriKind.Absolute);
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.AllowUserToResizeRows = false;
            this.gridView.BackgroundColor = System.Drawing.Color.White;
            this.gridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(179)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView.EnableHeadersVisualStyles = false;
            this.gridView.GridColor = System.Drawing.Color.WhiteSmoke;
            this.gridView.Location = new System.Drawing.Point(0, 0);
            this.gridView.MultiSelect = false;
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(179)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridView.RowTemplate.Height = 24;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.ShowCellErrors = false;
            this.gridView.ShowEditingIcon = false;
            this.gridView.Size = new System.Drawing.Size(696, 126);
            this.gridView.TabIndex = 1;
            this.gridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // wButton2
            // 
            this.wButton2.AutoSize = true;
            this.wButton2.BackColor = System.Drawing.Color.Blue;
            this.wButton2.FlatAppearance.BorderSize = 0;
            this.wButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wButton2.Font = new System.Drawing.Font("Roboto", 8.5F);
            this.wButton2.ForeColor = System.Drawing.Color.White;
            this.wButton2.Location = new System.Drawing.Point(19, 49);
            this.wButton2.Name = "wButton2";
            this.wButton2.Padding = new System.Windows.Forms.Padding(10);
            this.wButton2.Size = new System.Drawing.Size(99, 43);
            this.wButton2.TabIndex = 0;
            this.wButton2.Text = "WBUTTON2";
            this.wButton2.UseVisualStyleBackColor = false;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPesquisar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPesquisar.BackColor = System.Drawing.Color.White;
            this.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.ForeColor = System.Drawing.Color.Black;
            this.txtPesquisar.Location = new System.Drawing.Point(69, 28);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(362, 20);
            this.txtPesquisar.TabIndex = 2;
            this.txtPesquisar.Text = "Pesquisar";
            this.txtPesquisar.Enter += new System.EventHandler(this.txtPesquisar_Enter);
            this.txtPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisar_KeyDown);
            this.txtPesquisar.Leave += new System.EventHandler(this.txtPesquisar_Leave);
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pMain.Controls.Add(this.pContainer);
            this.pMain.Controls.Add(this.pLeft);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(2, 126);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(946, 472);
            this.pMain.TabIndex = 6;
            // 
            // pContainer
            // 
            this.pContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContainer.Location = new System.Drawing.Point(250, 0);
            this.pContainer.Name = "pContainer";
            this.pContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // pContainer.Panel1
            // 
            this.pContainer.Panel1.Controls.Add(this.webView);
            // 
            // pContainer.Panel2
            // 
            this.pContainer.Panel2.Controls.Add(this.gridView);
            this.pContainer.Size = new System.Drawing.Size(696, 472);
            this.pContainer.SplitterDistance = 342;
            this.pContainer.TabIndex = 5;
            // 
            // pLeft
            // 
            this.pLeft.AutoScroll = true;
            this.pLeft.AutoSize = true;
            this.pLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(65)))), ((int)(((byte)(73)))));
            this.pLeft.Controls.Add(this.pCard);
            this.pLeft.Controls.Add(this.pEditar);
            this.pLeft.Controls.Add(this.lpExibição);
            this.pLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLeft.Location = new System.Drawing.Point(0, 0);
            this.pLeft.MinimumSize = new System.Drawing.Size(250, 0);
            this.pLeft.Name = "pLeft";
            this.pLeft.Size = new System.Drawing.Size(250, 472);
            this.pLeft.TabIndex = 4;
            // 
            // pCard
            // 
            this.pCard.Controls.Add(this.wCard1);
            this.pCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCard.Location = new System.Drawing.Point(0, 415);
            this.pCard.MinimumSize = new System.Drawing.Size(250, 0);
            this.pCard.Name = "pCard";
            this.pCard.Size = new System.Drawing.Size(250, 221);
            this.pCard.TabIndex = 4;
            // 
            // wCard1
            // 
            this.wCard1.BackColor = System.Drawing.Color.Transparent;
            this.wCard1.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(57)))));
            this.wCard1.BackgroudH = 2;
            this.wCard1.BackgroudW = 2;
            this.wCard1.BackgroudX = 0;
            this.wCard1.BackgroudY = 0;
            this.wCard1.Controls.Add(this.lblEndereco);
            this.wCard1.Controls.Add(this.label8);
            this.wCard1.Controls.Add(this.lblContato);
            this.wCard1.Controls.Add(this.label6);
            this.wCard1.Controls.Add(this.lblNome);
            this.wCard1.Controls.Add(this.lblInfo);
            this.wCard1.Controls.Add(this.pictureBox1);
            this.wCard1.Controls.Add(this.label2);
            this.wCard1.Location = new System.Drawing.Point(6, 6);
            this.wCard1.Name = "wCard1";
            this.wCard1.Padding = new System.Windows.Forms.Padding(16, 4, 16, 4);
            this.wCard1.ShadowColor = System.Drawing.Color.Black;
            this.wCard1.ShadowOpacity = 10;
            this.wCard1.Size = new System.Drawing.Size(238, 209);
            this.wCard1.TabIndex = 3;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEndereco.Location = new System.Drawing.Point(96, 152);
            this.lblEndereco.MaximumSize = new System.Drawing.Size(135, 0);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(32, 17);
            this.lblEndereco.TabIndex = 11;
            this.lblEndereco.Text = "RUA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(19, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 14);
            this.label8.TabIndex = 10;
            this.label8.Text = "Endereço:";
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContato.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblContato.Location = new System.Drawing.Point(96, 121);
            this.lblContato.MaximumSize = new System.Drawing.Size(135, 0);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(125, 17);
            this.lblContato.TabIndex = 9;
            this.lblContato.Text = "+55 (21) 22222-2222";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(19, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "Contato:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNome.Location = new System.Drawing.Point(98, 59);
            this.lblNome.MaximumSize = new System.Drawing.Size(135, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 17);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "NOME";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(179)))), ((int)(((byte)(184)))));
            this.lblInfo.Location = new System.Drawing.Point(42, 19);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(98, 20);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "Informações";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Visao.Properties.Resources.info;
            this.pictureBox1.Location = new System.Drawing.Point(19, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(19, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hospital:";
            // 
            // pEditar
            // 
            this.pEditar.Controls.Add(this.label9);
            this.pEditar.Controls.Add(this.btnCadastrar);
            this.pEditar.Controls.Add(this.btnRemover);
            this.pEditar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pEditar.Location = new System.Drawing.Point(0, 235);
            this.pEditar.Name = "pEditar";
            this.pEditar.Size = new System.Drawing.Size(233, 180);
            this.pEditar.TabIndex = 6;
            this.pEditar.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 12F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(179)))), ((int)(((byte)(184)))));
            this.label9.Location = new System.Drawing.Point(28, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Administrar";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.AutoSize = true;
            this.btnCadastrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCadastrar.Depth = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Icon = global::Visao.Properties.Resources.add;
            this.btnCadastrar.Location = new System.Drawing.Point(32, 61);
            this.btnCadastrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Primary = true;
            this.btnCadastrar.Size = new System.Drawing.Size(187, 36);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar / Editar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.AutoSize = true;
            this.btnRemover.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemover.Depth = 0;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Icon = global::Visao.Properties.Resources.del;
            this.btnRemover.Location = new System.Drawing.Point(32, 112);
            this.btnRemover.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Primary = true;
            this.btnRemover.Size = new System.Drawing.Size(112, 36);
            this.btnRemover.TabIndex = 5;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // lpExibição
            // 
            this.lpExibição.Controls.Add(this.btbSplit);
            this.lpExibição.Controls.Add(this.label1);
            this.lpExibição.Controls.Add(this.btnMapaView);
            this.lpExibição.Controls.Add(this.btnListView);
            this.lpExibição.Dock = System.Windows.Forms.DockStyle.Top;
            this.lpExibição.Location = new System.Drawing.Point(0, 0);
            this.lpExibição.Name = "lpExibição";
            this.lpExibição.Size = new System.Drawing.Size(233, 235);
            this.lpExibição.TabIndex = 3;
            // 
            // btbSplit
            // 
            this.btbSplit.AutoSize = true;
            this.btbSplit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btbSplit.Depth = 0;
            this.btbSplit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbSplit.Icon = global::Visao.Properties.Resources.split;
            this.btbSplit.Location = new System.Drawing.Point(32, 164);
            this.btbSplit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btbSplit.Name = "btbSplit";
            this.btbSplit.Primary = true;
            this.btbSplit.Size = new System.Drawing.Size(143, 36);
            this.btbSplit.TabIndex = 6;
            this.btbSplit.Text = "Mapa  e Lista";
            this.btbSplit.UseVisualStyleBackColor = true;
            this.btbSplit.Click += new System.EventHandler(this.btbSplit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(179)))), ((int)(((byte)(184)))));
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exibir";
            // 
            // btnMapaView
            // 
            this.btnMapaView.AutoSize = true;
            this.btnMapaView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMapaView.Depth = 0;
            this.btnMapaView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMapaView.Icon = global::Visao.Properties.Resources.map_8;
            this.btnMapaView.Location = new System.Drawing.Point(32, 61);
            this.btnMapaView.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMapaView.Name = "btnMapaView";
            this.btnMapaView.Primary = true;
            this.btnMapaView.Size = new System.Drawing.Size(88, 36);
            this.btnMapaView.TabIndex = 4;
            this.btnMapaView.Text = "Mapa";
            this.btnMapaView.UseVisualStyleBackColor = true;
            this.btnMapaView.Click += new System.EventHandler(this.btnMapaView_Click);
            // 
            // btnListView
            // 
            this.btnListView.AutoSize = true;
            this.btnListView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnListView.Depth = 0;
            this.btnListView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListView.Icon = global::Visao.Properties.Resources.view_06_512;
            this.btnListView.Location = new System.Drawing.Point(32, 112);
            this.btnListView.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnListView.Name = "btnListView";
            this.btnListView.Primary = true;
            this.btnListView.Size = new System.Drawing.Size(179, 36);
            this.btnListView.TabIndex = 5;
            this.btnListView.Text = "Lista de hospitais";
            this.btnListView.UseVisualStyleBackColor = true;
            this.btnListView.Click += new System.EventHandler(this.btnListView_Click);
            // 
            // pTop
            // 
            this.pTop.Controls.Add(this.pictureBox2);
            this.pTop.Controls.Add(this.txtPesquisar);
            this.pTop.Controls.Add(this.menu);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.ForeColor = System.Drawing.Color.Black;
            this.pTop.Location = new System.Drawing.Point(2, 26);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(946, 100);
            this.pTop.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Visao.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(32, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // menu
            // 
            this.menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemAdmin,
            this.itemExibir,
            this.itemBD});
            this.menu.Location = new System.Drawing.Point(638, 28);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(284, 30);
            this.menu.TabIndex = 5;
            this.menu.Text = "menuStrip1";
            // 
            // itemAdmin
            // 
            this.itemAdmin.BackColor = System.Drawing.Color.Transparent;
            this.itemAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemLogin,
            this.toolStripSeparator2,
            this.itemCadastrar,
            this.itemRemover});
            this.itemAdmin.Name = "itemAdmin";
            this.itemAdmin.Size = new System.Drawing.Size(99, 26);
            this.itemAdmin.Text = "Administrar";
            // 
            // itemLogin
            // 
            this.itemLogin.BackColor = System.Drawing.Color.Transparent;
            this.itemLogin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemSair});
            this.itemLogin.Name = "itemLogin";
            this.itemLogin.Size = new System.Drawing.Size(143, 24);
            this.itemLogin.Text = "Login";
            this.itemLogin.Click += new System.EventHandler(this.itemLogin_Click);
            // 
            // itemSair
            // 
            this.itemSair.Name = "itemSair";
            this.itemSair.Size = new System.Drawing.Size(104, 24);
            this.itemSair.Text = "Sair";
            this.itemSair.Visible = false;
            this.itemSair.Click += new System.EventHandler(this.itemSair_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(140, 6);
            // 
            // itemCadastrar
            // 
            this.itemCadastrar.Enabled = false;
            this.itemCadastrar.Name = "itemCadastrar";
            this.itemCadastrar.Size = new System.Drawing.Size(143, 24);
            this.itemCadastrar.Text = "Cadastrar";
            this.itemCadastrar.Click += new System.EventHandler(this.itemCadastrar_Click);
            // 
            // itemRemover
            // 
            this.itemRemover.Enabled = false;
            this.itemRemover.Name = "itemRemover";
            this.itemRemover.Size = new System.Drawing.Size(143, 24);
            this.itemRemover.Text = "Remover";
            this.itemRemover.Click += new System.EventHandler(this.itemRemover_Click);
            // 
            // itemExibir
            // 
            this.itemExibir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMapaView,
            this.itemGridView,
            this.janelaDivididaToolStripMenuItem});
            this.itemExibir.Name = "itemExibir";
            this.itemExibir.Size = new System.Drawing.Size(58, 26);
            this.itemExibir.Text = "Exibir";
            // 
            // itemMapaView
            // 
            this.itemMapaView.Name = "itemMapaView";
            this.itemMapaView.Size = new System.Drawing.Size(200, 24);
            this.itemMapaView.Text = "Mapa";
            this.itemMapaView.Click += new System.EventHandler(this.itemMapaView_Click);
            // 
            // itemGridView
            // 
            this.itemGridView.Name = "itemGridView";
            this.itemGridView.Size = new System.Drawing.Size(200, 24);
            this.itemGridView.Text = "Lista de Hospitais";
            this.itemGridView.Click += new System.EventHandler(this.itemGridView_Click);
            // 
            // janelaDivididaToolStripMenuItem
            // 
            this.janelaDivididaToolStripMenuItem.Name = "janelaDivididaToolStripMenuItem";
            this.janelaDivididaToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.janelaDivididaToolStripMenuItem.Text = "Janela Dividida";
            this.janelaDivididaToolStripMenuItem.Click += new System.EventHandler(this.itemSplit_Click);
            // 
            // itemBD
            // 
            this.itemBD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemAbrir,
            this.itemSalvar,
            this.itemImprimir,
            this.toolStripSeparator1,
            this.itemInformacoes});
            this.itemBD.Name = "itemBD";
            this.itemBD.Size = new System.Drawing.Size(119, 26);
            this.itemBD.Text = "Base de dados";
            // 
            // itemAbrir
            // 
            this.itemAbrir.Name = "itemAbrir";
            this.itemAbrir.Size = new System.Drawing.Size(163, 24);
            this.itemAbrir.Text = "Abrir";
            this.itemAbrir.Visible = false;
            this.itemAbrir.Click += new System.EventHandler(this.itemAbrir_Click);
            // 
            // itemSalvar
            // 
            this.itemSalvar.Name = "itemSalvar";
            this.itemSalvar.Size = new System.Drawing.Size(163, 24);
            this.itemSalvar.Text = "Salvar";
            this.itemSalvar.Click += new System.EventHandler(this.itemSalvar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // itemImprimir
            // 
            this.itemImprimir.Name = "itemImprimir";
            this.itemImprimir.Size = new System.Drawing.Size(163, 24);
            this.itemImprimir.Text = "Imprimir";
            this.itemImprimir.Click += new System.EventHandler(this.itemImprimir_Click);
            // 
            // Document
            // 
            this.Document.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.ShowPrint);
            // 
            // Print
            // 
            this.Print.UseEXDialog = true;
            // 
            // Open
            // 
            this.Open.FileName = "Open";
            // 
            // itemInformacoes
            // 
            this.itemInformacoes.Name = "itemInformacoes";
            this.itemInformacoes.Size = new System.Drawing.Size(163, 24);
            this.itemInformacoes.Text = "Informações";
            this.itemInformacoes.Click += new System.EventHandler(this.itemInformacoes_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.Transparent;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.pTop);
            this.DarkStyle = true;
            this.GradientColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(65)))), ((int)(((byte)(73)))));
            this.GradientColorTop = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Principal";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "HospitalApp";
            this.TitleBar = false;
            this.TitleBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.WindowBarColor = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.Controls.SetChildIndex(this.pTop, 0);
            this.Controls.SetChildIndex(this.pMain, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            this.pContainer.Panel1.ResumeLayout(false);
            this.pContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pContainer)).EndInit();
            this.pContainer.ResumeLayout(false);
            this.pLeft.ResumeLayout(false);
            this.pCard.ResumeLayout(false);
            this.wCard1.ResumeLayout(false);
            this.wCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pEditar.ResumeLayout(false);
            this.pEditar.PerformLayout();
            this.lpExibição.ResumeLayout(false);
            this.lpExibição.PerformLayout();
            this.pTop.ResumeLayout(false);
            this.pTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webView;
        private System.Windows.Forms.DataGridView gridView;

        private UI.wButton wButton2;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.Panel pLeft;
        private UI.wCard wCard1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialRaisedButton btnMapaView;
        private MaterialSkin.Controls.MaterialRaisedButton btnListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem itemBD;
        private System.Windows.Forms.ToolStripMenuItem itemExibir;
        private System.Windows.Forms.ToolStripMenuItem itemMapaView;
        private System.Windows.Forms.ToolStripMenuItem itemGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem itemAdmin;
        private System.Windows.Forms.ToolStripMenuItem itemAbrir;
        private System.Windows.Forms.ToolStripMenuItem itemSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem itemImprimir;
        private System.Windows.Forms.ToolStripMenuItem itemLogin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem itemCadastrar;
        private System.Windows.Forms.Panel lpExibição;
        private System.Windows.Forms.Panel pCard;
        private System.Windows.Forms.Panel pEditar;
        private System.Windows.Forms.Label label9;
        private MaterialSkin.Controls.MaterialRaisedButton btnCadastrar;
        private MaterialSkin.Controls.MaterialRaisedButton btnRemover;
        private System.Windows.Forms.ToolStripMenuItem itemSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.SplitContainer pContainer;
        private MaterialSkin.Controls.MaterialRaisedButton btbSplit;
        private System.Windows.Forms.ToolStripMenuItem janelaDivididaToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument Document;
        private System.Windows.Forms.PrintDialog Print;
        private System.Windows.Forms.ToolStripMenuItem itemRemover;
        private System.Windows.Forms.SaveFileDialog Save;
        private System.Windows.Forms.OpenFileDialog Open;
        private System.Windows.Forms.ToolStripMenuItem itemInformacoes;
    }
}

