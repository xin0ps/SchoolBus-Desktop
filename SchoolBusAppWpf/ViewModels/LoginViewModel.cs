using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using DataAccess.Repository.Abstracts;
using DataAccess.Repository.Concretes;

using Model.Concretes;
using SchoolBusAppWpf.Services;
using SchoolBusAppWpf.Views.Pages;

namespace SchoolBusAppWpf.ViewModels
{
    public  class LoginViewModel:NotificationService
    {
 
        public ICommand? LoginCommand { get; set; }

        public IBaseRepo<Admin> AdminRepo { get; set; }

        public Admin? CurrentAdmin { get; set; }

        private string? _username;

        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged();
            }
        }

        private string? _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        public LoginViewModel()
        {
            AdminRepo = new BaseRepo<Admin>();
            
           
            LoginCommand = new RelayCommand(LoginToAccount, CheckUsernameAndPassword);
        }


 
        private bool CheckUsernameAndPassword(object? parameter)
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
                return false;
            return true;
        }
        private void LoginToAccount(object? parameter)
        {
            foreach (var item in AdminRepo.GetAll())
            {
                Page p = parameter as Page;
                if (Username == item.Username && Password == item.Password)
                {
                    CurrentAdmin = item;

                    p!.NavigationService.Navigate(new NavigationSideView());
                  
                    return;
                }
            }
        }


    }
}
