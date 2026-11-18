namespace PresentationLayer
{
    partial class frmIssueDrivingLicenseForFirstTime
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
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnIssue = new Guna.UI2.WinForms.Guna2Button();
            this.txtBoxNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.Guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.localDrivingLicenseApplicationCard1 = new PresentationLayer.LocalDrivingLicenseApplicationCard();
            this.lblFormTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 2;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.DarkRed;
            this.btnClose.Font = new System.Drawing.Font("Californian FB", 19.8F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(655, 739);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(115, 45);
            this.btnClose.TabIndex = 89;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.BorderRadius = 2;
            this.btnIssue.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIssue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIssue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIssue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIssue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIssue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.btnIssue.Font = new System.Drawing.Font("Californian FB", 19.8F, System.Drawing.FontStyle.Bold);
            this.btnIssue.ForeColor = System.Drawing.Color.White;
            this.btnIssue.Location = new System.Drawing.Point(783, 739);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(115, 45);
            this.btnIssue.TabIndex = 323;
            this.btnIssue.Text = "Issue";
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // txtBoxNotes
            // 
            this.txtBoxNotes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.txtBoxNotes.BorderRadius = 2;
            this.txtBoxNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxNotes.DefaultText = "";
            this.txtBoxNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxNotes.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxNotes.IconLeft = global::PresentationLayer.Properties.Resources.Notes_32;
            this.txtBoxNotes.Location = new System.Drawing.Point(122, 541);
            this.txtBoxNotes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxNotes.Multiline = true;
            this.txtBoxNotes.Name = "txtBoxNotes";
            this.txtBoxNotes.PlaceholderText = "";
            this.txtBoxNotes.SelectedText = "";
            this.txtBoxNotes.Size = new System.Drawing.Size(776, 171);
            this.txtBoxNotes.TabIndex = 325;
            this.txtBoxNotes.Tag = "Naming";
            // 
            // Guna2HtmlLabel1
            // 
            this.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.Guna2HtmlLabel1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.Guna2HtmlLabel1.IsSelectionEnabled = false;
            this.Guna2HtmlLabel1.Location = new System.Drawing.Point(37, 541);
            this.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1";
            this.Guna2HtmlLabel1.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.Guna2HtmlLabel1.Size = new System.Drawing.Size(79, 39);
            this.Guna2HtmlLabel1.TabIndex = 324;
            this.Guna2HtmlLabel1.Text = "Notes";
            // 
            // localDrivingLicenseApplicationCard1
            // 
            this.localDrivingLicenseApplicationCard1.BackColor = System.Drawing.Color.White;
            this.localDrivingLicenseApplicationCard1.Location = new System.Drawing.Point(23, 87);
            this.localDrivingLicenseApplicationCard1.Name = "localDrivingLicenseApplicationCard1";
            this.localDrivingLicenseApplicationCard1.Size = new System.Drawing.Size(881, 416);
            this.localDrivingLicenseApplicationCard1.TabIndex = 326;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = false;
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFormTitle.Font = new System.Drawing.Font("Californian FB", 17F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.Red;
            this.lblFormTitle.Location = new System.Drawing.Point(0, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Padding = new System.Windows.Forms.Padding(20, 20, 30, 20);
            this.lblFormTitle.Size = new System.Drawing.Size(920, 74);
            this.lblFormTitle.TabIndex = 327;
            this.lblFormTitle.Text = "Issue Driving License For First Time";
            this.lblFormTitle.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmIssueDrivingLicenseForFirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 798);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.localDrivingLicenseApplicationCard1);
            this.Controls.Add(this.txtBoxNotes);
            this.Controls.Add(this.Guna2HtmlLabel1);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnClose);
            this.Name = "frmIssueDrivingLicenseForFirstTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Issue Driving License For First Time";
            this.Load += new System.EventHandler(this.frmIssueDrivingLicenseForFirstTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnIssue;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxNotes;
        private Guna.UI2.WinForms.Guna2HtmlLabel Guna2HtmlLabel1;
        private LocalDrivingLicenseApplicationCard localDrivingLicenseApplicationCard1;
        protected internal Guna.UI2.WinForms.Guna2HtmlLabel lblFormTitle;
    }
}