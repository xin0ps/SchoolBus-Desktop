using DataAccess.Repository.Concretes;
using Model.Concretes;
using SchoolBusAppWpf.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace SchoolBusAppWpf.ViewModels.WindowsViewModels
{
    public class CreateCarWindowModel : NotificationService
    {

        
        public ICommand? CreateCar { get; set; }

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

        private int _seatCount;

        public int SeatCount
        {
            get { return _seatCount; }
            set { _seatCount = value; OnPropertyChanged(); }
        }

        private Car _car;

        public Car NewCar
        {
            get { return _car; }
            set
            {
                _car = value;
                OnPropertyChanged();
            }
        }

        public CreateCarWindowModel()
        {
            CreateCar = new RelayCommand(AddNewCar, Check);
        }

        private void AddNewCar(object? param)
        {
            BaseRepo<Car> carRepository = new BaseRepo<Car>();
            NewCar = new() { 
                Name = Name, 
                Number = Number, 
                SeatCount = SeatCount, 
                Rides = new List<Ride>()
            };
            carRepository.Add(NewCar);
            MessageBox.Show("Succesfully Added!");

            Window w = param as Window;
            w.Close();
        }

        private bool Check(object? param)
        {
            if (!string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Number) && SeatCount > 0)
            {
                return true;
            }
            return false;
        }
    }
}
