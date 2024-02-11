using Castle.Core.Internal;
using DataAccess.Repository.Concretes;
using Model.Concretes;
using SchoolBusAppWpf.Services;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace SchoolBusAppWpf.ViewModels.WindowsViewModels
{
    public class CreateStudentWindowModel:NotificationService
    {

        private Parent _selectedParent;

        public Parent SelectedParent
        {
            get { return _selectedParent; }
            set { _selectedParent = value;
            OnPropertyChanged();
            }
        }


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

        private Class _classid;
        public Class ClassId
        {
            get { return _classid; }
            set
            {
                _classid = value;
                OnPropertyChanged();
            }
        }

        private string _address1;
        public string Address1
        {
            get { return _address1; }
            set
            {
                _address1 = value;
                OnPropertyChanged();
            }
        }

        private string _address2;
        public string Address2
        {
            get { return _address2; }
            set
            {
                _address2 = value;
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



        public ObservableCollection<Student> Students { get; set; }
        public BaseRepo<Student> StudentsRepo { get; set; }
       public ICommand AddStudent { get; set; }
        public  BaseRepo<Parent> ParentRepo { get; set; }
        public  BaseRepo<Class> ClassRepo { get; set; }

        public ObservableCollection<Parent> Parents { get; set; }

        public ObservableCollection<Class> Classes { get; set; }

        public Student Student { get; set; }

        public CreateStudentWindowModel()
        {

            Student = new Student();
            StudentsRepo=new BaseRepo<Student>();
            Students= new ObservableCollection<Student>(StudentsRepo.GetAll());  
            ParentRepo=new BaseRepo<Parent>();
            ClassRepo=new BaseRepo<Class>();
            Classes=new ObservableCollection<Class>(ClassRepo.GetAll());
            Parents=new ObservableCollection<Parent>(ParentRepo.GetAll());
            AddStudent = new RelayCommand(AddCommand,Check);
        }

        private bool Check(object? param)
        {
            if(string.IsNullOrEmpty(_firstname) || string.IsNullOrEmpty(_lastname)  ) return false;
            return true;
        }

        private void AddCommand(object? param)
        {
            ParentStudent ps = new ParentStudent();
            ps.ParentId=SelectedParent.Id;
            
            Student = new ();
            Student.ParentStudents=new List<ParentStudent>();
            Student.ParentStudents.Add(ps);
            Student.FirstName = _firstname;
            Student.LastName = _lastname;
            Student.Address1 = _address1;
            Student.Address2 = _address2;
            Student.ClassId = _classid.Id;
            Student.Username = _username;
            Student.Password = _password;

            StudentsRepo.Add(Student);
            StudentsRepo.SaveChanges();

            MessageBox.Show("Succesfully Added");

            Window w = param as Window;
            w.Close();
          


        }


    }
}
