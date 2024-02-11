using DataAccess.Repository.Concretes;
using Model.Concretes;
using SchoolBusAppWpf.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace SchoolBusAppWpf.ViewModels.WindowsViewModels
{
    public class CreateParentWindowModel :NotificationService
    {

        private Parent _selectedParent;

        public Parent SelectedParent
        {
            get { return _selectedParent; }
            set
            {
                _selectedParent = value;
                OnPropertyChanged();
            }
        }


        private string _firstname;

        public string FirstName
        {
            get { return _firstname; }
            set
            {
                _firstname = value;
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




        //=======================//




      public  Parent parent { get; set; }
        public ICommand AddParent { get; set; }
        public BaseRepo<Parent> ParentRepo { get; set; }
      

        public ObservableCollection<Parent> Parents { get; set; }

      

        public CreateParentWindowModel()
        {

            parent = new Parent();
           
            ParentRepo = new BaseRepo<Parent>();
     
            Parents = new ObservableCollection<Parent>(ParentRepo.GetAll());
            AddParent = new RelayCommand(AddCommand, Check);
        }

        private bool Check(object? param)
        {
            if (string.IsNullOrEmpty(_firstname) || string.IsNullOrEmpty(_lastname) || string.IsNullOrEmpty(_phone) || string.IsNullOrEmpty(_username) || string.IsNullOrEmpty(_password)) return false;
            return true;
        }

        private void AddCommand(object? param)
        {


            parent = new();
            parent.FirstName = _firstname;
            parent.LastName = _lastname;
            parent.Username = _username;
            parent.Password = _password;
            parent.Phone = _phone;

            ParentRepo.Add(parent);
            ParentRepo.SaveChanges();
            Parents.Add(parent);

            MessageBox.Show("Succesfully Added");

            Window w = param as Window;
            w.Close();

        }
    }
}
