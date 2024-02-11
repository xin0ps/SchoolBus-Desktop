using Model.Concretes;
using SchoolBusAppWpf.Services;
using SchoolBusAppWpf.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using DataAccess.Repository.Concretes;
using Castle.Core.Internal;

namespace SchoolBusAppWpf.ViewModels
{
 public   class CarViewModel:NotificationService
    {

        private string _search;

        public string Search
        {
            get { return _search; }
            set { _search = value;
                OnPropertyChanged();
                SearchMethod();
            }
        }


        private Car _selectedItem;

        public Car SelectedItem
        {
            get { return _selectedItem; }
            set { _selectedItem = value; OnPropertyChanged(); }
        }
       
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }
        }
        private string _number;

        public string Number
        {
            get { return _number; }
            set { _number = value; OnPropertyChanged(); }
        }
        private string _seatCount;

        public string SeatCount
        {
            get { return _seatCount; }
            set { _seatCount = value; OnPropertyChanged(); }
        }
        public CreateCarWindow CreateWindow { get; set; }
        public ICommand? DeleteCar { get; set; }
        public ICommand? UpdateCar { get; set; }
  


        private ObservableCollection<Car> _cars;

        public ObservableCollection<Car> Cars
        {
            get { return _cars; }
            set { _cars = value; OnPropertyChanged(); }
        }

  
        public ObservableCollection<Ride> Rides { get; set; }
        public BaseRepo<Car> CarsRepo { get; set; }
        public BaseRepo<Ride> RidesRepo { get; set; }

        public CarViewModel()
        {
           
            CarsRepo = new BaseRepo<Car>();
            RidesRepo = new BaseRepo<Ride>();
            Rides = new ObservableCollection<Ride>(RidesRepo.GetAll());
            Cars = new ObservableCollection<Car>(CarsRepo.GetAll());

           
            DeleteCar = new RelayCommand(DeleteMethod);
            UpdateCar = new RelayCommand(UpdateMethod);
           
        }




        private void SearchMethod()
        {
            var searchcars = Cars.Where(c => c.Name.IndexOf(_search, StringComparison.OrdinalIgnoreCase) >= 0);
            if (!searchcars.IsNullOrEmpty() && !_search.IsNullOrEmpty())
            {
                Cars = new ObservableCollection<Car>(searchcars);
            }
            else
            {
                Cars = new ObservableCollection<Car>(CarsRepo.GetAll());
            }
        }

        private void UpdateMethod(object? param)
        {
            if (SelectedItem != null)
            {
                try
                {
                    CarsRepo.Update(SelectedItem);
                    CarsRepo.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void DeleteMethod(object? param)
        {
            if (SelectedItem != null)
            {
                try
                {
                    CarsRepo.Remove(SelectedItem);
                    CarsRepo.SaveChanges();
                    Cars.Remove(SelectedItem);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



    }
}
