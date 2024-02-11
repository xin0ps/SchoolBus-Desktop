using Model.Concretes;
using SchoolBusAppWpf.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using DataAccess.Repository.Concretes;

namespace SchoolBusAppWpf.ViewModels
{
  public  class RideViewModel:NotificationService
    {

        private string _search;

        public string Search
        {
            get { return _search; }
            set
            {
                _search = value;
                OnPropertyChanged();
               // SearchMethod();
            }
        }


        private Ride _selectedItem;

            public Ride SelectedItem
            {
                get { return _selectedItem; }
                set { _selectedItem = value; OnPropertyChanged(); }
            }
            public ObservableCollection<Ride> Rides { get; set; }
            public BaseRepo<Ride> RidesRepo { get; set; }

            public ICommand? DeleteRide { get; set; }
            public RideViewModel()
            {
                RidesRepo = new BaseRepo<Ride>();


                Rides = new ObservableCollection<Ride>(RidesRepo?.GetAll());

                DeleteRide = new RelayCommand(DeleteMethod);
            }

            private void DeleteMethod(object? param)
            {
                if (SelectedItem != null)
                {
                    try
                    {
                        RidesRepo.Remove(SelectedItem);
                        RidesRepo.SaveChanges();
                        Rides.Remove(SelectedItem);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

        }
    }
