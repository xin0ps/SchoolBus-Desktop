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
using System.Windows.Input;
using System.Windows;
using System.Windows.Navigation;

namespace SchoolBusAppWpf.ViewModels
{
   public class ClassViewModel: NotificationService
    {
        private Class _selectedItem;

        public Class SelectedItem
        {
            get { return _selectedItem; }
            set { _selectedItem = value; OnPropertyChanged(); }
        }
       
        public ICommand? DeleteClass { get; set; }
        public ICommand? UpdateClass { get; set; }

        public ObservableCollection<Class> Classes { get; set; }
        public ObservableCollection<Student> Students { get; set; }
        public BaseRepo<Student> StudentRepo { get; set; }
        public BaseRepo<Class> ClassRepo { get; set; }


        public ClassViewModel()
        {
            ClassRepo = new BaseRepo<Class>();
           StudentRepo = new BaseRepo<Student>();
            Classes = new ObservableCollection<Class>(ClassRepo.GetAll());
            Students = new ObservableCollection<Student>(StudentRepo.GetAll());


            UpdateClass = new RelayCommand(UpdateMethod);
            DeleteClass = new RelayCommand(DeleteMethod);
        }

        private void UpdateMethod(object? PARAMETER)
        {
            if (SelectedItem != null)
            {
                try
                {
                    ClassRepo.Update(SelectedItem);
                    ClassRepo.SaveChanges();
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
                    ClassRepo.Remove(SelectedItem);
                    ClassRepo.SaveChanges();
                    Classes.Remove(SelectedItem);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
