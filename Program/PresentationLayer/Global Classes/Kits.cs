using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PresentationLayer
{

    static internal class clsValidating
    {
        public enum enTypes
        {
            None,
            Integer,
            Dec,
            Email,
            Phone,
            FullNaming,
            Naming,
            String,
            StringWithWhiteSpace,
            Password,
            Date,
            DateTime,
            Combo,
        }

        static ErrorProvider errorProvider = new ErrorProvider();
        public static bool isNull(string str) => str == null;
        public static bool isEmpty(string str) => str == string.Empty;
        public static bool isNullOrEmpty(string str) => isNull(str) || isEmpty(str);
        public static bool isEmail(string str) => str.EndsWith("@gmail.com");
        public static bool NullableOrEmpty_Validating(object sender, CancelEventArgs e)
        {
            Control ctrl = sender as Control;
            if (!clsValidating.isNullOrEmpty(ctrl.Text.Trim()))
            {
                errorProvider.SetError(ctrl, "");
                return false;
            }

            errorProvider.SetError(ctrl, "this field is required.");
            return true;
        }
        public static bool Similar_Validating(object sender, CancelEventArgs e,
            Predicate<object> isSimilar, string message)
        {
            Control ctrl = sender as Control;
            if (isSimilar(ctrl.Text))
            {
                errorProvider.SetError(ctrl, "");
                return false;
            }
            else
            {
                errorProvider.SetError(ctrl, message);
                return true;
            }

        }
        public static bool IsExists_Validating(object sender, CancelEventArgs e, Predicate<object> isExists)
        {
            Control ctrl = sender as Control;
            if (!clsValidating.NullableOrEmpty_Validating(sender, e) && !isExists(ctrl.Text))
            {
                errorProvider.SetError(ctrl, "");
                return false;
            }
            else
            {
                errorProvider.SetError(ctrl, "This National No is found.");
                return true;
            }
        }
        public static bool Email_Validating(object sender, CancelEventArgs e)
        {
            Control ctrl = sender as Control;

            if (clsValidating.isEmail(ctrl.Text))
            {
                errorProvider.SetError(ctrl, "");
                return true;
            }

            errorProvider.SetError(ctrl, "this email is not valid.");
            return false;
        }
        public static void Clear_Validating(Control ctrl) => errorProvider.SetError(ctrl, "");
        public static void Set_Validating(Control ctrl, string message) => errorProvider.SetError(ctrl, message);
        public static bool IsAcceptableType(char Code, enTypes type)
        {
            if (char.IsControl(Code)) return true;

            bool isAcceptable = false;
            switch (type)
            {
                case enTypes.None:
                    isAcceptable = true;
                    break;
                case enTypes.Integer:
                    isAcceptable = char.IsDigit(Code);
                    break;
                case enTypes.Dec:
                    isAcceptable = char.IsNumber(Code) || Code == '.';
                    break;
                case enTypes.Naming:
                    isAcceptable = char.IsLetter(Code) || Code == '-';
                    break;
                case enTypes.FullNaming:
                    isAcceptable = char.IsLetter(Code) || char.IsWhiteSpace(Code) || Code == '-';
                    break;
                case enTypes.Email:
                    isAcceptable = char.IsLetterOrDigit(Code) || "@.".Contains(Code);
                    break;
                case enTypes.Password:
                    isAcceptable = char.IsLetterOrDigit(Code) || char.IsSymbol(Code);
                    break;
                case enTypes.String:
                    isAcceptable = char.IsLetterOrDigit(Code);
                    break;
                case enTypes.StringWithWhiteSpace:
                    isAcceptable = char.IsLetterOrDigit(Code) || char.IsWhiteSpace(Code);
                    break;
                case enTypes.Date:
                    isAcceptable = char.IsDigit(Code) || Code == '/';
                    break;
                case enTypes.DateTime:
                    isAcceptable = char.IsDigit(Code) || Code == '/' || Code == ':';
                    break;
                case enTypes.Phone:
                    isAcceptable = char.IsDigit(Code) || Code == '+' || Code == '(' || Code == ')';
                    break;
            }
            return isAcceptable;
        }
    }
    class clsField
    {
        public string Name
        {
            get;
            set;
        }
        public clsValidating.enTypes ValidatingType
        {
            get;
            set;
        }
        public clsFilter.enColumnType FilterType
        {
            get;
            set;
        }

        public bool filterExactValue;
        public clsField(string name, clsValidating.enTypes validatingType, clsFilter.enColumnType filterType, bool filterExactValue = false)
        {
            Name = name;
            ValidatingType = validatingType;
            FilterType = filterType;
            this.filterExactValue = filterExactValue;
        }
    }
    class clsFilter
    {
        public DataView MainTable;
        public class Field
        {
            public string Column;
            public enColumnType Type;
            public bool FilterExactValue;
            public Field(string column, enColumnType type, bool filterExactValue = false)
            {
                Column = column;
                Type = type;
                FilterExactValue = filterExactValue;
            }
        }

        private Field _SelectedFiled;
        public Field SelectedFiled
        {
            get
            {
                return _SelectedFiled;
            }
            set
            {
                _SelectedFiled = value;
                CurrentValue = null;
                Filtering();
            }
        }

        public object _CurrentValue = null;
        public object CurrentValue
        {
            set
            {
                _CurrentValue = value;
                Filtering();
            }
            get
            {
                return _CurrentValue;
            }
        }

        public Action RefreshDataView;
        public enum enColumnType
        {
            None,
            Number,
            String,
            DateTime,
        }
        public clsFilter(DataView mainTable)
        {
            MainTable = mainTable;
        }
        public void Filtering()
        {
            if (clsValidating.isNullOrEmpty(CurrentValue?.ToString()) || SelectedFiled.Type == enColumnType.None) MainTable.RowFilter = null;
            else
                MainTable.RowFilter = GetFilterExpression();
        }
        string GetFilterExpression()
        {
            string statement = null;
            switch (SelectedFiled?.Type)
            {
                case enColumnType.None:
                    statement = null;
                    break;
                case enColumnType.Number:
                    statement = $"[{SelectedFiled.Column}] = {CurrentValue}";
                    break;
                case enColumnType.DateTime:
                    statement = $"CONVERT([{SelectedFiled.Column}], string) LIKE '%{CurrentValue}%'";
                    break;
                case enColumnType.String:
                    if(SelectedFiled.FilterExactValue)
                    statement = $"[{SelectedFiled.Column}] = '{CurrentValue}'";
                    else
                    statement = $"[{SelectedFiled.Column}] LIKE '%{CurrentValue}%'";
                    break;
            }

            return statement;

        }
    }
    class clsImage
    {
        static public Image LoadImageToMemory(string path)
        {
            if (File.Exists(path))
            {
                using (FileStream imageStream = new FileStream(path,
                    FileMode.Open, FileAccess.Read))
                {
                    MemoryStream imageMemoryStream = new MemoryStream();
                    imageStream.CopyTo(imageMemoryStream);
                    imageMemoryStream.Seek(0, SeekOrigin.Begin);
                    return Image.FromStream(imageMemoryStream);
                }
            }
            return null;

        }
    }

}

