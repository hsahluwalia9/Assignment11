using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VM vm;
        public MainWindow()
        {
            InitializeComponent();
            vm = new VM();
            DataContext = vm;
            vm.getData();
            vm.StorePopulationAvg();
            vm.StorePopulationMin();
        }
        private void BtnSortPopDesc_Click(object sender, RoutedEventArgs e)
        {
            vm.CityList.Clear();
            vm.SortPopulationDesc();
        }
        private void BtnSortCityName_Click(object sender, RoutedEventArgs e)
        {
            vm.CityList.Clear();
            vm.SortPopulationCity();
        }
    }
}