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

namespace SchoolBusAppWpf.ViewModels
{
    class ParentViewModel:NotificationService
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


        private Parent _selectedItem;

        public Parent SelectedItem
        {
            get { return _selectedItem; }
            set { _selectedItem = value; OnPropertyChanged(); }
        }

      
        public ICommand? DeleteParent { get; set; }
        public ICommand? UpdateParent { get; set; }
        public BaseRepo<Parent> ParentRepo { get; set; }
        public ObservableCollection<Parent> Parents { get; set; }
        



        public ParentViewModel()
        {

            ParentRepo = new BaseRepo<Parent>();
            Parents = new ObservableCollection<Parent>(ParentRepo?.GetAll());

            UpdateParent = new RelayCommand(UpdateMethod);
            DeleteParent = new RelayCommand(DeleteMethod);
        }


        private void UpdateMethod(object? param)
        {
            if (SelectedItem != null)
            {
                try
                {
                    ParentRepo.Update(SelectedItem);
                    ParentRepo.SaveChanges();
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
                    ParentRepo.Remove(SelectedItem);
                    ParentRepo.SaveChanges();
                    Parents.Remove(SelectedItem);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
