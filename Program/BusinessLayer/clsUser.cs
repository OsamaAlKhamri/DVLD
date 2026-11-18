using DataAccessLayer;
using System;
using System.Data;

namespace BusinessLayer
{
    public class clsUser
    {
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public clsPerson Person
        {
            get
            {
                return clsPerson.FindByPersonID(PersonID);
            }
            set
            {
                PersonID = value.PersonID;
            }
        }
        private enum _enMode
        {
            AddNew,
            Update
        }

        private _enMode _Mode { get; set; }

        public clsUser()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = null;
            this.Password = null;
            this.IsActive = false;
            this._Mode = _enMode.AddNew;
        }

        private clsUser(int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
            this._Mode = _enMode.Update;
        }

        public static DataTable GetAll()
        {
            return UsersDataAccess.GetAll();
        }
        public static DataTable GetAllWithFullNameAndWithoutPasswords()
        {
            return UsersDataAccess.GetAllWithFullNameAndWithoutPasswords();
        }

        private bool _AddNew()
        {
            UserID = UsersDataAccess.AddNew(PersonID, UserName, Password, IsActive);
            return UserID != -1;
        }

        private bool _Update()
        {
            int RowsEffected = UsersDataAccess.Update(UserID, PersonID, UserName, Password, IsActive);
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
        public static clsUser FindByUserID(int UserID)
        {
            int PersonID = default;
            string UserName = default;
            string Password = default;
            bool IsActive = default;
            if (UsersDataAccess.FindByUserID(ref UserID, ref PersonID, ref UserName, ref Password, ref IsActive))
            {
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            }

            return null;
        }
        public static clsUser FindByPersonID(int PersonID)
        {
            int UserID = default;
            string UserName = default;
            string Password = default;
            bool IsActive = default;
            if (UsersDataAccess.FindByPersonID(ref PersonID, ref UserID, ref UserName, ref Password, ref IsActive))
            {
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            }

            return null;

        }
        public static clsUser FindByUserNameAndPassword(string UserName, string Password)
        {
            int PersonID = -1;
            int UserID = -1;
            bool IsActive = false;

            if (UsersDataAccess.FindByUserNameAndPassword(ref UserName, ref Password, ref UserID, ref PersonID, ref IsActive))
            {
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            }

            return null;

        }

        public static bool DeleteByUserID(int UserID)
        {
            int RowsEffected = UsersDataAccess.DeleteByUserID(UserID);
            return Convert.ToBoolean(RowsEffected);
        }

        public static bool IsExistsUserID(int UserID)
        {
            return UsersDataAccess.IsExistsUserID(UserID);
        }
        public static DataTable GetColumns()
        {
            return clsHelper.GetColumns("Users");
        }
    }
}