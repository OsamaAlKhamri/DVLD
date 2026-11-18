using DataAccessLayer;
using System;
using System.Data;

namespace BusinessLayer
{
    public class clsCountry
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public clsCountry()
        {
            this.CountryID = -1;
            this.CountryName = null;
        }

        private clsCountry(int CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
        }

        public static DataTable GetAll()
        {
            return CountriesDataAccess.GetAll();
        }
        public static clsCountry FindByCountryID(int CountryID)
        {
            string CountryName = default;
            if (CountriesDataAccess.FindByCountryID(ref CountryID, ref CountryName))
            {
                return new clsCountry(CountryID, CountryName);
            }

            return null;
        }
        public static clsCountry FindByCountryName(string CountryName)
        {
            int CountryID = default;
            if (CountriesDataAccess.FindByCountryName(ref CountryName, ref CountryID))
            {
                return new clsCountry(CountryID, CountryName);
            }
            return null;
        }
        public static bool IsExistsCountryID(int CountryID)
        {
            return CountriesDataAccess.IsExistsCountryID(CountryID);
        }
    }
}