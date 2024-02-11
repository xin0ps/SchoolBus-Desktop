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
    public class CreateDriverViewModel:NotificationService
    {
        public BaseRepo<Driver> Drivers { get; set; }

        public ICommand CreateDriver { get; set; }

        private string _firstname;

        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value;
                    OnPropertyChanged(); 
                }
        }


        private string _lastname;

        public string LastName
        {
            get { return _lastname; }
            set
            {
                _lastname = value;
                OnPropertyChanged();
            }
        }


        private string _phone;

        public string Phone
        {
            get { return _phone; }
            set
            {
                _phone = value;
                OnPropertyChanged();
            }
        }


        private string _homeaddress;

        public string HomeAdress
        {
            get { return _homeaddress; }
            set
            {
                _homeaddress = value;
                OnPropertyChanged();
            }
        }


        private string _license;

        public string License
        {
            get { return _license; }
            set
            {
                _license = value;
                OnPropertyChanged();
            }
        }


        private string _username;

        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged();
            }
        }



        private string _password;

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        public CreateDriverViewModel()
        {
            Drivers = new BaseRepo<Driver>();

            CreateDriver = new RelayCommand(CreateMethod,Check);
            
        }

        private bool Check(object? parameter)
        {
            if (string.IsNullOrEmpty(_firstname)|| string.IsNullOrEmpty(_lastname) || string.IsNullOrEmpty(_phone) || string.IsNullOrEmpty(_homeaddress) || string.IsNullOrEmpty(License) || string.IsNullOrEmpty(_username) || string.IsNullOrEmpty(_password) ) return false;
            return true;
        }

        private void CreateMethod(object? parameter)
            
             {
            Window w=parameter as Window;
            Driver driver = new();
            driver.FirstName = _firstname;
            driver.LastName= _lastname;
            driver.Phone= _phone;
            driver.Password= _password; 
            driver.Username= _username;
            driver.HomeAddress= _homeaddress;
            driver.License= _license;
            Drivers.Add(driver);
            Drivers.SaveChanges();
            MessageBox.Show("Succesfully Added");
            w.Close(); 
           

        }
            
    }
}
