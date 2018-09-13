namespace Visao
{
    partial class Login
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
            this.txtbUser = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtbPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // txtbUser
            // 
            this.txtbUser.BackColor = System.Drawing.Color.White;
            this.txtbUser.Depth = 0;
            this.txtbUser.Hint = "Usuário";
            this.txtbUser.Location = new System.Drawing.Point(98, 112);
            this.txtbUser.MaxLength = 32767;
            this.txtbUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtbUser.Name = "txtbUser";
            this.txtbUser.PasswordChar = '\0';
            this.txtbUser.SelectedText = "";
            this.txtbUser.SelectionLength = 0;
            this.txtbUser.SelectionStart = 0;
            this.txtbUser.Size = new System.Drawing.Size(269, 23);
            this.txtbUser.TabIndex = 1;
            this.txtbUser.TabStop = false;
            this.txtbUser.UseSystemPasswordChar = false;
            // 
            // txtbPass
            // 
            this.txtbPass.BackColor = System.Drawing.Color.White;
            this.txtbPass.Depth = 0;
            this.txtbPass.Hint = "Senha";
            this.txtbPass.Location = new System.Drawing.Point(98, 168);
            this.txtbPass.MaxLength = 32767;
            this.txtbPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtbPass.Name = "txtbPass";
            this.txtbPass.PasswordChar = '\0';
            this.txtbPass.SelectedText = "";
            this.txtbPass.SelectionLength = 0;
            this.txtbPass.SelectionStart = 0;
            this.txtbPass.Size = new System.Drawing.Size(269, 23);
            this.txtbPass.TabIndex = 2;
            this.txtbPass.TabStop = false;
            this.txtbPass.UseSystemPasswordChar = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(260, 261);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = false;
            this.btnCancelar.Size = new System.Drawing.Size(91, 36);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.AutoSize = true;
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Depth = 0;
            this.btnLogin.Icon = null;
            this.btnLogin.Location = new System.Drawing.Point(366, 261);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Primary = true;
            this.btnLogin.Size = new System.Drawing.Size(61, 36);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(440, 309);
            this.ControlBox = false;
            this.Controls.Add(this.txtbUser);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtbPass);
            this.Controls.Add(this.btnCancelar);
            this.DarkStyle = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.TitleBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(65)))), ((int)(((byte)(73)))));
            this.WindowBar = false;
            this.WindowResize = false;
            this.Load += new System.EventHandler(this.Login_Load);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.txtbPass, 0);
            this.Controls.SetChildIndex(this.btnLogin, 0);
            this.Controls.SetChildIndex(this.txtbUser, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtbUser;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtbPass;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelar;
        private MaterialSkin.Controls.MaterialRaisedButton btnLogin;
    }
}