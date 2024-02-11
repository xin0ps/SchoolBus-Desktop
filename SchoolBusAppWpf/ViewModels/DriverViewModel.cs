using DataAccess.Repository.Abstracts;
using DataAccess.Repository.Concretes;
using Model.Concretes;
using SchoolBusAppWpf.Services;
using SchoolBusAppWpf.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace SchoolBusAppWpf.ViewModels
{
    public class DriverViewModel : NotificationService
    {
        private Driver _selectedItem;

        public Driver SelectedItem
        {
            get { return _selectedItem; }
            set { _selectedItem = value; OnPropertyChanged(); }
        }
     
        public ICommand? DeleteDriver { get; set; }
        public ICommand? UpdateDriver { get; set; }
    
        public ObservableCollection<Driver> Drivers { get; set; }
        public ObservableCollection<Ride> Rides { get; set; }
        public BaseRepo<Ride> RideRepo { get; set; }
        public BaseRepo<Driver> DriverRepo { get; set; }


        public DriverViewModel()
        {
            DriverRepo = new BaseRepo<Driver>();
            RideRepo = new BaseRepo<Ride>();
            Drivers = new ObservableCollection<Driver>(DriverRepo.GetAll());
            Rides = new ObservableCollection<Ride>(RideRepo.GetAll());


            UpdateDriver = new RelayCommand(UpdateMethod);
            DeleteDriver = new RelayCommand(DeleteMethod);
        }

        private void UpdateMethod(object? PARAMETER)
        {
            if (SelectedItem != null)
            {
                try
                {
                    DriverRepo.Update(SelectedItem);
                    DriverRepo.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void DeleteMethod(object? PARAMETER)
        {
            if (SelectedItem != null)
            {
                try
                {
                    DriverRepo.Remove(SelectedItem);
                    DriverRepo.SaveChanges();
                    Drivers.Remove(SelectedItem);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }

}