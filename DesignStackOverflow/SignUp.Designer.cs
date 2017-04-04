namespace DesignStackOverflow
{
    partial class fmSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmSignUp));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtConfirmPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtUsername = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtBirthday = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel1.Controls.Add(this.btnClose);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-1, -1);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(755, 35);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(81, 5);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(144, 25);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Tôi đi Code dạo";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::DesignStackOverflow.Properties.Resources.Capture1;
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(710, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuGradientPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackColor = System.Drawing.Color.White;
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.bunifuThinButton21);
            this.bunifuGradientPanel2.Controls.Add(this.panel1);
            this.bunifuGradientPanel2.Controls.Add(this.txtConfirmPassword);
            this.bunifuGradientPanel2.Controls.Add(this.txtPassword);
            this.bunifuGradientPanel2.Controls.Add(this.txtEmail);
            this.bunifuGradientPanel2.Controls.Add(this.txtUsername);
            this.bunifuGradientPanel2.Controls.Add(this.txtBirthday);
            this.bunifuGradientPanel2.Controls.Add(this.label1);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(165, 61);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(425, 517);
            this.bunifuGradientPanel2.TabIndex = 1;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 10;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SpringGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SpringGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Sign me Up!";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 1;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Gainsboro;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SpringGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.DimGray;
            this.bunifuThinButton21.Location = new System.Drawing.Point(16, 455);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(385, 53);
            this.bunifuThinButton21.TabIndex = 7;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(20, 382);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 40);
            this.panel1.TabIndex = 12;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.DimGray;
            this.radioButton2.Location = new System.Drawing.Point(231, 8);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 24);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.DimGray;
            this.radioButton1.Location = new System.Drawing.Point(82, 8);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 24);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderColorFocused = System.Drawing.Color.SpringGreen;
            this.txtConfirmPassword.BorderColorIdle = System.Drawing.Color.DimGray;
            this.txtConfirmPassword.BorderColorMouseHover = System.Drawing.Color.SpringGreen;
            this.txtConfirmPassword.BorderThickness = 1;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtConfirmPassword.isPassword = false;
            this.txtConfirmPassword.Location = new System.Drawing.Point(20, 268);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(385, 40);
            this.txtConfirmPassword.TabIndex = 3;
            this.txtConfirmPassword.Text = "  Confirm Password";
            this.txtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColorFocused = System.Drawing.Color.SpringGreen;
            this.txtPassword.BorderColorIdle = System.Drawing.Color.DimGray;
            this.txtPassword.BorderColorMouseHover = System.Drawing.Color.SpringGreen;
            this.txtPassword.BorderThickness = 1;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.isPassword = false;
            this.txtPassword.Location = new System.Drawing.Point(20, 211);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(385, 40);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "  Password";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColorFocused = System.Drawing.Color.SpringGreen;
            this.txtEmail.BorderColorIdle = System.Drawing.Color.DimGray;
            this.txtEmail.BorderColorMouseHover = System.Drawing.Color.SpringGreen;
            this.txtEmail.BorderThickness = 1;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.isPassword = false;
            this.txtEmail.Location = new System.Drawing.Point(20, 154);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(385, 40);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Text = "  Email";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderColorFocused = System.Drawing.Color.SpringGreen;
            this.txtUsername.BorderColorIdle = System.Drawing.Color.DimGray;
            this.txtUsername.BorderColorMouseHover = System.Drawing.Color.SpringGreen;
            this.txtUsername.BorderThickness = 1;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsername.isPassword = false;
            this.txtUsername.Location = new System.Drawing.Point(20, 97);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(385, 40);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "  Username";
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtBirthday
            // 
            this.txtBirthday.BackColor = System.Drawing.Color.White;
            this.txtBirthday.BorderRadius = 0;
            this.txtBirthday.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirthday.ForeColor = System.Drawing.Color.DimGray;
            this.txtBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtBirthday.FormatCustom = null;
            this.txtBirthday.Location = new System.Drawing.Point(20, 325);
            this.txtBirthday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(385, 40);
            this.txtBirthday.TabIndex = 4;
            this.txtBirthday.Value = new System.DateTime(2017, 3, 30, 23, 54, 11, 199);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(115, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign up to Code dạo";
            // 
            // fmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DesignStackOverflow.Properties.Resources.Shape_14;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 608);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDatepicker txtBirthday;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtConfirmPassword;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}