using System;

namespace PresentationLayer
{
    partial class frmListPeople
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
            this.conMenPeopleActions = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.ShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.comBoxFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblPersonID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.comBoxPublic = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtBoxFilterSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvPeople = new Guna.UI2.WinForms.Guna2DataGridView();
            this.conMenPeopleActions.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // conMenPeopleActions
            // 
            this.conMenPeopleActions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.conMenPeopleActions.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold);
            this.conMenPeopleActions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.conMenPeopleActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowToolStripMenuItem,
            this.AddToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.conMenPeopleActions.Name = "guna2ContextMenuStrip1";
            this.conMenPeopleActions.RenderStyle.ArrowColor = System.Drawing.Color.Gray;
            this.conMenPeopleActions.RenderStyle.BorderColor = System.Drawing.Color.Empty;
            this.conMenPeopleActions.RenderStyle.ColorTable = null;
            this.conMenPeopleActions.RenderStyle.RoundedEdges = true;
            this.conMenPeopleActions.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.conMenPeopleActions.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(242)))), ((int)(((byte)(117)))));
            this.conMenPeopleActions.RenderStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.conMenPeopleActions.RenderStyle.SeparatorColor = System.Drawing.Color.Black;
            this.conMenPeopleActions.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.conMenPeopleActions.Size = new System.Drawing.Size(254, 238);
            this.conMenPeopleActions.Opening += new System.ComponentModel.CancelEventHandler(this.conMenPeopleActions_Opening);
            // 
            // ShowToolStripMenuItem
            // 
            this.ShowToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.ShowToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.person_info_filled;
            this.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem";
            this.ShowToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.ShowToolStripMenuItem.Size = new System.Drawing.Size(263, 38);
            this.ShowToolStripMenuItem.Text = "Show Details";
            this.ShowToolStripMenuItem.Click += new System.EventHandler(this.ShowToolStripMenuItem_Click);
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.AddToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.person_add_filled;
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(263, 38);
            this.AddToolStripMenuItem.Text = "Add New Person";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.editToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.person_edit_filled;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.editToolStripMenuItem.Size = new System.Drawing.Size(263, 38);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.deleteToolStripMenuItem1.Image = global::PresentationLayer.Properties.Resources.person_delete_filled;
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Padding = new System.Windows.Forms.Padding(5);
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(263, 38);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripMenuItem1.Size = new System.Drawing.Size(250, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.sendEmailToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.send_person_filled;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(263, 38);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.phoneCallToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.phone_person_filled;
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(263, 38);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
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
            this.btnAdd.Image = global::PresentationLayer.Properties.Resources.person_add_filled;
            this.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdd.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAdd.Location = new System.Drawing.Point(926, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(181, 48);
            this.btnAdd.TabIndex = 318;
            this.btnAdd.Text = "Add Person";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.AutoRoundedCorners = true;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.guna2Panel1.Controls.Add(this.comBoxFilter);
            this.guna2Panel1.Controls.Add(this.lblPersonID);
            this.guna2Panel1.Controls.Add(this.txtBoxFilterSearch);
            this.guna2Panel1.Controls.Add(this.comBoxPublic);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(29, 89);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1088, 75);
            this.guna2Panel1.TabIndex = 320;
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
            this.comBoxPublic.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(242)))), ((int)(((byte)(117)))));
            this.comBoxPublic.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(242)))), ((int)(((byte)(117)))));
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
            // dgvPeople
            // 
            this.dgvPeople.AllowUserToAddRows = false;
            this.dgvPeople.AllowUserToDeleteRows = false;
            this.dgvPeople.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dgvPeople.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
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
            this.dgvPeople.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPeople.ColumnHeadersHeight = 40;
            this.dgvPeople.ContextMenuStrip = this.conMenPeopleActions;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("SF Compact Display", 10.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.NullValue = "-";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(242)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPeople.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPeople.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPeople.GridColor = System.Drawing.Color.White;
            this.dgvPeople.Location = new System.Drawing.Point(29, 192);
            this.dgvPeople.Margin = new System.Windows.Forms.Padding(20);
            this.dgvPeople.MultiSelect = false;
            this.dgvPeople.Name = "dgvPeople";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeople.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPeople.RowHeadersVisible = false;
            this.dgvPeople.RowHeadersWidth = 51;
            this.dgvPeople.RowTemplate.Height = 32;
            this.dgvPeople.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPeople.Size = new System.Drawing.Size(1088, 436);
            this.dgvPeople.TabIndex = 321;
            this.dgvPeople.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPeople.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPeople.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPeople.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPeople.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPeople.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPeople.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgvPeople.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPeople.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPeople.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvPeople.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPeople.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPeople.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvPeople.ThemeStyle.ReadOnly = false;
            this.dgvPeople.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPeople.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPeople.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvPeople.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPeople.ThemeStyle.RowsStyle.Height = 32;
            this.dgvPeople.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPeople.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPeople.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeople_CellContentDoubleClick);
            this.dgvPeople.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPeople_DataBindingComplete);
            // 
            // frmListPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1146, 642);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvPeople);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListPeople";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPeople_Load);
            this.conMenPeopleActions.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ContextMenuStrip conMenPeopleActions;
        private System.Windows.Forms.ToolStripMenuItem ShowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox comBoxFilter;
        private Guna.UI2.WinForms.Guna2ComboBox comBoxPublic;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxFilterSearch;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPersonID;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPeople;
    }
}