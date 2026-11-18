using System;

namespace PresentationLayer
{
    partial class frmListLocalDrivingLicenses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddLocalLicense = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.comBoxFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtBoxFilterSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.comBoxPublic = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvLocalDrivingLicenses = new Guna.UI2.WinForms.Guna2DataGridView();
            this.conMenManageLocalLicenseActions = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.showApplicationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.scheduleTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleVisionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleWrittenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleStreetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.issueDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicenses)).BeginInit();
            this.conMenManageLocalLicenseActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddLocalLicense
            // 
            this.btnAddLocalLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddLocalLicense.BorderRadius = 4;
            this.btnAddLocalLicense.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddLocalLicense.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddLocalLicense.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddLocalLicense.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddLocalLicense.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(242)))), ((int)(((byte)(117)))));
            this.btnAddLocalLicense.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLocalLicense.ForeColor = System.Drawing.Color.Black;
            this.btnAddLocalLicense.Image = global::PresentationLayer.Properties.Resources.Add_Person_72;
            this.btnAddLocalLicense.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddLocalLicense.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddLocalLicense.Location = new System.Drawing.Point(855, 20);
            this.btnAddLocalLicense.Name = "btnAddLocalLicense";
            this.btnAddLocalLicense.Size = new System.Drawing.Size(252, 48);
            this.btnAddLocalLicense.TabIndex = 319;
            this.btnAddLocalLicense.Text = "Add Local License";
            this.btnAddLocalLicense.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddLocalLicense.Click += new System.EventHandler(this.btnAddLocalLicense_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.AutoRoundedCorners = true;
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.guna2Panel2.Controls.Add(this.comBoxFilter);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel2.Controls.Add(this.txtBoxFilterSearch);
            this.guna2Panel2.Controls.Add(this.comBoxPublic);
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(29, 89);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1088, 75);
            this.guna2Panel2.TabIndex = 321;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // comBoxFilter
            // 
            this.comBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comBoxFilter.BackColor = System.Drawing.Color.Transparent;
            this.comBoxFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.comBoxFilter.BorderRadius = 12;
            this.comBoxFilter.BorderThickness = 0;
            this.comBoxFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxFilter.FillColor = System.Drawing.Color.WhiteSmoke;
            this.comBoxFilter.FocusedColor = System.Drawing.Color.DarkSlateGray;
            this.comBoxFilter.FocusedState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.comBoxFilter.Font = new System.Drawing.Font("SF Compact Display", 10.8F, System.Drawing.FontStyle.Bold);
            this.comBoxFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.comBoxFilter.HoverState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.comBoxFilter.ItemHeight = 30;
            this.comBoxFilter.Location = new System.Drawing.Point(860, 13);
            this.comBoxFilter.Margin = new System.Windows.Forms.Padding(8);
            this.comBoxFilter.Name = "comBoxFilter";
            this.comBoxFilter.Size = new System.Drawing.Size(194, 36);
            this.comBoxFilter.TabIndex = 312;
            this.comBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comBoxFilter_SelectedIndexChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("SF Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.guna2HtmlLabel1.IsSelectionEnabled = false;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(907, 23);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(8);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(129, 29);
            this.guna2HtmlLabel1.TabIndex = 313;
            this.guna2HtmlLabel1.Text = "Filter By";
            this.guna2HtmlLabel1.Visible = false;
            // 
            // txtBoxFilterSearch
            // 
            this.txtBoxFilterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxFilterSearch.AutoRoundedCorners = true;
            this.txtBoxFilterSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxFilterSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.txtBoxFilterSearch.BorderRadius = 21;
            this.txtBoxFilterSearch.BorderThickness = 0;
            this.txtBoxFilterSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxFilterSearch.DefaultText = "";
            this.txtBoxFilterSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxFilterSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxFilterSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxFilterSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxFilterSearch.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtBoxFilterSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxFilterSearch.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold);
            this.txtBoxFilterSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.txtBoxFilterSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxFilterSearch.IconLeft = global::PresentationLayer.Properties.Resources.Search;
            this.txtBoxFilterSearch.Location = new System.Drawing.Point(40, 14);
            this.txtBoxFilterSearch.Margin = new System.Windows.Forms.Padding(8);
            this.txtBoxFilterSearch.Name = "txtBoxFilterSearch";
            this.txtBoxFilterSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.txtBoxFilterSearch.PlaceholderText = "Search ...";
            this.txtBoxFilterSearch.SelectedText = "";
            this.txtBoxFilterSearch.Size = new System.Drawing.Size(804, 45);
            this.txtBoxFilterSearch.TabIndex = 314;
            this.txtBoxFilterSearch.TextChanged += new System.EventHandler(this.txtBoxFilterSearch_TextChanged);
            this.txtBoxFilterSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxFilterSearch_KeyPress);
            // 
            // comBoxPublic
            // 
            this.comBoxPublic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comBoxPublic.AutoRoundedCorners = true;
            this.comBoxPublic.BackColor = System.Drawing.Color.White;
            this.comBoxPublic.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.comBoxPublic.BorderRadius = 17;
            this.comBoxPublic.BorderThickness = 0;
            this.comBoxPublic.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comBoxPublic.DropDownHeight = 170;
            this.comBoxPublic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxPublic.DropDownWidth = 40;
            this.comBoxPublic.FillColor = System.Drawing.Color.WhiteSmoke;
            this.comBoxPublic.FocusedColor = System.Drawing.Color.DarkSlateGray;
            this.comBoxPublic.FocusedState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.comBoxPublic.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold);
            this.comBoxPublic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.comBoxPublic.HoverState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.comBoxPublic.IntegralHeight = false;
            this.comBoxPublic.ItemHeight = 30;
            this.comBoxPublic.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.comBoxPublic.Location = new System.Drawing.Point(40, 13);
            this.comBoxPublic.Margin = new System.Windows.Forms.Padding(8);
            this.comBoxPublic.Name = "comBoxPublic";
            this.comBoxPublic.Size = new System.Drawing.Size(804, 36);
            this.comBoxPublic.TabIndex = 312;
            this.comBoxPublic.Visible = false;
            // 
            // dgvLocalDrivingLicenses
            // 
            this.dgvLocalDrivingLicenses.AllowUserToAddRows = false;
            this.dgvLocalDrivingLicenses.AllowUserToDeleteRows = false;
            this.dgvLocalDrivingLicenses.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dgvLocalDrivingLicenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLocalDrivingLicenses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SF Compact Display", 11.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.NullValue = "null";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLocalDrivingLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLocalDrivingLicenses.ColumnHeadersHeight = 40;
            this.dgvLocalDrivingLicenses.ContextMenuStrip = this.conMenManageLocalLicenseActions;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("SF Compact Display", 10.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.NullValue = "-";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(242)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLocalDrivingLicenses.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLocalDrivingLicenses.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLocalDrivingLicenses.GridColor = System.Drawing.Color.White;
            this.dgvLocalDrivingLicenses.Location = new System.Drawing.Point(29, 192);
            this.dgvLocalDrivingLicenses.Margin = new System.Windows.Forms.Padding(20);
            this.dgvLocalDrivingLicenses.MultiSelect = false;
            this.dgvLocalDrivingLicenses.Name = "dgvLocalDrivingLicenses";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLocalDrivingLicenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLocalDrivingLicenses.RowHeadersVisible = false;
            this.dgvLocalDrivingLicenses.RowHeadersWidth = 51;
            this.dgvLocalDrivingLicenses.RowTemplate.Height = 32;
            this.dgvLocalDrivingLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvLocalDrivingLicenses.Size = new System.Drawing.Size(1088, 436);
            this.dgvLocalDrivingLicenses.TabIndex = 323;
            this.dgvLocalDrivingLicenses.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLocalDrivingLicenses.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvLocalDrivingLicenses.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvLocalDrivingLicenses.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvLocalDrivingLicenses.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvLocalDrivingLicenses.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvLocalDrivingLicenses.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgvLocalDrivingLicenses.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvLocalDrivingLicenses.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLocalDrivingLicenses.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvLocalDrivingLicenses.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLocalDrivingLicenses.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLocalDrivingLicenses.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvLocalDrivingLicenses.ThemeStyle.ReadOnly = false;
            this.dgvLocalDrivingLicenses.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLocalDrivingLicenses.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLocalDrivingLicenses.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvLocalDrivingLicenses.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLocalDrivingLicenses.ThemeStyle.RowsStyle.Height = 32;
            this.dgvLocalDrivingLicenses.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLocalDrivingLicenses.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLocalDrivingLicenses.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvLocalDrivingLicenses_DataBindingComplete);
            // 
            // conMenManageLocalLicenseActions
            // 
            this.conMenManageLocalLicenseActions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.conMenManageLocalLicenseActions.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold);
            this.conMenManageLocalLicenseActions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.conMenManageLocalLicenseActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDetailsToolStripMenuItem,
            this.toolStripSeparator6,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator3,
            this.cancelToolStripMenuItem,
            this.toolStripSeparator8,
            this.scheduleTestsToolStripMenuItem,
            this.toolStripSeparator9,
            this.issueDrivingLicenseToolStripMenuItem,
            this.toolStripSeparator10,
            this.showLicenseToolStripMenuItem,
            this.toolStripSeparator11,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.conMenManageLocalLicenseActions.Name = "guna2ContextMenuStrip1";
            this.conMenManageLocalLicenseActions.RenderStyle.ArrowColor = System.Drawing.Color.Gray;
            this.conMenManageLocalLicenseActions.RenderStyle.BorderColor = System.Drawing.Color.Empty;
            this.conMenManageLocalLicenseActions.RenderStyle.ColorTable = null;
            this.conMenManageLocalLicenseActions.RenderStyle.RoundedEdges = true;
            this.conMenManageLocalLicenseActions.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.conMenManageLocalLicenseActions.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(242)))), ((int)(((byte)(117)))));
            this.conMenManageLocalLicenseActions.RenderStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.conMenManageLocalLicenseActions.RenderStyle.SeparatorColor = System.Drawing.Color.Black;
            this.conMenManageLocalLicenseActions.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.conMenManageLocalLicenseActions.Size = new System.Drawing.Size(415, 332);
            this.conMenManageLocalLicenseActions.Opening += new System.ComponentModel.CancelEventHandler(this.conMenManageLocalLicenseActions_Opening);
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            this.showApplicationDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.showApplicationDetailsToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.person_info_filled;
            this.showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            this.showApplicationDetailsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.showApplicationDetailsToolStripMenuItem.Size = new System.Drawing.Size(424, 38);
            this.showApplicationDetailsToolStripMenuItem.Text = "Show Application Details";
            this.showApplicationDetailsToolStripMenuItem.Click += new System.EventHandler(this.showApplicationDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripSeparator6.Size = new System.Drawing.Size(411, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.editToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.person_edit_filled;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.editToolStripMenuItem.Size = new System.Drawing.Size(424, 38);
            this.editToolStripMenuItem.Text = "Edit Application";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.deleteToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.person_delete_filled;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(424, 38);
            this.deleteToolStripMenuItem.Text = "Delete Application";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripSeparator3.Size = new System.Drawing.Size(411, 6);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.password_reset_filled;
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(414, 30);
            this.cancelToolStripMenuItem.Text = "Cancel Application";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripSeparator8.Size = new System.Drawing.Size(411, 6);
            // 
            // scheduleTestsToolStripMenuItem
            // 
            this.scheduleTestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleVisionTestToolStripMenuItem,
            this.scheduleWrittenTestToolStripMenuItem,
            this.scheduleStreetTestToolStripMenuItem});
            this.scheduleTestsToolStripMenuItem.Name = "scheduleTestsToolStripMenuItem";
            this.scheduleTestsToolStripMenuItem.Size = new System.Drawing.Size(414, 30);
            this.scheduleTestsToolStripMenuItem.Text = "Schedule Tests";
            this.scheduleTestsToolStripMenuItem.DropDownClosed += new System.EventHandler(this.scheduleTestsToolStripMenuItem_DropDownClosed);
            this.scheduleTestsToolStripMenuItem.DropDownOpening += new System.EventHandler(this.scheduleTestsToolStripMenuItem_DropDownOpening);
            // 
            // scheduleVisionTestToolStripMenuItem
            // 
            this.scheduleVisionTestToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.scheduleVisionTestToolStripMenuItem.Enabled = false;
            this.scheduleVisionTestToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.scheduleVisionTestToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.Vision_512;
            this.scheduleVisionTestToolStripMenuItem.Name = "scheduleVisionTestToolStripMenuItem";
            this.scheduleVisionTestToolStripMenuItem.Size = new System.Drawing.Size(316, 30);
            this.scheduleVisionTestToolStripMenuItem.Text = "Schedule Vision Test";
            this.scheduleVisionTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleVisionTestToolStripMenuItem_Click);
            // 
            // scheduleWrittenTestToolStripMenuItem
            // 
            this.scheduleWrittenTestToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.scheduleWrittenTestToolStripMenuItem.Enabled = false;
            this.scheduleWrittenTestToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.scheduleWrittenTestToolStripMenuItem.Name = "scheduleWrittenTestToolStripMenuItem";
            this.scheduleWrittenTestToolStripMenuItem.Size = new System.Drawing.Size(316, 30);
            this.scheduleWrittenTestToolStripMenuItem.Text = "Schedule Written Test";
            this.scheduleWrittenTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleWrittenTestToolStripMenuItem_Click);
            // 
            // scheduleStreetTestToolStripMenuItem
            // 
            this.scheduleStreetTestToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.scheduleStreetTestToolStripMenuItem.Enabled = false;
            this.scheduleStreetTestToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.scheduleStreetTestToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.Street_Test_32;
            this.scheduleStreetTestToolStripMenuItem.Name = "scheduleStreetTestToolStripMenuItem";
            this.scheduleStreetTestToolStripMenuItem.Size = new System.Drawing.Size(316, 30);
            this.scheduleStreetTestToolStripMenuItem.Text = "Schedule Street Test";
            this.scheduleStreetTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleStreetTestToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripSeparator9.Size = new System.Drawing.Size(411, 6);
            // 
            // issueDrivingLicenseToolStripMenuItem
            // 
            this.issueDrivingLicenseToolStripMenuItem.Name = "issueDrivingLicenseToolStripMenuItem";
            this.issueDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(414, 30);
            this.issueDrivingLicenseToolStripMenuItem.Text = "Issue Driving License (First Time)";
            this.issueDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.issueDrivingLicenseToolStripMenuItem_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripSeparator10.Size = new System.Drawing.Size(411, 6);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(414, 30);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripSeparator11.Size = new System.Drawing.Size(411, 6);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(414, 30);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // frmListLocalDrivingLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1146, 642);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.btnAddLocalLicense);
            this.Controls.Add(this.dgvLocalDrivingLicenses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListLocalDrivingLicenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Local Driving Licenses";
            this.Load += new System.EventHandler(this.frmManageLocalDrivingLicences_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicenses)).EndInit();
            this.conMenManageLocalLicenseActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnAddLocalLicense;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ComboBox comBoxFilter;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox comBoxPublic;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxFilterSearch;
        private Guna.UI2.WinForms.Guna2DataGridView dgvLocalDrivingLicenses;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip conMenManageLocalLicenseActions;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem scheduleTestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleVisionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleWrittenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleStreetTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}