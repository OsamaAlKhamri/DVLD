using System;

namespace PresentationLayer
{
    partial class frmAddUpdatePerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdatePerson));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.rbFemale = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.rbMale = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.comBoxCountry = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtPicDateOfBirth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtBoxAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxNationalNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxLast = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxThird = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxSecond = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxFirst = new Guna.UI2.WinForms.Guna2TextBox();
            this.PicPersonImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblRemove = new System.Windows.Forms.LinkLabel();
            this.lblSetImage = new System.Windows.Forms.LinkLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel15 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel14 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPersonID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox6 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicPersonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "jpg|*.jpg|png|*.png";
            // 
            // rbFemale
            // 
            this.rbFemale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbFemale.CheckedState.BorderThickness = 0;
            this.rbFemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbFemale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbFemale.Location = new System.Drawing.Point(253, 196);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(20, 20);
            this.rbFemale.TabIndex = 68;
            this.rbFemale.Text = "0";
            this.rbFemale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbFemale.UncheckedState.BorderThickness = 2;
            this.rbFemale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbFemale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
            // 
            // rbMale
            // 
            this.rbMale.Checked = true;
            this.rbMale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbMale.CheckedState.BorderThickness = 0;
            this.rbMale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbMale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbMale.Location = new System.Drawing.Point(166, 196);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(20, 20);
            this.rbMale.TabIndex = 67;
            this.rbMale.Text = "rbMale";
            this.rbMale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbMale.UncheckedState.BorderThickness = 2;
            this.rbMale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbMale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // comBoxCountry
            // 
            this.comBoxCountry.AutoRoundedCorners = true;
            this.comBoxCountry.BackColor = System.Drawing.Color.Transparent;
            this.comBoxCountry.BorderColor = System.Drawing.Color.LightGray;
            this.comBoxCountry.BorderRadius = 17;
            this.comBoxCountry.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comBoxCountry.DropDownHeight = 170;
            this.comBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxCountry.DropDownWidth = 40;
            this.comBoxCountry.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(242)))), ((int)(((byte)(117)))));
            this.comBoxCountry.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(242)))), ((int)(((byte)(117)))));
            this.comBoxCountry.Font = new System.Drawing.Font("SF Pro Rounded", 9.5F, System.Drawing.FontStyle.Bold);
            this.comBoxCountry.ForeColor = System.Drawing.Color.DimGray;
            this.comBoxCountry.IntegralHeight = false;
            this.comBoxCountry.ItemHeight = 30;
            this.comBoxCountry.Location = new System.Drawing.Point(532, 224);
            this.comBoxCountry.Name = "comBoxCountry";
            this.comBoxCountry.Size = new System.Drawing.Size(175, 36);
            this.comBoxCountry.TabIndex = 66;
            // 
            // dtPicDateOfBirth
            // 
            this.dtPicDateOfBirth.BorderRadius = 4;
            this.dtPicDateOfBirth.Checked = true;
            this.dtPicDateOfBirth.FillColor = System.Drawing.Color.White;
            this.dtPicDateOfBirth.Font = new System.Drawing.Font("SF Pro Rounded", 9.5F, System.Drawing.FontStyle.Bold);
            this.dtPicDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPicDateOfBirth.IndicateFocus = true;
            this.dtPicDateOfBirth.Location = new System.Drawing.Point(551, 135);
            this.dtPicDateOfBirth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtPicDateOfBirth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtPicDateOfBirth.Name = "dtPicDateOfBirth";
            this.dtPicDateOfBirth.Size = new System.Drawing.Size(175, 27);
            this.dtPicDateOfBirth.TabIndex = 65;
            this.dtPicDateOfBirth.Value = new System.DateTime(2025, 10, 27, 0, 0, 0, 0);
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.BorderColor = System.Drawing.Color.LightGray;
            this.txtBoxAddress.BorderRadius = 16;
            this.txtBoxAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxAddress.DefaultText = "";
            this.txtBoxAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxAddress.Font = new System.Drawing.Font("SF Pro Rounded", 9.5F, System.Drawing.FontStyle.Bold);
            this.txtBoxAddress.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxAddress.IconLeft = global::PresentationLayer.Properties.Resources.Address_32;
            this.txtBoxAddress.Location = new System.Drawing.Point(142, 285);
            this.txtBoxAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxAddress.Multiline = true;
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.PlaceholderText = "";
            this.txtBoxAddress.SelectedText = "";
            this.txtBoxAddress.Size = new System.Drawing.Size(316, 103);
            this.txtBoxAddress.TabIndex = 64;
            this.txtBoxAddress.Tag = "StringWithWhiteSpace";
            this.txtBoxAddress.Validating += new System.ComponentModel.CancelEventHandler(this.NullableOrEmpty_Validating);
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.AutoRoundedCorners = true;
            this.txtBoxEmail.BorderColor = System.Drawing.Color.LightGray;
            this.txtBoxEmail.BorderRadius = 12;
            this.txtBoxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxEmail.DefaultText = "";
            this.txtBoxEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxEmail.Font = new System.Drawing.Font("SF Pro Rounded", 9.5F, System.Drawing.FontStyle.Bold);
            this.txtBoxEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxEmail.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtBoxEmail.IconLeft")));
            this.txtBoxEmail.Location = new System.Drawing.Point(142, 238);
            this.txtBoxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.PlaceholderText = "";
            this.txtBoxEmail.SelectedText = "";
            this.txtBoxEmail.Size = new System.Drawing.Size(175, 27);
            this.txtBoxEmail.TabIndex = 63;
            this.txtBoxEmail.Tag = "Email";
            this.txtBoxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            this.txtBoxEmail.Validating += new System.ComponentModel.CancelEventHandler(this.Email_Validating);
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.AutoRoundedCorners = true;
            this.txtBoxPhone.BorderColor = System.Drawing.Color.LightGray;
            this.txtBoxPhone.BorderRadius = 12;
            this.txtBoxPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxPhone.DefaultText = "";
            this.txtBoxPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxPhone.Font = new System.Drawing.Font("SF Pro Rounded", 9.5F, System.Drawing.FontStyle.Bold);
            this.txtBoxPhone.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxPhone.IconLeft = global::PresentationLayer.Properties.Resources.phone;
            this.txtBoxPhone.IconLeftSize = new System.Drawing.Size(17, 20);
            this.txtBoxPhone.Location = new System.Drawing.Point(515, 182);
            this.txtBoxPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.PlaceholderText = "";
            this.txtBoxPhone.SelectedText = "";
            this.txtBoxPhone.Size = new System.Drawing.Size(175, 27);
            this.txtBoxPhone.TabIndex = 62;
            this.txtBoxPhone.Tag = "Phone";
            this.txtBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            this.txtBoxPhone.Validating += new System.ComponentModel.CancelEventHandler(this.NullableOrEmpty_Validating);
            // 
            // txtBoxNationalNo
            // 
            this.txtBoxNationalNo.AutoRoundedCorners = true;
            this.txtBoxNationalNo.BorderColor = System.Drawing.Color.LightGray;
            this.txtBoxNationalNo.BorderRadius = 12;
            this.txtBoxNationalNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxNationalNo.DefaultText = "";
            this.txtBoxNationalNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxNationalNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxNationalNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxNationalNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxNationalNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxNationalNo.Font = new System.Drawing.Font("SF Pro Rounded", 9.5F, System.Drawing.FontStyle.Bold);
            this.txtBoxNationalNo.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxNationalNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxNationalNo.IconLeft = global::PresentationLayer.Properties.Resources.national_no;
            this.txtBoxNationalNo.Location = new System.Drawing.Point(198, 135);
            this.txtBoxNationalNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxNationalNo.Name = "txtBoxNationalNo";
            this.txtBoxNationalNo.PlaceholderText = "";
            this.txtBoxNationalNo.SelectedText = "";
            this.txtBoxNationalNo.Size = new System.Drawing.Size(175, 27);
            this.txtBoxNationalNo.TabIndex = 61;
            this.txtBoxNationalNo.Tag = "String";
            this.txtBoxNationalNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            this.txtBoxNationalNo.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxNationalNo_Validating);
            // 
            // txtBoxLast
            // 
            this.txtBoxLast.AutoRoundedCorners = true;
            this.txtBoxLast.BorderColor = System.Drawing.Color.LightGray;
            this.txtBoxLast.BorderRadius = 12;
            this.txtBoxLast.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxLast.DefaultText = "";
            this.txtBoxLast.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxLast.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxLast.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxLast.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxLast.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxLast.Font = new System.Drawing.Font("SF Pro Rounded", 9.5F, System.Drawing.FontStyle.Bold);
            this.txtBoxLast.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxLast.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxLast.Location = new System.Drawing.Point(742, 90);
            this.txtBoxLast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxLast.Name = "txtBoxLast";
            this.txtBoxLast.PlaceholderText = "";
            this.txtBoxLast.SelectedText = "";
            this.txtBoxLast.Size = new System.Drawing.Size(175, 27);
            this.txtBoxLast.TabIndex = 60;
            this.txtBoxLast.Tag = "Naming";
            this.txtBoxLast.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // txtBoxThird
            // 
            this.txtBoxThird.AutoRoundedCorners = true;
            this.txtBoxThird.BorderColor = System.Drawing.Color.LightGray;
            this.txtBoxThird.BorderRadius = 12;
            this.txtBoxThird.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxThird.DefaultText = "";
            this.txtBoxThird.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxThird.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxThird.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxThird.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxThird.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxThird.Font = new System.Drawing.Font("SF Pro Rounded", 9.5F, System.Drawing.FontStyle.Bold);
            this.txtBoxThird.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxThird.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxThird.Location = new System.Drawing.Point(542, 90);
            this.txtBoxThird.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxThird.Name = "txtBoxThird";
            this.txtBoxThird.PlaceholderText = "";
            this.txtBoxThird.SelectedText = "";
            this.txtBoxThird.Size = new System.Drawing.Size(175, 27);
            this.txtBoxThird.TabIndex = 59;
            this.txtBoxThird.Tag = "Naming";
            this.txtBoxThird.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // txtBoxSecond
            // 
            this.txtBoxSecond.AutoRoundedCorners = true;
            this.txtBoxSecond.BorderColor = System.Drawing.Color.LightGray;
            this.txtBoxSecond.BorderRadius = 12;
            this.txtBoxSecond.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxSecond.DefaultText = "";
            this.txtBoxSecond.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxSecond.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxSecond.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxSecond.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxSecond.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxSecond.Font = new System.Drawing.Font("SF Pro Rounded", 9.5F, System.Drawing.FontStyle.Bold);
            this.txtBoxSecond.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxSecond.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxSecond.Location = new System.Drawing.Point(342, 90);
            this.txtBoxSecond.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxSecond.Name = "txtBoxSecond";
            this.txtBoxSecond.PlaceholderText = "";
            this.txtBoxSecond.SelectedText = "";
            this.txtBoxSecond.Size = new System.Drawing.Size(175, 27);
            this.txtBoxSecond.TabIndex = 58;
            this.txtBoxSecond.Tag = "Naming";
            this.txtBoxSecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            this.txtBoxSecond.Validating += new System.ComponentModel.CancelEventHandler(this.NullableOrEmpty_Validating);
            // 
            // txtBoxFirst
            // 
            this.txtBoxFirst.AutoRoundedCorners = true;
            this.txtBoxFirst.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxFirst.BorderColor = System.Drawing.Color.LightGray;
            this.txtBoxFirst.BorderRadius = 12;
            this.txtBoxFirst.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxFirst.DefaultText = "";
            this.txtBoxFirst.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxFirst.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxFirst.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxFirst.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxFirst.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxFirst.Font = new System.Drawing.Font("SF Pro Rounded", 9.5F, System.Drawing.FontStyle.Bold);
            this.txtBoxFirst.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxFirst.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxFirst.IconLeft = global::PresentationLayer.Properties.Resources.person;
            this.txtBoxFirst.Location = new System.Drawing.Point(142, 90);
            this.txtBoxFirst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxFirst.Name = "txtBoxFirst";
            this.txtBoxFirst.PlaceholderText = "";
            this.txtBoxFirst.SelectedText = "";
            this.txtBoxFirst.Size = new System.Drawing.Size(175, 27);
            this.txtBoxFirst.TabIndex = 57;
            this.txtBoxFirst.Tag = "Naming";
            this.txtBoxFirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            this.txtBoxFirst.Validating += new System.ComponentModel.CancelEventHandler(this.NullableOrEmpty_Validating);
            // 
            // PicPersonImage
            // 
            this.PicPersonImage.ImageRotate = 0F;
            this.PicPersonImage.Location = new System.Drawing.Point(757, 156);
            this.PicPersonImage.Name = "PicPersonImage";
            this.PicPersonImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PicPersonImage.Size = new System.Drawing.Size(150, 150);
            this.PicPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicPersonImage.TabIndex = 56;
            this.PicPersonImage.TabStop = false;
            // 
            // lblRemove
            // 
            this.lblRemove.AutoSize = true;
            this.lblRemove.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold);
            this.lblRemove.Location = new System.Drawing.Point(789, 358);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(94, 26);
            this.lblRemove.TabIndex = 54;
            this.lblRemove.TabStop = true;
            this.lblRemove.Text = "Remove";
            this.lblRemove.Visible = false;
            this.lblRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRemove_LinkClicked);
            // 
            // lblSetImage
            // 
            this.lblSetImage.AutoSize = true;
            this.lblSetImage.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold);
            this.lblSetImage.Location = new System.Drawing.Point(782, 322);
            this.lblSetImage.Name = "lblSetImage";
            this.lblSetImage.Size = new System.Drawing.Size(112, 26);
            this.lblSetImage.TabIndex = 55;
            this.lblSetImage.TabStop = true;
            this.lblSetImage.Text = "Set Image";
            this.lblSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSetImage_LinkClicked);
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(24, 281);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(106, 28);
            this.guna2HtmlLabel8.TabIndex = 38;
            this.guna2HtmlLabel8.Text = "Address";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(403, 181);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(88, 28);
            this.guna2HtmlLabel7.TabIndex = 51;
            this.guna2HtmlLabel7.Text = "Phone";
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(403, 228);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(106, 28);
            this.guna2HtmlLabel9.TabIndex = 50;
            this.guna2HtmlLabel9.Text = "Country";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(24, 237);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(77, 28);
            this.guna2HtmlLabel5.TabIndex = 49;
            this.guna2HtmlLabel5.Text = "Email";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(398, 134);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(147, 28);
            this.guna2HtmlLabel4.TabIndex = 48;
            this.guna2HtmlLabel4.Text = "Date of Birth";
            // 
            // guna2HtmlLabel13
            // 
            this.guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel13.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel13.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel13.Location = new System.Drawing.Point(24, 192);
            this.guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            this.guna2HtmlLabel13.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.guna2HtmlLabel13.Size = new System.Drawing.Size(97, 28);
            this.guna2HtmlLabel13.TabIndex = 47;
            this.guna2HtmlLabel13.Text = "Gender";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(24, 134);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(146, 28);
            this.guna2HtmlLabel3.TabIndex = 46;
            this.guna2HtmlLabel3.Text = "National No.";
            // 
            // guna2HtmlLabel15
            // 
            this.guna2HtmlLabel15.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel15.Font = new System.Drawing.Font("SF Pro Rounded", 11.2F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel15.ForeColor = System.Drawing.Color.DimGray;
            this.guna2HtmlLabel15.Location = new System.Drawing.Point(277, 194);
            this.guna2HtmlLabel15.Name = "guna2HtmlLabel15";
            this.guna2HtmlLabel15.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.guna2HtmlLabel15.Size = new System.Drawing.Size(86, 25);
            this.guna2HtmlLabel15.TabIndex = 45;
            this.guna2HtmlLabel15.Text = "Female";
            // 
            // guna2HtmlLabel14
            // 
            this.guna2HtmlLabel14.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel14.Font = new System.Drawing.Font("SF Pro Rounded", 11.2F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel14.ForeColor = System.Drawing.Color.DimGray;
            this.guna2HtmlLabel14.Location = new System.Drawing.Point(190, 194);
            this.guna2HtmlLabel14.Name = "guna2HtmlLabel14";
            this.guna2HtmlLabel14.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.guna2HtmlLabel14.Size = new System.Drawing.Size(65, 25);
            this.guna2HtmlLabel14.TabIndex = 44;
            this.guna2HtmlLabel14.Text = "Male";
            // 
            // lblPersonID
            // 
            this.lblPersonID.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonID.Font = new System.Drawing.Font("SF Pro Rounded", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPersonID.ForeColor = System.Drawing.Color.DimGray;
            this.lblPersonID.Location = new System.Drawing.Point(161, 22);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblPersonID.Size = new System.Drawing.Size(32, 21);
            this.lblPersonID.TabIndex = 43;
            this.lblPersonID.Text = "?";
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel12.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel12.ForeColor = System.Drawing.Color.DimGray;
            this.guna2HtmlLabel12.Location = new System.Drawing.Point(800, 61);
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            this.guna2HtmlLabel12.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.guna2HtmlLabel12.Size = new System.Drawing.Size(66, 28);
            this.guna2HtmlLabel12.TabIndex = 42;
            this.guna2HtmlLabel12.Text = "Last";
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel11.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel11.ForeColor = System.Drawing.Color.DimGray;
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(595, 61);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(75, 28);
            this.guna2HtmlLabel11.TabIndex = 41;
            this.guna2HtmlLabel11.Text = "Third";
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel10.ForeColor = System.Drawing.Color.DimGray;
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(388, 61);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(100, 28);
            this.guna2HtmlLabel10.TabIndex = 40;
            this.guna2HtmlLabel10.Text = "Second";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.DimGray;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(198, 61);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(67, 28);
            this.guna2HtmlLabel6.TabIndex = 39;
            this.guna2HtmlLabel6.Text = "First";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(24, 89);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(82, 28);
            this.guna2HtmlLabel2.TabIndex = 52;
            this.guna2HtmlLabel2.Text = "Name";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("SF Pro Rounded", 13.2F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(24, 19);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(119, 28);
            this.guna2HtmlLabel1.TabIndex = 53;
            this.guna2HtmlLabel1.Text = "Person ID";
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = global::PresentationLayer.Properties.Resources.gender;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(124, 191);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(30, 30);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 71;
            this.guna2PictureBox3.TabStop = false;
            // 
            // guna2PictureBox6
            // 
            this.guna2PictureBox6.Image = global::PresentationLayer.Properties.Resources.flag;
            this.guna2PictureBox6.ImageRotate = 0F;
            this.guna2PictureBox6.Location = new System.Drawing.Point(492, 227);
            this.guna2PictureBox6.Name = "guna2PictureBox6";
            this.guna2PictureBox6.Size = new System.Drawing.Size(30, 30);
            this.guna2PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox6.TabIndex = 4;
            this.guna2PictureBox6.TabStop = false;
            this.guna2PictureBox6.Click += new System.EventHandler(this.guna2PictureBox3_Click);
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
            this.btnClose.Location = new System.Drawing.Point(593, 414);
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
            this.btnSave.Location = new System.Drawing.Point(759, 414);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(158, 41);
            this.btnSave.TabIndex = 76;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddUpdatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(941, 466);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.guna2PictureBox3);
            this.Controls.Add(this.guna2PictureBox6);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.comBoxCountry);
            this.Controls.Add(this.txtBoxAddress);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxPhone);
            this.Controls.Add(this.txtBoxNationalNo);
            this.Controls.Add(this.txtBoxLast);
            this.Controls.Add(this.txtBoxThird);
            this.Controls.Add(this.txtBoxSecond);
            this.Controls.Add(this.txtBoxFirst);
            this.Controls.Add(this.PicPersonImage);
            this.Controls.Add(this.lblRemove);
            this.Controls.Add(this.lblSetImage);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.guna2HtmlLabel9);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel13);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel15);
            this.Controls.Add(this.guna2HtmlLabel14);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.guna2HtmlLabel12);
            this.Controls.Add(this.guna2HtmlLabel11);
            this.Controls.Add(this.guna2HtmlLabel10);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.dtPicDateOfBirth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdatePerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Person Form";
            this.Activated += new System.EventHandler(this.frmAddUpdatePerson_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddPerson_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddUpdatePerson_FormClosed);
            this.Load += new System.EventHandler(this.frmAddUpdatePerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicPersonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbFemale;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbMale;
        private Guna.UI2.WinForms.Guna2ComboBox comBoxCountry;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtPicDateOfBirth;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxNationalNo;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxLast;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxThird;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxSecond;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxFirst;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PicPersonImage;
        private System.Windows.Forms.LinkLabel lblRemove;
        private System.Windows.Forms.LinkLabel lblSetImage;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel15;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel14;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPersonID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox6;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
    }
}