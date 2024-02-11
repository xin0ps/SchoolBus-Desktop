using DataAccess.Repository.Concretes;
using Model.Concretes;
using SchoolBusAppWpf.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace SchoolBusAppWpf.ViewModels.WindowsViewModels
{
    public class CreateClassWindowModel:NotificationService
    {
        public BaseRepo<Class> Classes { get; set; }

        public ICommand CreateClass { get; set; }

        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }


        public CreateClassWindowModel()
        {
            Classes = new BaseRepo<Class>();

            CreateClass = new RelayCommand(CreateMethod, Check);

        }

        private bool Check(object? parameter)
        {
            if (string.IsNullOrEmpty(_name)) return false;
            return true;
        }

        private void CreateMethod(object? parameter)

        {

            Window w = parameter as Window;
            Class cs = new();
            cs.Name = _name;
            Classes.Add(cs);
            Classes.SaveChanges();
            MessageBox.Show("Succesfully Added");
            w.Close();


        }

    }
}
