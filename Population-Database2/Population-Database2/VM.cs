using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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
    class VM: INotifyPropertyChanged
    {
        DB db = new DB();

        
        ObservableCollection<Data> _cityList = new ObservableCollection<Data>();

        //Creating a list that will be binded with the listbox in xaml
        public ObservableCollection<Data> CityList {
            get { return _cityList; }
            set { _cityList = value; OnPropertyChanged(); }
        }

        //variable to store average population binded within xaml
        private decimal _avgPopulation;
        public decimal AvgPopulation
        {
            get { return _avgPopulation; }
            set { _avgPopulation = value;  OnPropertyChanged(); }
        }

        //variable to store minimum population binded within xaml
        private int _minPopulation;
        public int MinPopulation
        {
            get { return _minPopulation; }
            set { _minPopulation = value; OnPropertyChanged(); }
        }

        //Method to output the table City in xaml
        public void getData() {
            List<Data> lp = new List<Data>();
            lp=db.GetPopulation();
            foreach (Data d in lp)
            {
                Data dt = new Data();
                dt.City = d.City;
                dt.Population = d.Population;
                _cityList.Add(dt);
            }
        }

        //Method to output the sorted table by population in xaml
        public void SortPopulationDesc()
        {
            List<Data> lp = new List<Data>();
            lp = db.GetDescPopulation();
            foreach (Data d in lp)
            {
                Data dt = new Data();
                dt.City = d.City;
                dt.Population = d.Population;
                _cityList.Add(dt);
            }
        }

        //Method to output the sorted table by city in xaml
        public void SortPopulationCity()
        {
            List<Data> lp = new List<Data>();
            lp = db.GetCityAscPopulation();
            foreach (Data d in lp)
            {
                Data dt = new Data();
                dt.City = d.City;
                dt.Population = d.Population;
                _cityList.Add(dt);
            }
        }
        
        //Method to run the get average query in DB class and store it within the local variable
        public void StorePopulationAvg()
        {
            _avgPopulation = db.GetAveragePop();
        }

        //Method to run the get minimum query in DB class and store it within the local variable
        public void StorePopulationMin()
        {
            _minPopulation = db.GetMinimumPop();
        }

        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string caller = null)
        {

            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(caller));
            }
        }
        #endregion
    }
}
