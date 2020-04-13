namespace QuanLyKhoHang
{
    partial class flogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbUserNamee = new System.Windows.Forms.TextBox();
            this.txbPassWord = new System.Windows.Forms.TextBox();
            this.btnLogin = new JThinButton.JThinButton();
            this.btnExit = new FlatButton.JFlatButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.txbUserNamee);
            this.panel1.Controls.Add(this.txbPassWord);
            this.panel1.Location = new System.Drawing.Point(270, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 436);
            this.panel1.TabIndex = 0;
            // 
            // txbUserNamee
            // 
            this.txbUserNamee.Font = new System.Drawing.Font("Operator Mono Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUserNamee.Location = new System.Drawing.Point(73, 114);
            this.txbUserNamee.Name = "txbUserNamee";
            this.txbUserNamee.Size = new System.Drawing.Size(170, 31);
            this.txbUserNamee.TabIndex = 1;
            this.txbUserNamee.Text = "Username";
            this.txbUserNamee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbPassWord
            // 
            this.txbPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassWord.Location = new System.Drawing.Point(73, 154);
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.Size = new System.Drawing.Size(170, 21);
            this.txbPassWord.TabIndex = 1;
            this.txbPassWord.Text = "password";
            this.txbPassWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbPassWord.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundColor = System.Drawing.Color.White;
            this.btnLogin.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.ButtonText = "LOGIN";
            this.btnLogin.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColors = System.Drawing.SystemColors.Highlight;
            this.btnLogin.HoverBackground = System.Drawing.Color.White;
            this.btnLogin.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLogin.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.btnLogin.LineThickness = 2;
            this.btnLogin.Location = new System.Drawing.Point(78, 181);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(162, 61);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.btnExit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.btnExit.ButtonText = "Thoát";
            this.btnExit.CausesValidation = false;
            this.btnExit.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnExit.ErrorImageLeft")));
            this.btnExit.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnExit.ErrorImageRight")));
            this.btnExit.FocusBackground = System.Drawing.Color.Empty;
            this.btnExit.FocusFontColor = System.Drawing.Color.Empty;
            this.btnExit.ForeColors = System.Drawing.Color.White;
            this.btnExit.HoverBackground = System.Drawing.Color.Empty;
            this.btnExit.HoverFontColor = System.Drawing.Color.Empty;
            this.btnExit.ImageLeft = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageLeft")));
            this.btnExit.ImageRight = null;
            this.btnExit.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(73, 291);
            this.btnExit.Name = "btnExit";
            this.btnExit.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnExit.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnExit.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnExit.Size = new System.Drawing.Size(170, 43);
            this.btnExit.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnExit.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnExit.TabIndex = 6;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // flogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(842, 506);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "flogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.flogin_FormClosing);
            this.Load += new System.EventHandler(this.flogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbUserNamee;
        private System.Windows.Forms.TextBox txbPassWord;
        private JThinButton.JThinButton btnLogin;
        private FlatButton.JFlatButton btnExit;
    }
}

