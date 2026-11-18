namespace PresentationLayer
{
    partial class frmEditTestType
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
            this.txtBoxFees = new System.Windows.Forms.NumericUpDown();
            this.lblFormTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.txtBoxDesc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxFees)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxFees
            // 
            this.txtBoxFees.DecimalPlaces = 3;
            this.txtBoxFees.Font = new System.Drawing.Font("SF Pro Rounded", 9.5F, System.Drawing.FontStyle.Bold);
            this.txtBoxFees.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxFees.Location = new System.Drawing.Point(214, 284);
            this.txtBoxFees.Name = "txtBoxFees";
            this.txtBoxFees.Size = new System.Drawing.Size(120, 26);
            this.txtBoxFees.TabIndex = 75;
            this.txtBoxFees.ThousandsSeparator = true;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.Font = new System.Drawing.Font("SF Pro Rounded", 18.2F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblFormTitle.Location = new System.Drawing.Point(136, -1);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Padding = new System.Windows.Forms.Padding(20, 20, 30, 20);
            this.lblFormTitle.Size = new System.Drawing.Size(248, 78);
            this.lblFormTitle.TabIndex = 77;
            this.lblFormTitle.Text = "Edit Test Type";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 16;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Brown;
            this.guna2Button1.Font = new System.Drawing.Font("SF Pro Rounded", 16.2F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Image = global::PresentationLayer.Properties.Resources.CloseBlack;
            this.guna2Button1.Location = new System.Drawing.Point(96, 375);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(158, 41);
            this.guna2Button1.TabIndex = 78;
            this.guna2Button1.Text = "Close";
            this.guna2Button1.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 16;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(242)))), ((int)(((byte)(117)))));
            this.guna2Button2.Font = new System.Drawing.Font("SF Pro Rounded", 16.2F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.Image = global::PresentationLayer.Properties.Resources.save_filled;
            this.guna2Button2.Location = new System.Drawing.Point(262, 375);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(158, 41);
            this.guna2Button2.TabIndex = 79;
            this.guna2Button2.Text = "Save";
            this.guna2Button2.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBoxDesc
            // 
            this.txtBoxDesc.BorderColor = System.Drawing.Color.LightGray;
            this.txtBoxDesc.BorderRadius = 16;
            this.txtBoxDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxDesc.DefaultText = "";
            this.txtBoxDesc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxDesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxDesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxDesc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxDesc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxDesc.Font = new System.Drawing.Font("SF Pro Rounded", 9.5F, System.Drawing.FontStyle.Bold);
            this.txtBoxDesc.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxDesc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxDesc.IconLeft = global::PresentationLayer.Properties.Resources.Notes_32;
            this.txtBoxDesc.Location = new System.Drawing.Point(162, 158);
            this.txtBoxDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxDesc.Multiline = true;
            this.txtBoxDesc.Name = "txtBoxDesc";
            this.txtBoxDesc.PlaceholderText = "";
            this.txtBoxDesc.SelectedText = "";
            this.txtBoxDesc.Size = new System.Drawing.Size(320, 105);
            this.txtBoxDesc.TabIndex = 81;
            this.txtBoxDesc.Tag = "StringWithWhiteSpace";
            this.txtBoxDesc.Validating += new System.ComponentModel.CancelEventHandler(this.NullOrEmpty_Validating);
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.AutoRoundedCorners = true;
            this.txtBoxTitle.BorderColor = System.Drawing.Color.LightGray;
            this.txtBoxTitle.BorderRadius = 16;
            this.txtBoxTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxTitle.DefaultText = "";
            this.txtBoxTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxTitle.Font = new System.Drawing.Font("SF Pro Rounded", 9.5F, System.Drawing.FontStyle.Bold);
            this.txtBoxTitle.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxTitle.Location = new System.Drawing.Point(162, 97);
            this.txtBoxTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.PlaceholderText = "";
            this.txtBoxTitle.SelectedText = "";
            this.txtBoxTitle.Size = new System.Drawing.Size(320, 34);
            this.txtBoxTitle.TabIndex = 80;
            this.txtBoxTitle.Tag = "Naming";
            this.txtBoxTitle.Validating += new System.ComponentModel.CancelEventHandler(this.NullOrEmpty_Validating);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(13, 100);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(66, 28);
            this.guna2HtmlLabel4.TabIndex = 82;
            this.guna2HtmlLabel4.Text = "Title";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(13, 166);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(138, 28);
            this.guna2HtmlLabel1.TabIndex = 83;
            this.guna2HtmlLabel1.Text = "Description";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(13, 283);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(70, 28);
            this.guna2HtmlLabel3.TabIndex = 84;
            this.guna2HtmlLabel3.Text = "Fees";
            // 
            // frmEditTestType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(554, 460);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.txtBoxFees);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.txtBoxTitle);
            this.Controls.Add(this.txtBoxDesc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEditTestType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Test Type";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditApplicationType_FormClosing);
            this.Load += new System.EventHandler(this.frmEditApplicationType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxFees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown txtBoxFees;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFormTitle;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxDesc;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
    }
}