using DataAccess.Repository.Concretes;
using Model.Concretes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SchoolBusAppWpf.Views.Pages
{
    /// <summary>
    /// Interaction logic for CreateRideView.xaml
    /// </summary>
    /// 




    public partial class CreateRideView : Page,INotifyPropertyChanged
    {



        private Student _selecteditem;

        public Student SelectedItem
        {
            get { return _selecteditem; }
            set { _selecteditem = value; OnPropertyChanged(); }
        }





        private Ride _selectedride;
       

        public Ride  SelectedRide
        {
            get { return _selectedride; }
            set { _selectedride = value; OnPropertyChanged(); }
        }




        private Student _selecteditem2;

        public Student SelectedItem2
        {
            get { return _selecteditem2; }
            set { _selecteditem2 = value; OnPropertyChanged(); }
        }




        private ObservableCollection<Ride> rides;
        public ObservableCollection<Ride> Rides { get { return rides; } 
            
            set 
            { rides = value; 
                OnPropertyChanged();
            
            } 
        
        }



        private ObservableCollection<Student> _InRideStudent;

        public ObservableCollection<Student> InRideStudents
        {
            get { return _InRideStudent; }
            set { _InRideStudent = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Student> _allstudents;

        public ObservableCollection<Student> AllStudents
        {
            get { return _allstudents; }
            set { _allstudents = value;  OnPropertyChanged(); }
        }

        public BaseRepo<Student> StudentRepo { get; set; }



        public BaseRepo<Ride> RideRepo { get; set; }
        public CreateRideView()
        {

            RideRepo = new BaseRepo<Ride>();
            Rides = new ObservableCollection<Ride>(RideRepo.GetAll());

            StudentRepo = new BaseRepo<Student>();

            AllStudents = new ObservableCollection<Student>(StudentRepo.GetAll().Where(s => s.StudentRides.Count() == 0));
            InRideStudents = new ObservableCollection<Student>();


            InitializeComponent();
            DataContext = this;

        }



        public event PropertyChangedEventHandler? PropertyChanged;
            public void OnPropertyChanged([CallerMemberName] string? propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private void Selected1(object sender, RoutedEventArgs e)
        {
            carnamelbl.Content += SelectedRide.Car.Name.ToString();
            carnumberlbl.Content += SelectedRide.Car.Number;
            fullnamelbl.Content += SelectedRide.Driver.FirstName + SelectedRide.Driver.LastName;
            maxseatslbl.Content += SelectedRide.Car.SeatCount.ToString();
            Studentsattendlbl.Content += SelectedRide.StudentRides.LongCount().ToString();

            InRideStudents = new ObservableCollection<Student>(StudentRepo.GetAll().Where(s => s.StudentRides.Any(s => s.RideId == SelectedRide.Id)));

        }

        
     private void AddClick(object sender, RoutedEventArgs e)
        {
            if (SelectedItem != null)
            {
                AllStudents.Remove(SelectedItem);
                InRideStudents.Add(SelectedItem);
                StudentRepo.SaveChanges();
            }
            else
            {
                MessageBox.Show("NUll");
            }
        }
    }
}
