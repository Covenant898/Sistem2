namespace Sistema2_0
{
    partial class Admin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BtnCerrar = new Bunifu.UI.WinForms.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new Bunifu.UI.WinForms.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.ActiveImage = null;
            this.BtnCerrar.AllowAnimations = true;
            this.BtnCerrar.AllowBuffering = false;
            this.BtnCerrar.AllowToggling = false;
            this.BtnCerrar.AllowZooming = true;
            this.BtnCerrar.AllowZoomingOnFocus = false;
            this.BtnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCerrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnCerrar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.ErrorImage")));
            this.BtnCerrar.FadeWhenInactive = false;
            this.BtnCerrar.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.ImageActive = null;
            this.BtnCerrar.ImageLocation = null;
            this.BtnCerrar.ImageMargin = 20;
            this.BtnCerrar.ImageSize = new System.Drawing.Size(26, 26);
            this.BtnCerrar.ImageZoomSize = new System.Drawing.Size(46, 46);
            this.BtnCerrar.InitialImage = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.InitialImage")));
            this.BtnCerrar.Location = new System.Drawing.Point(641, -5);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Rotation = 0;
            this.BtnCerrar.ShowActiveImage = true;
            this.BtnCerrar.ShowCursorChanges = true;
            this.BtnCerrar.ShowImageBorders = true;
            this.BtnCerrar.ShowSizeMarkers = false;
            this.BtnCerrar.Size = new System.Drawing.Size(46, 46);
            this.BtnCerrar.TabIndex = 1;
            this.BtnCerrar.ToolTipText = "";
            this.BtnCerrar.WaitOnLoad = false;
            this.BtnCerrar.Zoom = 20;
            this.BtnCerrar.ZoomSpeed = 10;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(699, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.ActiveImage = null;
            this.btnLogOut.AllowAnimations = true;
            this.btnLogOut.AllowBuffering = false;
            this.btnLogOut.AllowToggling = false;
            this.btnLogOut.AllowZooming = true;
            this.btnLogOut.AllowZoomingOnFocus = false;
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogOut.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.ErrorImage")));
            this.btnLogOut.FadeWhenInactive = false;
            this.btnLogOut.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageActive = null;
            this.btnLogOut.ImageLocation = null;
            this.btnLogOut.ImageMargin = 20;
            this.btnLogOut.ImageSize = new System.Drawing.Size(29, 26);
            this.btnLogOut.ImageZoomSize = new System.Drawing.Size(49, 46);
            this.btnLogOut.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.InitialImage")));
            this.btnLogOut.Location = new System.Drawing.Point(598, -5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Rotation = 0;
            this.btnLogOut.ShowActiveImage = true;
            this.btnLogOut.ShowCursorChanges = true;
            this.btnLogOut.ShowImageBorders = true;
            this.btnLogOut.ShowSizeMarkers = false;
            this.btnLogOut.Size = new System.Drawing.Size(49, 46);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.ToolTipText = "";
            this.btnLogOut.WaitOnLoad = false;
            this.btnLogOut.Zoom = 20;
            this.btnLogOut.ZoomSpeed = 10;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 326);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuImageButton BtnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuImageButton btnLogOut;
    }
}