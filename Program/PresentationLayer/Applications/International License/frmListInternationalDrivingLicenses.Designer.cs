using System;
using System.ComponentModel;

namespace PresentationLayer
{
    partial class frmListInternationalDrivingLicenses
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
            this.conMenManageInternationalLicenseActions = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.comBoxFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtBoxFilterSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.comBoxIsActive = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAddInternationalLicense = new Guna.UI2.WinForms.Guna2Button();
            this.dgvInternationalDrivingLicenses = new Guna.UI2.WinForms.Guna2DataGridView();
            this.conMenManageInternationalLicenseActions.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalDrivingLicenses)).BeginInit();
            this.SuspendLayout();
            // 
            // conMenManageInternationalLicenseActions
            // 
            this.conMenManageInternationalLicenseActions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.conMenManageInternationalLicenseActions.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold);
            this.conMenManageInternationalLicenseActions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.conMenManageInternationalLicenseActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem,
            this.toolStripSeparator5,
            this.showLicenseToolStripMenuItem,
            this.toolStripSeparator7,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.conMenManageInternationalLicenseActions.Name = "conMenManageLocalLicenseActions";
            this.conMenManageInternationalLicenseActions.RenderStyle.ArrowColor = System.Drawing.Color.Gray;
            this.conMenManageInternationalLicenseActions.RenderStyle.BorderColor = System.Drawing.Color.Empty;
            this.conMenManageInternationalLicenseActions.RenderStyle.ColorTable = null;
            this.conMenManageInternationalLicenseActions.RenderStyle.RoundedEdges = true;
            this.conMenManageInternationalLicenseActions.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.conMenManageInternationalLicenseActions.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(242)))), ((int)(((byte)(117)))));
            this.conMenManageInternationalLicenseActions.RenderStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.conMenManageInternationalLicenseActions.RenderStyle.SeparatorColor = System.Drawing.Color.Black;
            this.conMenManageInternationalLicenseActions.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.conMenManageInternationalLicenseActions.Size = new System.Drawing.Size(379, 158);
            this.conMenManageInternationalLicenseActions.Opening += new System.ComponentModel.CancelEventHandler(this.conMenManageInternationalLicenseActions_Opening);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.showPersonDetailsToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.person_info_filled1;
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(388, 38);
            this.showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripSeparator5.Size = new System.Drawing.Size(375, 6);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.showLicenseToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.license_filled;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(388, 38);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripSeparator7.Size = new System.Drawing.Size(375, 6);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.history_filled;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(388, 38);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
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
            this.guna2Panel2.Controls.Add(this.comBoxIsActive);
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(29, 89);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1088, 75);
            this.guna2Panel2.TabIndex = 323;
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
            // comBoxIsActive
            // 
            this.comBoxIsActive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comBoxIsActive.AutoRoundedCorners = true;
            this.comBoxIsActive.BackColor = System.Drawing.Color.White;
            this.comBoxIsActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.comBoxIsActive.BorderRadius = 17;
            this.comBoxIsActive.BorderThickness = 0;
            this.comBoxIsActive.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comBoxIsActive.DropDownHeight = 170;
            this.comBoxIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxIsActive.DropDownWidth = 40;
            this.comBoxIsActive.FillColor = System.Drawing.Color.WhiteSmoke;
            this.comBoxIsActive.FocusedColor = System.Drawing.Color.DarkSlateGray;
            this.comBoxIsActive.FocusedState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.comBoxIsActive.Font = new System.Drawing.Font("Cairo", 12F);
            this.comBoxIsActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.comBoxIsActive.HoverState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.comBoxIsActive.IntegralHeight = false;
            this.comBoxIsActive.ItemHeight = 30;
            this.comBoxIsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.comBoxIsActive.Location = new System.Drawing.Point(40, 13);
            this.comBoxIsActive.Margin = new System.Windows.Forms.Padding(8);
            this.comBoxIsActive.Name = "comBoxIsActive";
            this.comBoxIsActive.Size = new System.Drawing.Size(804, 36);
            this.comBoxIsActive.TabIndex = 312;
            this.comBoxIsActive.Visible = false;
            this.comBoxIsActive.SelectedIndexChanged += new System.EventHandler(this.comBoxIsActive_SelectedIndexChanged);
            // 
            // btnAddInternationalLicense
            // 
            this.btnAddInternationalLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddInternationalLicense.BorderRadius = 4;
            this.btnAddInternationalLicense.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddInternationalLicense.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddInternationalLicense.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddInternationalLicense.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddInternationalLicense.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(242)))), ((int)(((byte)(117)))));
            this.btnAddInternationalLicense.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInternationalLicense.ForeColor = System.Drawing.Color.Black;
            this.btnAddInternationalLicense.Image = global::PresentationLayer.Properties.Resources.International_32;
            this.btnAddInternationalLicense.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddInternationalLicense.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddInternationalLicense.Location = new System.Drawing.Point(783, 20);
            this.btnAddInternationalLicense.Name = "btnAddInternationalLicense";
            this.btnAddInternationalLicense.Size = new System.Drawing.Size(324, 48);
            this.btnAddInternationalLicense.TabIndex = 322;
            this.btnAddInternationalLicense.Text = "Add International License";
            this.btnAddInternationalLicense.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddInternationalLicense.Click += new System.EventHandler(this.btnAddInternationalLicense_Click);
            // 
            // dgvInternationalDrivingLicenses
            // 
            this.dgvInternationalDrivingLicenses.AllowUserToAddRows = false;
            this.dgvInternationalDrivingLicenses.AllowUserToDeleteRows = false;
            this.dgvInternationalDrivingLicenses.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dgvInternationalDrivingLicenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInternationalDrivingLicenses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
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
            this.dgvInternationalDrivingLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInternationalDrivingLicenses.ColumnHeadersHeight = 40;
            this.dgvInternationalDrivingLicenses.ContextMenuStrip = this.conMenManageInternationalLicenseActions;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("SF Compact Display", 10.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.NullValue = "-";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(242)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInternationalDrivingLicenses.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInternationalDrivingLicenses.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInternationalDrivingLicenses.GridColor = System.Drawing.Color.White;
            this.dgvInternationalDrivingLicenses.Location = new System.Drawing.Point(29, 192);
            this.dgvInternationalDrivingLicenses.Margin = new System.Windows.Forms.Padding(20);
            this.dgvInternationalDrivingLicenses.MultiSelect = false;
            this.dgvInternationalDrivingLicenses.Name = "dgvInternationalDrivingLicenses";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInternationalDrivingLicenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInternationalDrivingLicenses.RowHeadersVisible = false;
            this.dgvInternationalDrivingLicenses.RowHeadersWidth = 51;
            this.dgvInternationalDrivingLicenses.RowTemplate.Height = 32;
            this.dgvInternationalDrivingLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvInternationalDrivingLicenses.Size = new System.Drawing.Size(1088, 436);
            this.dgvInternationalDrivingLicenses.TabIndex = 325;
            this.dgvInternationalDrivingLicenses.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvInternationalDrivingLicenses.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvInternationalDrivingLicenses.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvInternationalDrivingLicenses.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvInternationalDrivingLicenses.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvInternationalDrivingLicenses.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvInternationalDrivingLicenses.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgvInternationalDrivingLicenses.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvInternationalDrivingLicenses.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInternationalDrivingLicenses.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvInternationalDrivingLicenses.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvInternationalDrivingLicenses.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInternationalDrivingLicenses.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvInternationalDrivingLicenses.ThemeStyle.ReadOnly = false;
            this.dgvInternationalDrivingLicenses.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvInternationalDrivingLicenses.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInternationalDrivingLicenses.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvInternationalDrivingLicenses.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvInternationalDrivingLicenses.ThemeStyle.RowsStyle.Height = 32;
            this.dgvInternationalDrivingLicenses.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvInternationalDrivingLicenses.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvInternationalDrivingLicenses.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvInternationalDrivingLicenses_DataBindingComplete);
            // 
            // frmListInternationalDrivingLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1146, 642);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.btnAddInternationalLicense);
            this.Controls.Add(this.dgvInternationalDrivingLicenses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListInternationalDrivingLicenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage International Driving Licenses Form";
            this.Load += new System.EventHandler(this.frmManageInternationalDrivingLicenses_Load);
            this.conMenManageInternationalLicenseActions.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalDrivingLicenses)).EndInit();
            this.ResumeLayout(false);

        }

        private void conMenManageInternationalLicenseActions_Opening(object sender, CancelEventArgs e)
        {
            if (dgvInternationalDrivingLicenses.CurrentCell == null)
                return;
        }

        #endregion
        private Guna.UI2.WinForms.Guna2ContextMenuStrip conMenManageInternationalLicenseActions;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ComboBox comBoxFilter;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox comBoxIsActive;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxFilterSearch;
        private Guna.UI2.WinForms.Guna2Button btnAddInternationalLicense;
        private Guna.UI2.WinForms.Guna2DataGridView dgvInternationalDrivingLicenses;
    }
}