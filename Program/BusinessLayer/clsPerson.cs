using DataAccessLayer;
using System;
using System.Data;

namespace BusinessLayer
{
    public class clsPerson
    {
        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public short Gendor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + SecondName + " " + ThirdName + " " + LastName;
            }
        }
        public clsCountry Country
        {
            get;
            set;
        }
        private enum _enMode
        {
            AddNew,
            Update
        }
        private _enMode _Mode { get; set; }
        public clsPerson()
        {
            this.PersonID = -1;
            this.FirstName = "";
            this.NationalNo = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationalityCountryID = -1;
            this.ImagePath = "";

            this._Mode = _enMode.AddNew;
        }
        private clsPerson(int PersonID, string NationalNo, string FirstName,
            string SecondName, string ThirdName, string LastName,
            DateTime DateOfBirth, short Gendor, string Address,
            string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            Country = clsCountry.FindByCountryID(NationalityCountryID);
            this.ImagePath = ImagePath;
            this._Mode = _enMode.Update;
        }
        public static DataTable GetAll()
        {
            return clsPersonData.GetAll();
        }
        public static DataTable GetAllWithoutImagePath()
        {
            return clsPersonData.GetAllWithoutImagePath();
        }
        private bool _AddNew()
        {
            PersonID = clsPersonData.AddNew(NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, 
                Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            return PersonID != -1;
        }
        private bool _Update()
        {
            int RowsEffected = clsPersonData.Update(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
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
        public static clsPerson FindByPersonID(int PersonID)
        {
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", NationalNo = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            int NationalityCountryID = -1;
            short Gendor = 0;
            if (clsPersonData.FindByPersonID(ref PersonID, ref NationalNo, ref FirstName, 
                ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, 
                    DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            }

            return null;
        }
        public static clsPerson FindByNationalNo(string NationalNo)
        {
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            int PersonID = -1, NationalityCountryID = -1;
            short Gendor = 0;
            if (clsPersonData.FindByNationalNo(ref NationalNo, ref PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, 
                    Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            }

            return null;
        }
        public static bool DeleteByPersonID(int PersonID)
        {
            int RowsEffected = clsPersonData.DeleteByPersonID(PersonID);
            return Convert.ToBoolean(RowsEffected);
        }
        public static bool IsExistsPersonID(int PersonID)
        {
            return clsPersonData.IsExistsPersonID(PersonID);
        }
        public static DataTable GetColumns()
        {
            return clsHelper.GetColumns("People");
        }

    }
}