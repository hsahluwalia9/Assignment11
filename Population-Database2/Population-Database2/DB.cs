using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

/*--Group 6: Assignment 6
              Harsimar Ahluwalia
              Najam Ahmad
              Tolulope Ibiyode
              Gurpreet Kaur
              Pablo Martinez
              Maryna Salii
              Chandana Bolanthuru*/

namespace Population_Database2
{
    class DB
    {
        
        SQLiteConnection db = new SQLiteConnection("PopulationDB.db3", true);

        //Generating the average population within the database
        public decimal GetAveragePop() {
            decimal average = db.ExecuteScalar<decimal>("SELECT AVG(population) FROM city");
            return average;
        }

        //Generating the minimum population within the database
        public int GetMinimumPop()
        {
            int minimum = db.ExecuteScalar<int>("SELECT MIN(population) FROM city");
            return minimum;
        }

        //Generating the table City using the Data class
        public List<Data> GetPopulation()
        {
            List<Data> lp = new List<Data>();
            lp= db.Query<Data>("SELECT * FROM city");
            return lp;
        }

        //Query to sort rows in table City by population in descending order
        //Data is stored in the following list
        public List<Data> GetDescPopulation()
        {
            List<Data> lp = new List<Data>();
            lp = db.Query<Data>("SELECT * FROM city ORDER BY population DESC");
            return lp;
        }

        //Query to sort rows in table City by city name
        //Dats is stored in the following list
        public List<Data> GetCityAscPopulation()
        {
            List<Data> lp = new List<Data>();
            lp = db.Query<Data>("SELECT * FROM city ORDER BY city");
            return lp;
        }
    }
}


