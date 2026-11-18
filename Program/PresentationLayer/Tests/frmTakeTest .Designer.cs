namespace PresentationLayer
{
    partial class frmTakeTest
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
            this.lblFormTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlRetakeTestInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.lblLockResult = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtBoxNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox5 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.guna2RadioButton1 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.ctrlSceduledTestCard1 = new PresentationLayer.ctrlSceduledTestCard();
            this.rbPass = new System.Windows.Forms.RadioButton();
            this.rbFail = new System.Windows.Forms.RadioButton();
            this.pnlRetakeTestInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 2;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.DarkRed;
            this.btnClose.Font = new System.Drawing.Font("Californian FB", 19.8F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(491, 714);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(115, 45);
            this.btnClose.TabIndex = 71;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.Font = new System.Drawing.Font("Californian FB", 10F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblFormTitle.Location = new System.Drawing.Point(31, 487);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Padding = new System.Windows.Forms.Padding(20, 0, 30, 0);
            this.lblFormTitle.Size = new System.Drawing.Size(131, 21);
            this.lblFormTitle.TabIndex = 320;
            this.lblFormTitle.Text = "Result Info";
            // 
            // pnlRetakeTestInfo
            // 
            this.pnlRetakeTestInfo.BorderColor = System.Drawing.Color.Silver;
            this.pnlRetakeTestInfo.BorderThickness = 1;
            this.pnlRetakeTestInfo.Controls.Add(this.lblLockResult);
            this.pnlRetakeTestInfo.Controls.Add(this.txtBoxNotes);
            this.pnlRetakeTestInfo.Controls.Add(this.guna2HtmlLabel6);
            this.pnlRetakeTestInfo.Controls.Add(this.guna2PictureBox5);
            this.pnlRetakeTestInfo.Controls.Add(this.guna2HtmlLabel10);
            this.pnlRetakeTestInfo.Controls.Add(this.rbPass);
            this.pnlRetakeTestInfo.Controls.Add(this.rbFail);
            this.pnlRetakeTestInfo.Location = new System.Drawing.Point(25, 497);
            this.pnlRetakeTestInfo.Name = "pnlRetakeTestInfo";
            this.pnlRetakeTestInfo.Size = new System.Drawing.Size(572, 208);
            this.pnlRetakeTestInfo.TabIndex = 319;
            // 
            // lblLockResult
            // 
            this.lblLockResult.BackColor = System.Drawing.Color.Transparent;
            this.lblLockResult.Font = new System.Drawing.Font("Californian FB", 10F, System.Drawing.FontStyle.Bold);
            this.lblLockResult.ForeColor = System.Drawing.Color.Red;
            this.lblLockResult.Location = new System.Drawing.Point(293, 3);
            this.lblLockResult.Name = "lblLockResult";
            this.lblLockResult.Padding = new System.Windows.Forms.Padding(20, 20, 30, 20);
            this.lblLockResult.Size = new System.Drawing.Size(269, 61);
            this.lblLockResult.TabIndex = 320;
            this.lblLockResult.Text = "You can not change this result";
            this.lblLockResult.Visible = false;
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
            this.txtBoxNotes.Location = new System.Drawing.Point(94, 66);
            this.txtBoxNotes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxNotes.Multiline = true;
            this.txtBoxNotes.Name = "txtBoxNotes";
            this.txtBoxNotes.PlaceholderText = "";
            this.txtBoxNotes.SelectedText = "";
            this.txtBoxNotes.Size = new System.Drawing.Size(435, 122);
            this.txtBoxNotes.TabIndex = 58;
            this.txtBoxNotes.Tag = "Naming";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel6.IsSelectionEnabled = false;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(9, 17);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(77, 39);
            this.guna2HtmlLabel6.TabIndex = 18;
            this.guna2HtmlLabel6.Text = "Result";
            // 
            // guna2PictureBox5
            // 
            this.guna2PictureBox5.Image = global::PresentationLayer.Properties.Resources.Number_32;
            this.guna2PictureBox5.ImageRotate = 0F;
            this.guna2PictureBox5.Location = new System.Drawing.Point(82, 21);
            this.guna2PictureBox5.Name = "guna2PictureBox5";
            this.guna2PictureBox5.Size = new System.Drawing.Size(30, 30);
            this.guna2PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox5.TabIndex = 19;
            this.guna2PictureBox5.TabStop = false;
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel10.IsSelectionEnabled = false;
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(9, 74);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(79, 39);
            this.guna2HtmlLabel10.TabIndex = 8;
            this.guna2HtmlLabel10.Text = "Notes";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Californian FB", 17F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(181, 3);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Padding = new System.Windows.Forms.Padding(20, 20, 30, 20);
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(230, 74);
            this.guna2HtmlLabel7.TabIndex = 321;
            this.guna2HtmlLabel7.Text = "Scheduled Test";
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 2;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.btnSave.Font = new System.Drawing.Font("Californian FB", 19.8F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(355, 714);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 45);
            this.btnSave.TabIndex = 322;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // guna2RadioButton1
            // 
            this.guna2RadioButton1.AutoSize = true;
            this.guna2RadioButton1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton1.CheckedState.BorderThickness = 0;
            this.guna2RadioButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2RadioButton1.CheckedState.InnerOffset = -4;
            this.guna2RadioButton1.Location = new System.Drawing.Point(118, 26);
            this.guna2RadioButton1.Name = "guna2RadioButton1";
            this.guna2RadioButton1.Size = new System.Drawing.Size(152, 21);
            this.guna2RadioButton1.TabIndex = 321;
            this.guna2RadioButton1.Text = "guna2RadioButton1";
            this.guna2RadioButton1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2RadioButton1.UncheckedState.BorderThickness = 2;
            this.guna2RadioButton1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // ctrlSceduledTestCard1
            // 
            this.ctrlSceduledTestCard1.BackColor = System.Drawing.Color.White;
            this.ctrlSceduledTestCard1.Location = new System.Drawing.Point(15, 83);
            this.ctrlSceduledTestCard1.Name = "ctrlSceduledTestCard1";
            this.ctrlSceduledTestCard1.Size = new System.Drawing.Size(590, 408);
            this.ctrlSceduledTestCard1.TabIndex = 72;
            // 
            // rbPass
            // 
            this.rbPass.AutoSize = true;
            this.rbPass.Checked = true;
            this.rbPass.Font = new System.Drawing.Font("Cairo", 10F);
            this.rbPass.ForeColor = System.Drawing.Color.DimGray;
            this.rbPass.Location = new System.Drawing.Point(132, 18);
            this.rbPass.Name = "rbPass";
            this.rbPass.Size = new System.Drawing.Size(70, 36);
            this.rbPass.TabIndex = 322;
            this.rbPass.TabStop = true;
            this.rbPass.Text = "Pass";
            this.rbPass.UseVisualStyleBackColor = true;
            // 
            // rbFail
            // 
            this.rbFail.AutoSize = true;
            this.rbFail.Font = new System.Drawing.Font("Cairo", 10F);
            this.rbFail.ForeColor = System.Drawing.Color.DimGray;
            this.rbFail.Location = new System.Drawing.Point(223, 18);
            this.rbFail.Name = "rbFail";
            this.rbFail.Size = new System.Drawing.Size(60, 36);
            this.rbFail.TabIndex = 322;
            this.rbFail.Text = "Fail";
            this.rbFail.UseVisualStyleBackColor = true;
            // 
            // frmTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(622, 768);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.pnlRetakeTestInfo);
            this.Controls.Add(this.ctrlSceduledTestCard1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTakeTest";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmTakeTest_Load);
            this.pnlRetakeTestInfo.ResumeLayout(false);
            this.pnlRetakeTestInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private ctrlSceduledTestCard ctrlSceduledTestCard1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFormTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlRetakeTestInfo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxNotes;
        protected internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        protected internal Guna.UI2.WinForms.Guna2HtmlLabel lblLockResult;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton1;
        private System.Windows.Forms.RadioButton rbPass;
        private System.Windows.Forms.RadioButton rbFail;
    }
}