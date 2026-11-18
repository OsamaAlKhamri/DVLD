using DataAccessLayer;
using System;
using System.Data;

namespace BusinessLayer
{
    public class clsLicenseClass
    {
        public int LicenseClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public System.Byte MinimumAllowedAge { get; set; }
        public System.Byte DefaultValidityLength { get; set; }
        public decimal ClassFees { get; set; }

        private enum _enMode
        {
            AddNew,
            Update
        }

        private _enMode _Mode { get; set; }

        public clsLicenseClass()
        {
            this.LicenseClassID = default;
            this.ClassName = default;
            this.ClassDescription = default;
            this.MinimumAllowedAge = default;
            this.DefaultValidityLength = default;
            this.ClassFees = default;
            this._Mode = _enMode.AddNew;
        }

        private clsLicenseClass(int LicenseClassID, string ClassName, string ClassDescription, System.Byte MinimumAllowedAge, System.Byte DefaultValidityLength, decimal ClassFees)
        {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;
            this._Mode = _enMode.Update;
        }

        public static DataTable GetAll()
        {
            return LicenseClassesDataAccess.GetAll();
        }

        private bool _AddNew()
        {
            LicenseClassID = LicenseClassesDataAccess.AddNew(ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            return LicenseClassID != -1;
        }

        private bool _Update()
        {
            int RowsEffected = LicenseClassesDataAccess.Update(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
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

        public static clsLicenseClass FindByLicenseClassID(int LicenseClassID)
        {
            string ClassName = default;
            string ClassDescription = default;
            System.Byte MinimumAllowedAge = default;
            System.Byte DefaultValidityLength = default;
            decimal ClassFees = default;
            if (LicenseClassesDataAccess.FindByLicenseClassID(ref LicenseClassID, ref ClassName, ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))
            {
                return new clsLicenseClass(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            }

            return null;
        }

        public static bool DeleteByLicenseClassID(int LicenseClassID)
        {
            int RowsEffected = LicenseClassesDataAccess.DeleteByLicenseClassID(LicenseClassID);
            return Convert.ToBoolean(RowsEffected);
        }

        public static bool IsExistsLicenseClassID(int LicenseClassID)
        {
            return LicenseClassesDataAccess.IsExistsLicenseClassID(LicenseClassID);
        }
    }
}