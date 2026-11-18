namespace PresentationLayer
{
    partial class frmListUsers
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.comBoxFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comBoxStatuses = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtBoxFilterSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPersonID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.dgvUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.conMenUsersActions = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.ShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.conMenUsersActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.AutoRoundedCorners = true;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.guna2Panel1.Controls.Add(this.comBoxFilter);
            this.guna2Panel1.Controls.Add(this.txtBoxFilterSearch);
            this.guna2Panel1.Controls.Add(this.lblPersonID);
            this.guna2Panel1.Controls.Add(this.comBoxStatuses);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(29, 89);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1088, 75);
            this.guna2Panel1.TabIndex = 319;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
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
            this.comBoxFilter.Font = new System.Drawing.Font("SF Compact Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // comBoxStatuses
            // 
            this.comBoxStatuses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comBoxStatuses.AutoRoundedCorners = true;
            this.comBoxStatuses.BackColor = System.Drawing.Color.White;
            this.comBoxStatuses.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.comBoxStatuses.BorderRadius = 17;
            this.comBoxStatuses.BorderThickness = 0;
            this.comBoxStatuses.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comBoxStatuses.DropDownHeight = 170;
            this.comBoxStatuses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxStatuses.DropDownWidth = 40;
            this.comBoxStatuses.FillColor = System.Drawing.Color.WhiteSmoke;
            this.comBoxStatuses.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(242)))), ((int)(((byte)(117)))));
            this.comBoxStatuses.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(242)))), ((int)(((byte)(117)))));
            this.comBoxStatuses.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold);
            this.comBoxStatuses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.comBoxStatuses.HoverState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.comBoxStatuses.IntegralHeight = false;
            this.comBoxStatuses.ItemHeight = 30;
            this.comBoxStatuses.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.comBoxStatuses.Location = new System.Drawing.Point(40, 13);
            this.comBoxStatuses.Margin = new System.Windows.Forms.Padding(8);
            this.comBoxStatuses.Name = "comBoxStatuses";
            this.comBoxStatuses.Size = new System.Drawing.Size(804, 36);
            this.comBoxStatuses.TabIndex = 312;
            this.comBoxStatuses.Visible = false;
            this.comBoxStatuses.SelectedIndexChanged += new System.EventHandler(this.comBoxStatuses_SelectedIndexChanged);
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
            this.txtBoxFilterSearch.Visible = false;
            this.txtBoxFilterSearch.TextChanged += new System.EventHandler(this.txtBoxFilterSearch_TextChanged);
            this.txtBoxFilterSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxFilterSearch_KeyPress);
            // 
            // lblPersonID
            // 
            this.lblPersonID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPersonID.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonID.Font = new System.Drawing.Font("SF Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblPersonID.IsSelectionEnabled = false;
            this.lblPersonID.Location = new System.Drawing.Point(907, 23);
            this.lblPersonID.Margin = new System.Windows.Forms.Padding(8);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(129, 29);
            this.lblPersonID.TabIndex = 313;
            this.lblPersonID.Text = "Filter By";
            this.lblPersonID.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BorderRadius = 4;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(242)))), ((int)(((byte)(117)))));
            this.btnAdd.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Image = global::PresentationLayer.Properties.Resources.Add_Person_72;
            this.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdd.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAdd.Location = new System.Drawing.Point(926, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(181, 48);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add User";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
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
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.ColumnHeadersHeight = 40;
            this.dgvUsers.ContextMenuStrip = this.conMenUsersActions;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("SF Compact Display", 10.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.NullValue = "-";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(242)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUsers.GridColor = System.Drawing.Color.White;
            this.dgvUsers.Location = new System.Drawing.Point(29, 192);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(20);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 32;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvUsers.Size = new System.Drawing.Size(1088, 436);
            this.dgvUsers.TabIndex = 320;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvUsers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsers.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgvUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsers.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvUsers.ThemeStyle.ReadOnly = false;
            this.dgvUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvUsers.ThemeStyle.RowsStyle.Height = 32;
            this.dgvUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvUsers.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvUsers_DataBindingComplete);
            // 
            // conMenUsersActions
            // 
            this.conMenUsersActions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.conMenUsersActions.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold);
            this.conMenUsersActions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.conMenUsersActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripSeparator1,
            this.changePasswordToolStripMenuItem});
            this.conMenUsersActions.Name = "guna2ContextMenuStrip1";
            this.conMenUsersActions.RenderStyle.ArrowColor = System.Drawing.Color.Gray;
            this.conMenUsersActions.RenderStyle.BorderColor = System.Drawing.Color.Empty;
            this.conMenUsersActions.RenderStyle.ColorTable = null;
            this.conMenUsersActions.RenderStyle.RoundedEdges = true;
            this.conMenUsersActions.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.conMenUsersActions.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(242)))), ((int)(((byte)(117)))));
            this.conMenUsersActions.RenderStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.conMenUsersActions.RenderStyle.SeparatorColor = System.Drawing.Color.Black;
            this.conMenUsersActions.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.conMenUsersActions.Size = new System.Drawing.Size(270, 198);
            this.conMenUsersActions.Opening += new System.ComponentModel.CancelEventHandler(this.conMenUsersActions_Opening);
            // 
            // ShowToolStripMenuItem
            // 
            this.ShowToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.ShowToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.person_info_filled;
            this.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem";
            this.ShowToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.ShowToolStripMenuItem.Size = new System.Drawing.Size(279, 38);
            this.ShowToolStripMenuItem.Text = "Show Details";
            this.ShowToolStripMenuItem.Click += new System.EventHandler(this.ShowToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripSeparator2.Size = new System.Drawing.Size(266, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem3.Image = global::PresentationLayer.Properties.Resources.person_add_filled;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripMenuItem3.Size = new System.Drawing.Size(279, 38);
            this.toolStripMenuItem3.Text = "Add New User";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem4.Image = global::PresentationLayer.Properties.Resources.person_edit_filled;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripMenuItem4.Size = new System.Drawing.Size(279, 38);
            this.toolStripMenuItem4.Text = "Edit";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem5.Image = global::PresentationLayer.Properties.Resources.person_delete_filled;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripMenuItem5.Size = new System.Drawing.Size(279, 38);
            this.toolStripMenuItem5.Text = "Delete";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripSeparator1.Size = new System.Drawing.Size(266, 6);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.password_reset_filled;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(269, 30);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // frmListUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1146, 642);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListUsers";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.conMenUsersActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2ComboBox comBoxFilter;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPersonID;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxFilterSearch;
        private Guna.UI2.WinForms.Guna2ComboBox comBoxStatuses;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUsers;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip conMenUsersActions;
        private System.Windows.Forms.ToolStripMenuItem ShowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}