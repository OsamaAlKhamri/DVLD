using DataAccessLayer;
using System;
using System.ComponentModel;
using System.Data;

namespace BusinessLayer
{
    public class clsTestType
    {
        public enTestType ID { get; set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public decimal TestTypeFees { get; set; }

        public enum enTestType
        {
            [Description("Vision Test")]
            VisionTest = 1, 
            [Description("Written Test")]
            WrittenTest, 
            [Description("Street Test")]
            StreetTest
        }
        private enum _enMode
        {
            AddNew,
            Update
        }
        private _enMode _Mode { get; set; }

        public clsTestType()
        {
            this.ID = enTestType.VisionTest;
            this.TestTypeTitle = default;
            this.TestTypeDescription = default;
            this.TestTypeFees = default;
            this._Mode = _enMode.AddNew;
        }

        private clsTestType(enTestType TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)
        {
            this.ID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDescription = TestTypeDescription;
            this.TestTypeFees = TestTypeFees;
            this._Mode = _enMode.Update;
        }

        public static DataTable GetAll()
        {
            return TestTypeDataAccess.GetAll();
        }

        private bool _AddNew()
        {
            ID = (enTestType)TestTypeDataAccess.AddNew(TestTypeTitle, TestTypeDescription, TestTypeFees);
            return ((int)ID) != -1;
        }

        private bool _Update()
        {
            int RowsEffected = TestTypeDataAccess.Update((int)ID, TestTypeTitle, TestTypeDescription, TestTypeFees);
            return Convert.ToBoolean(RowsEffected);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case _enMode.AddNew:
                    if (_AddNew())
                    {
                        _Mode = _enMode.Update;
                        return true;
                    }

                    return false;
                case _enMode.Update:
                    return _Update();
            }
            return false;

        }

        public static clsTestType FindByTestTypeID(enTestType ID)
        {
            string TestTypeTitle = default;
            string TestTypeDescription = default;
            decimal TestTypeFees = default;
            if (TestTypeDataAccess.FindByTestTypeID((int)ID, ref TestTypeTitle, ref TestTypeDescription, ref TestTypeFees))
            {
                return new clsTestType((enTestType)ID, TestTypeTitle, TestTypeDescription, TestTypeFees);
            }

            return null;
        }

    }
}