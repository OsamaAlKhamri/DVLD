namespace PresentationLayer
{
    partial class frmAddEditUser
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
            this.tabCtrlAddUser = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPagePerson = new System.Windows.Forms.TabPage();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlPersonCardWithFilterInstance = new PresentationLayer.ctrlPersonCardWithFilter();
            this.tabPageUser = new System.Windows.Forms.TabPage();
            this.chkActive = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.txtBoxConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtBoxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtBoxUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblUserID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.tabCtrlAddUser.SuspendLayout();
            this.tabPagePerson.SuspendLayout();
            this.tabPageUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrlAddUser
            // 
            this.tabCtrlAddUser.Controls.Add(this.tabPagePerson);
            this.tabCtrlAddUser.Controls.Add(this.tabPageUser);
            this.tabCtrlAddUser.ItemSize = new System.Drawing.Size(200, 40);
            this.tabCtrlAddUser.Location = new System.Drawing.Point(0, 46);
            this.tabCtrlAddUser.Name = "tabCtrlAddUser";
            this.tabCtrlAddUser.SelectedIndex = 0;
            this.tabCtrlAddUser.Size = new System.Drawing.Size(819, 513);
            this.tabCtrlAddUser.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabCtrlAddUser.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(242)))), ((int)(((byte)(117)))));
            this.tabCtrlAddUser.TabButtonHoverState.Font = new System.Drawing.Font("SF Compact Display", 13.8F, System.Drawing.FontStyle.Bold);
            this.tabCtrlAddUser.TabButtonHoverState.ForeColor = System.Drawing.Color.Black;
            this.tabCtrlAddUser.TabButtonHoverState.InnerColor = System.Drawing.Color.Empty;
            this.tabCtrlAddUser.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabCtrlAddUser.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(242)))), ((int)(((byte)(117)))));
            this.tabCtrlAddUser.TabButtonIdleState.Font = new System.Drawing.Font("SF Pro Rounded", 12.9F, System.Drawing.FontStyle.Bold);
            this.tabCtrlAddUser.TabButtonIdleState.ForeColor = System.Drawing.Color.Black;
            this.tabCtrlAddUser.TabButtonIdleState.InnerColor = System.Drawing.Color.Empty;
            this.tabCtrlAddUser.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabCtrlAddUser.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(242)))), ((int)(((byte)(117)))));
            this.tabCtrlAddUser.TabButtonSelectedState.Font = new System.Drawing.Font("SF Pro Rounded", 12.9F, System.Drawing.FontStyle.Bold);
            this.tabCtrlAddUser.TabButtonSelectedState.ForeColor = System.Drawing.Color.Black;
            this.tabCtrlAddUser.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabCtrlAddUser.TabButtonSize = new System.Drawing.Size(200, 40);
            this.tabCtrlAddUser.TabIndex = 17;
            this.tabCtrlAddUser.TabMenuBackColor = System.Drawing.Color.WhiteSmoke;
            this.tabCtrlAddUser.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabPagePerson
            // 
            this.tabPagePerson.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPagePerson.Controls.Add(this.btnNext);
            this.tabPagePerson.Controls.Add(this.ctrlPersonCardWithFilterInstance);
            this.tabPagePerson.Location = new System.Drawing.Point(4, 44);
            this.tabPagePerson.Name = "tabPagePerson";
            this.tabPagePerson.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePerson.Size = new System.Drawing.Size(811, 465);
            this.tabPagePerson.TabIndex = 0;
            this.tabPagePerson.Text = "Find Person";
            // 
            // btnNext
            // 
            this.btnNext.AutoRoundedCorners = true;
            this.btnNext.BorderRadius = 14;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.Silver;
            this.btnNext.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(679, 408);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 31);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlPersonCardWithFilterInstance
            // 
            this.ctrlPersonCardWithFilterInstance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ctrlPersonCardWithFilterInstance.FilterEnabled = true;
            this.ctrlPersonCardWithFilterInstance.Location = new System.Drawing.Point(13, 12);
            this.ctrlPersonCardWithFilterInstance.Name = "ctrlPersonCardWithFilterInstance";
            this.ctrlPersonCardWithFilterInstance.ShowAddPerson = true;
            this.ctrlPersonCardWithFilterInstance.Size = new System.Drawing.Size(785, 441);
            this.ctrlPersonCardWithFilterInstance.TabIndex = 15;
            // 
            // tabPageUser
            // 
            this.tabPageUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageUser.Controls.Add(this.chkActive);
            this.tabPageUser.Controls.Add(this.txtBoxConfirmPassword);
            this.tabPageUser.Controls.Add(this.guna2HtmlLabel4);
            this.tabPageUser.Controls.Add(this.txtBoxPassword);
            this.tabPageUser.Controls.Add(this.guna2HtmlLabel5);
            this.tabPageUser.Controls.Add(this.guna2HtmlLabel3);
            this.tabPageUser.Controls.Add(this.txtBoxUserName);
            this.tabPageUser.Controls.Add(this.lblUserID);
            this.tabPageUser.Controls.Add(this.guna2HtmlLabel2);
            this.tabPageUser.Controls.Add(this.guna2HtmlLabel1);
            this.tabPageUser.Location = new System.Drawing.Point(4, 44);
            this.tabPageUser.Name = "tabPageUser";
            this.tabPageUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUser.Size = new System.Drawing.Size(811, 465);
            this.tabPageUser.TabIndex = 1;
            this.tabPageUser.Text = "User Info";
            // 
            // chkActive
            // 
            this.chkActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkActive.CheckedState.BorderRadius = 2;
            this.chkActive.CheckedState.BorderThickness = 0;
            this.chkActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkActive.Location = new System.Drawing.Point(262, 275);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(20, 20);
            this.chkActive.TabIndex = 34;
            this.chkActive.Text = "guna2CustomCheckBox1";
            this.chkActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkActive.UncheckedState.BorderRadius = 2;
            this.chkActive.UncheckedState.BorderThickness = 0;
            this.chkActive.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // txtBoxConfirmPassword
            // 
            this.txtBoxConfirmPassword.AutoRoundedCorners = true;
            this.txtBoxConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxConfirmPassword.BorderRadius = 17;
            this.txtBoxConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxConfirmPassword.DefaultText = "";
            this.txtBoxConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxConfirmPassword.Font = new System.Drawing.Font("SF Pro Rounded", 9.5F, System.Drawing.FontStyle.Bold);
            this.txtBoxConfirmPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxConfirmPassword.Location = new System.Drawing.Point(262, 205);
            this.txtBoxConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxConfirmPassword.Name = "txtBoxConfirmPassword";
            this.txtBoxConfirmPassword.PlaceholderText = "";
            this.txtBoxConfirmPassword.SelectedText = "";
            this.txtBoxConfirmPassword.Size = new System.Drawing.Size(229, 36);
            this.txtBoxConfirmPassword.TabIndex = 29;
            this.txtBoxConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.NullableOrEmpty_Validating);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(24, 209);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(218, 28);
            this.guna2HtmlLabel4.TabIndex = 28;
            this.guna2HtmlLabel4.Text = "Confirm Password";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.AutoRoundedCorners = true;
            this.txtBoxPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxPassword.BorderRadius = 17;
            this.txtBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxPassword.DefaultText = "";
            this.txtBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxPassword.Font = new System.Drawing.Font("SF Pro Rounded", 9.5F, System.Drawing.FontStyle.Bold);
            this.txtBoxPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxPassword.Location = new System.Drawing.Point(262, 143);
            this.txtBoxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PlaceholderText = "";
            this.txtBoxPassword.SelectedText = "";
            this.txtBoxPassword.Size = new System.Drawing.Size(229, 36);
            this.txtBoxPassword.TabIndex = 29;
            this.txtBoxPassword.Validating += new System.ComponentModel.CancelEventHandler(this.NullableOrEmpty_Validating);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(24, 271);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(108, 28);
            this.guna2HtmlLabel5.TabIndex = 28;
            this.guna2HtmlLabel5.Text = "Is Active";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(24, 147);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(122, 28);
            this.guna2HtmlLabel3.TabIndex = 28;
            this.guna2HtmlLabel3.Text = "Password";
            // 
            // txtBoxUserName
            // 
            this.txtBoxUserName.AutoRoundedCorners = true;
            this.txtBoxUserName.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxUserName.BorderColor = System.Drawing.Color.LightGray;
            this.txtBoxUserName.BorderRadius = 17;
            this.txtBoxUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxUserName.DefaultText = "";
            this.txtBoxUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxUserName.Font = new System.Drawing.Font("SF Pro Rounded", 9.5F, System.Drawing.FontStyle.Bold);
            this.txtBoxUserName.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxUserName.Location = new System.Drawing.Point(262, 81);
            this.txtBoxUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxUserName.Name = "txtBoxUserName";
            this.txtBoxUserName.PlaceholderText = "";
            this.txtBoxUserName.SelectedText = "";
            this.txtBoxUserName.Size = new System.Drawing.Size(229, 36);
            this.txtBoxUserName.TabIndex = 27;
            this.txtBoxUserName.Validating += new System.ComponentModel.CancelEventHandler(this.NullableOrEmpty_Validating);
            // 
            // lblUserID
            // 
            this.lblUserID.BackColor = System.Drawing.Color.Transparent;
            this.lblUserID.Font = new System.Drawing.Font("SF Pro Rounded", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblUserID.ForeColor = System.Drawing.Color.DimGray;
            this.lblUserID.Location = new System.Drawing.Point(262, 27);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblUserID.Size = new System.Drawing.Size(32, 21);
            this.lblUserID.TabIndex = 13;
            this.lblUserID.Text = "?";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(24, 85);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(133, 28);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = "User Name";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(24, 23);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(95, 28);
            this.guna2HtmlLabel1.TabIndex = 4;
            this.guna2HtmlLabel1.Text = "User ID";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderRadius = 16;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Brown;
            this.btnClose.Font = new System.Drawing.Font("SF Pro Rounded", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Image = global::PresentationLayer.Properties.Resources.CloseBlack;
            this.btnClose.Location = new System.Drawing.Point(476, 572);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(158, 41);
            this.btnClose.TabIndex = 73;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderRadius = 16;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(242)))), ((int)(((byte)(117)))));
            this.btnSave.Font = new System.Drawing.Font("SF Pro Rounded", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = global::PresentationLayer.Properties.Resources.save_filled;
            this.btnSave.Location = new System.Drawing.Point(642, 572);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(158, 41);
            this.btnSave.TabIndex = 74;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(816, 626);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabCtrlAddUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.frmAddEditUser_Activated);
            this.Load += new System.EventHandler(this.frmAddEditUser_Load);
            this.tabCtrlAddUser.ResumeLayout(false);
            this.tabPagePerson.ResumeLayout(false);
            this.tabPageUser.ResumeLayout(false);
            this.tabPageUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TabControl tabCtrlAddUser;
        private System.Windows.Forms.TabPage tabPagePerson;
        private System.Windows.Forms.TabPage tabPageUser;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUserID;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxConfirmPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxUserName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private ctrlPersonCardWithFilter ctrlPersonCardWithFilterInstance;
        private Guna.UI2.WinForms.Guna2CustomCheckBox chkActive;
    }
}