using Model.Concretes;
using SchoolBusAppWpf.Services;
using SchoolBusAppWpf.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using DataAccess.Repository.Concretes;

namespace SchoolBusAppWpf.ViewModels
{
   public class StudentViewModel:NotificationService
    {
        private Student _selectedItem;

        public Student SelectedItem
        {
            get { return _selectedItem; }
            set { _selectedItem = value; OnPropertyChanged(); }
        }

        private Class _selectedClass;

        public Class SelectedClass
        {
            get { return _selectedClass; }
            set { _selectedClass = value; OnPropertyChanged(); }
        }
        public ICommand? DeleteStudent { get; set; }
        public ICommand? UpdateStudent { get; set; }
        public BaseRepo<Student> StudentsRepo { get; set; }
        public ObservableCollection<Student> Students { get; set; }
        public BaseRepo<Ride> RideRepo { get; set; }
        public ObservableCollection<Ride> Rides { get; set; }
        public BaseRepo<Parent> ParentsRepo { get; set; }
        public ObservableCollection<Parent> Parents { get; set; }
        public BaseRepo<Class> ClassRepo { get; set; }
        public ObservableCollection<Class> CLasses { get; set; }



        public StudentViewModel()
        {
          
            StudentsRepo = new BaseRepo<Student>();
            Students = new ObservableCollection<Student>(StudentsRepo?.GetAll());
            ParentsRepo = new BaseRepo<Parent>();
            Parents = new ObservableCollection<Parent>(ParentsRepo?.GetAll());
            RideRepo = new BaseRepo<Ride>();
            Rides = new ObservableCollection<Ride>(RideRepo.GetAll());

            UpdateStudent = new RelayCommand(UpdateMethod);
            DeleteStudent = new RelayCommand(DeleteMethod);
        }

     
        private void UpdateMethod(object? param)
        {
            if (SelectedItem != null)
            {
                try
                {
                    StudentsRepo.Update(SelectedItem);
                    StudentsRepo.SaveChanges();
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
                    StudentsRepo.Remove(SelectedItem);
                    StudentsRepo.SaveChanges();
                    Students.Remove(SelectedItem);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


       

    }
}
