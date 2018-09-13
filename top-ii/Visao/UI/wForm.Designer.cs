namespace Visao.UI
{
    partial class wForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._windowbar = new System.Windows.Forms.Panel();
            this._titlebar = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this._windowbar.SuspendLayout();
            this._titlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // _windowbar
            // 
            this._windowbar.BackColor = System.Drawing.Color.DimGray;
            this._windowbar.Controls.Add(this.btnMax);
            this._windowbar.Controls.Add(this.btnMin);
            this._windowbar.Controls.Add(this.btnClose);
            this._windowbar.Dock = System.Windows.Forms.DockStyle.Top;
            this._windowbar.Location = new System.Drawing.Point(0, 0);
            this._windowbar.Margin = new System.Windows.Forms.Padding(0);
            this._windowbar.Name = "_windowbar";
            this._windowbar.Size = new System.Drawing.Size(496, 24);
            this._windowbar.TabIndex = 0;
            this._windowbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this._windowbar_MouseDown);
            this._windowbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this._windowbar_MouseMove);
            // 
            // _titlebar
            // 
            this._titlebar.BackColor = System.Drawing.Color.Gray;
            this._titlebar.Controls.Add(this.title);
            this._titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this._titlebar.Location = new System.Drawing.Point(0, 24);
            this._titlebar.Name = "_titlebar";
            this._titlebar.Size = new System.Drawing.Size(496, 40);
            this._titlebar.TabIndex = 1;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(12, 7);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(97, 23);
            this.title.TabIndex = 0;
            this.title.Text = "Form Title";
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackgroundImage = global::Visao.Properties.Resources.maximizar;
            this.btnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.ForeColor = System.Drawing.Color.White;
            this.btnMax.Location = new System.Drawing.Point(448, 0);
            this.btnMax.Margin = new System.Windows.Forms.Padding(0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(24, 24);
            this.btnMax.TabIndex = 2;
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackgroundImage = global::Visao.Properties.Resources.min;
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(424, 0);
            this.btnMin.Margin = new System.Windows.Forms.Padding(0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(24, 24);
            this.btnMin.TabIndex = 1;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = global::Visao.Properties.Resources.fechar;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(472, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 24);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 300);
            this.Controls.Add(this._titlebar);
            this.Controls.Add(this._windowbar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Window1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Window_Load);
            this._windowbar.ResumeLayout(false);
            this._titlebar.ResumeLayout(false);
            this._titlebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _windowbar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Panel _titlebar;
        private System.Windows.Forms.Label title;

    }
}
