using Model.Concretes;
using SchoolBusAppWpf.Services;
using SchoolBusAppWpf.Views.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace SchoolBusAppWpf.ViewModels
{
    public class NavigationViewModel:NotificationService
    {

        public Page CurrentView { get; set; }
        public ICommand? CreateRideCommand { get; set; }
        public ICommand? RidesCommand { get; set; }
        public ICommand? ClassCommand { get; set; }
        public ICommand? CarCommand { get; set; }
        public ICommand? DriverCommand { get; set; }
        public ICommand? ParentCommand { get; set; }
        public ICommand? StudentCommand { get; set; }
    
        public ICommand? LogOutCommand { get; set; }
        public NavigationViewModel() {



            CurrentView = new RideView();
            CreateRideCommand = new RelayCommand(NavigateToCreateRidePage);
            RidesCommand = new RelayCommand(NavigateToRidesPage);
            ClassCommand = new RelayCommand(NavigateToClassPage);
            CarCommand = new RelayCommand(NavigateToCarsPage);
            DriverCommand = new RelayCommand(NavigateToDriversPage);
            ParentCommand = new RelayCommand(NavigateToParentsPage);
            StudentCommand = new RelayCommand(NavigateToStudentsPage);


        }

        private void NavigateToStudentsPage(object? obj)
        {
            Page p = obj as Page;
            p.NavigationService.Navigate(new StudentView());
        }

        private void NavigateToParentsPage(object? obj)
        {
            Page p = obj as Page;
            p.NavigationService.Navigate(new ParentView());
        }

        private void NavigateToDriversPage(object? obj)
        {
            Page p = obj as Page;
            p.NavigationService.Navigate(new DriverView());
        }

        private void NavigateToCarsPage(object? obj)
        {
            Page p = obj as Page;
            p.NavigationService.Navigate(new CarView());
        }

        private void NavigateToClassPage(object? obj)
        {
            Page p = obj as Page;
            p.NavigationService.Navigate(new ClassView());
        }

        private void NavigateToRidesPage(object? obj)
        {
            Page p = obj as Page;
            p.NavigationService.Navigate(new RideView());
        }

        private void NavigateToCreateRidePage(object? obj)
        {
            Page p = obj as Page;
            p.NavigationService.Navigate(new CreateRideView());
        }
    }
}
