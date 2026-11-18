namespace PresentationLayer
{
    partial class frmAddEditLocalDrivingLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditLocalDrivingLicense));
            this.lblFormTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tabCtrlAddLocalLicense = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPagePerson = new System.Windows.Forms.TabPage();
            this.btnNextTab = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlPersonCardWithFilterInstance = new PresentationLayer.ctrlPersonCardWithFilter();
            this.tabPageApplication = new System.Windows.Forms.TabPage();
            this.comBoxLicenseClass = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.sdds = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAppFees = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCreatedBy = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAppDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAppID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.tabCtrlAddLocalLicense.SuspendLayout();
            this.tabPagePerson.SuspendLayout();
            this.tabPageApplication.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = false;
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFormTitle.Font = new System.Drawing.Font("SF Pro Rounded", 18F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.Red;
            this.lblFormTitle.Location = new System.Drawing.Point(0, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Padding = new System.Windows.Forms.Padding(20, 20, 30, 20);
            this.lblFormTitle.Size = new System.Drawing.Size(922, 81);
            this.lblFormTitle.TabIndex = 16;
            this.lblFormTitle.Text = "New Local Driving License Application";
            this.lblFormTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabCtrlAddLocalLicense
            // 
            this.tabCtrlAddLocalLicense.Controls.Add(this.tabPagePerson);
            this.tabCtrlAddLocalLicense.Controls.Add(this.tabPageApplication);
            this.tabCtrlAddLocalLicense.ItemSize = new System.Drawing.Size(160, 40);
            this.tabCtrlAddLocalLicense.Location = new System.Drawing.Point(0, 76);
            this.tabCtrlAddLocalLicense.Name = "tabCtrlAddLocalLicense";
            this.tabCtrlAddLocalLicense.SelectedIndex = 0;
            this.tabCtrlAddLocalLicense.Size = new System.Drawing.Size(923, 492);
            this.tabCtrlAddLocalLicense.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabCtrlAddLocalLicense.TabButtonHoverState.FillColor = System.Drawing.Color.LightGray;
            this.tabCtrlAddLocalLicense.TabButtonHoverState.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold);
            this.tabCtrlAddLocalLicense.TabButtonHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.tabCtrlAddLocalLicense.TabButtonHoverState.InnerColor = System.Drawing.Color.LightGray;
            this.tabCtrlAddLocalLicense.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabCtrlAddLocalLicense.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(242)))), ((int)(((byte)(117)))));
            this.tabCtrlAddLocalLicense.TabButtonIdleState.Font = new System.Drawing.Font("SF Pro Rounded", 12.9F, System.Drawing.FontStyle.Bold);
            this.tabCtrlAddLocalLicense.TabButtonIdleState.ForeColor = System.Drawing.Color.Black;
            this.tabCtrlAddLocalLicense.TabButtonIdleState.InnerColor = System.Drawing.Color.Empty;
            this.tabCtrlAddLocalLicense.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabCtrlAddLocalLicense.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(242)))), ((int)(((byte)(117)))));
            this.tabCtrlAddLocalLicense.TabButtonSelectedState.Font = new System.Drawing.Font("SF Pro Rounded", 12.9F, System.Drawing.FontStyle.Bold);
            this.tabCtrlAddLocalLicense.TabButtonSelectedState.ForeColor = System.Drawing.Color.Black;
            this.tabCtrlAddLocalLicense.TabButtonSelectedState.InnerColor = System.Drawing.Color.Black;
            this.tabCtrlAddLocalLicense.TabButtonSize = new System.Drawing.Size(160, 40);
            this.tabCtrlAddLocalLicense.TabIndex = 17;
            this.tabCtrlAddLocalLicense.TabMenuBackColor = System.Drawing.Color.WhiteSmoke;
            this.tabCtrlAddLocalLicense.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            this.tabCtrlAddLocalLicense.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabCtrlAddLocalLicense_Selecting);
            // 
            // tabPagePerson
            // 
            this.tabPagePerson.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPagePerson.Controls.Add(this.btnNextTab);
            this.tabPagePerson.Controls.Add(this.ctrlPersonCardWithFilterInstance);
            this.tabPagePerson.Location = new System.Drawing.Point(4, 44);
            this.tabPagePerson.Name = "tabPagePerson";
            this.tabPagePerson.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePerson.Size = new System.Drawing.Size(915, 444);
            this.tabPagePerson.TabIndex = 0;
            this.tabPagePerson.Text = "Person Info";
            // 
            // btnNextTab
            // 
            this.btnNextTab.AutoRoundedCorners = true;
            this.btnNextTab.BorderRadius = 14;
            this.btnNextTab.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNextTab.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNextTab.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNextTab.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNextTab.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNextTab.FillColor = System.Drawing.Color.Silver;
            this.btnNextTab.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold);
            this.btnNextTab.ForeColor = System.Drawing.Color.Black;
            this.btnNextTab.Location = new System.Drawing.Point(790, 393);
            this.btnNextTab.Name = "btnNextTab";
            this.btnNextTab.Size = new System.Drawing.Size(100, 31);
            this.btnNextTab.TabIndex = 317;
            this.btnNextTab.Text = "Next";
            this.btnNextTab.Click += new System.EventHandler(this.btnNextTab_Click);
            // 
            // ctrlPersonCardWithFilterInstance
            // 
            this.ctrlPersonCardWithFilterInstance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ctrlPersonCardWithFilterInstance.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctrlPersonCardWithFilterInstance.FilterEnabled = true;
            this.ctrlPersonCardWithFilterInstance.Location = new System.Drawing.Point(3, 5);
            this.ctrlPersonCardWithFilterInstance.Name = "ctrlPersonCardWithFilterInstance";
            this.ctrlPersonCardWithFilterInstance.ShowAddPerson = true;
            this.ctrlPersonCardWithFilterInstance.Size = new System.Drawing.Size(909, 436);
            this.ctrlPersonCardWithFilterInstance.TabIndex = 316;
            this.ctrlPersonCardWithFilterInstance.OnPersonSelected += new System.Action<int>(this.ctrlPersonCardWithFilterInstance_OnPersonSelected);
            // 
            // tabPageApplication
            // 
            this.tabPageApplication.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageApplication.Controls.Add(this.comBoxLicenseClass);
            this.tabPageApplication.Controls.Add(this.guna2HtmlLabel5);
            this.tabPageApplication.Controls.Add(this.guna2HtmlLabel4);
            this.tabPageApplication.Controls.Add(this.sdds);
            this.tabPageApplication.Controls.Add(this.lblAppFees);
            this.tabPageApplication.Controls.Add(this.lblCreatedBy);
            this.tabPageApplication.Controls.Add(this.lblAppDate);
            this.tabPageApplication.Controls.Add(this.lblAppID);
            this.tabPageApplication.Controls.Add(this.guna2HtmlLabel2);
            this.tabPageApplication.Controls.Add(this.guna2HtmlLabel1);
            this.tabPageApplication.Location = new System.Drawing.Point(4, 44);
            this.tabPageApplication.Name = "tabPageApplication";
            this.tabPageApplication.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageApplication.Size = new System.Drawing.Size(915, 444);
            this.tabPageApplication.TabIndex = 1;
            this.tabPageApplication.Text = "App Info";
            // 
            // comBoxLicenseClass
            // 
            this.comBoxLicenseClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comBoxLicenseClass.BackColor = System.Drawing.Color.Transparent;
            this.comBoxLicenseClass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.comBoxLicenseClass.BorderRadius = 12;
            this.comBoxLicenseClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comBoxLicenseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxLicenseClass.FocusedColor = System.Drawing.Color.DarkSlateGray;
            this.comBoxLicenseClass.FocusedState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.comBoxLicenseClass.Font = new System.Drawing.Font("SF Compact Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxLicenseClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.comBoxLicenseClass.HoverState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.comBoxLicenseClass.ItemHeight = 30;
            this.comBoxLicenseClass.Location = new System.Drawing.Point(254, 135);
            this.comBoxLicenseClass.Margin = new System.Windows.Forms.Padding(8);
            this.comBoxLicenseClass.Name = "comBoxLicenseClass";
            this.comBoxLicenseClass.Size = new System.Drawing.Size(430, 36);
            this.comBoxLicenseClass.TabIndex = 314;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(24, 255);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(144, 28);
            this.guna2HtmlLabel5.TabIndex = 28;
            this.guna2HtmlLabel5.Text = "Created By";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(24, 197);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(198, 28);
            this.guna2HtmlLabel4.TabIndex = 28;
            this.guna2HtmlLabel4.Text = "Application Fees";
            // 
            // sdds
            // 
            this.sdds.BackColor = System.Drawing.Color.Transparent;
            this.sdds.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold);
            this.sdds.ForeColor = System.Drawing.Color.Black;
            this.sdds.Location = new System.Drawing.Point(24, 139);
            this.sdds.Name = "sdds";
            this.sdds.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.sdds.Size = new System.Drawing.Size(169, 28);
            this.sdds.TabIndex = 28;
            this.sdds.Text = "License Class";
            // 
            // lblAppFees
            // 
            this.lblAppFees.BackColor = System.Drawing.Color.Transparent;
            this.lblAppFees.Font = new System.Drawing.Font("SF Pro Rounded", 10F, System.Drawing.FontStyle.Bold);
            this.lblAppFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lblAppFees.Location = new System.Drawing.Point(254, 200);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblAppFees.Size = new System.Drawing.Size(32, 22);
            this.lblAppFees.TabIndex = 13;
            this.lblAppFees.Text = "?";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatedBy.Font = new System.Drawing.Font("SF Pro Rounded", 10F, System.Drawing.FontStyle.Bold);
            this.lblCreatedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lblCreatedBy.Location = new System.Drawing.Point(254, 258);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblCreatedBy.Size = new System.Drawing.Size(32, 22);
            this.lblCreatedBy.TabIndex = 13;
            this.lblCreatedBy.Text = "?";
            // 
            // lblAppDate
            // 
            this.lblAppDate.BackColor = System.Drawing.Color.Transparent;
            this.lblAppDate.Font = new System.Drawing.Font("SF Pro Rounded", 10F, System.Drawing.FontStyle.Bold);
            this.lblAppDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lblAppDate.Location = new System.Drawing.Point(254, 84);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblAppDate.Size = new System.Drawing.Size(32, 22);
            this.lblAppDate.TabIndex = 13;
            this.lblAppDate.Text = "?";
            // 
            // lblAppID
            // 
            this.lblAppID.BackColor = System.Drawing.Color.Transparent;
            this.lblAppID.Font = new System.Drawing.Font("SF Pro Rounded", 10F, System.Drawing.FontStyle.Bold);
            this.lblAppID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lblAppID.Location = new System.Drawing.Point(254, 26);
            this.lblAppID.Name = "lblAppID";
            this.lblAppID.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblAppID.Size = new System.Drawing.Size(32, 22);
            this.lblAppID.TabIndex = 13;
            this.lblAppID.Text = "?";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(24, 81);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(198, 28);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = "Application Date";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(24, 23);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(219, 28);
            this.guna2HtmlLabel1.TabIndex = 4;
            this.guna2HtmlLabel1.Text = "D. L. Application ID";
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
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(586, 580);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(158, 41);
            this.btnClose.TabIndex = 75;
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
            this.btnSave.Location = new System.Drawing.Point(752, 580);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(158, 41);
            this.btnSave.TabIndex = 76;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddEditLocalDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(922, 633);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabCtrlAddLocalLicense);
            this.Controls.Add(this.lblFormTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddEditLocalDrivingLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmAddEditLocalDrivingLicense_Load);
            this.tabCtrlAddLocalLicense.ResumeLayout(false);
            this.tabPagePerson.ResumeLayout(false);
            this.tabPageApplication.ResumeLayout(false);
            this.tabPageApplication.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFormTitle;
        private Guna.UI2.WinForms.Guna2TabControl tabCtrlAddLocalLicense;
        private System.Windows.Forms.TabPage tabPagePerson;
        private System.Windows.Forms.TabPage tabPageApplication;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAppID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel sdds;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAppDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCreatedBy;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAppFees;
        private ctrlPersonCardWithFilter ctrlPersonCardWithFilterInstance;
        private Guna.UI2.WinForms.Guna2ComboBox comBoxLicenseClass;
        private Guna.UI2.WinForms.Guna2Button btnNextTab;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
    }
}