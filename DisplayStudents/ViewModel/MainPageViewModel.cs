using DisplayStudents.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DisplayStudents.ViewModel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainPageViewModel"/> class.
        /// </summary>
        public MainPageViewModel()
        {
            // This would normally be returned from a business layer or service. Hard coding to make the demo code easier to understand.
            SortOrder = new List<string> { "Name", "Year In School", "Gpa" };
            SelectedSortOrder = "Name";
            Students = new ObservableCollection<StudentModel>
            {
                new StudentModel { Id = 4, Name = "Bob Clippy", YearInSchool = 10, Gpa = 2.85M },
                new StudentModel { Id = 5, Name = "Dan Dapper", YearInSchool = 11, Gpa = 3.5M },
                new StudentModel { Id = 6, Name = "Danny Senior", YearInSchool = 10, Gpa = 4.0M },
                new StudentModel { Id = 7, Name = "Hector Purdy", YearInSchool = 11, Gpa = 3.95M },
                new StudentModel { Id = 2, Name = "Jose Junior", YearInSchool = 11, Gpa = 3.82M },
                new StudentModel { Id = 8, Name = "Kim Leroux", YearInSchool = 12, Gpa = 3.67M },
                new StudentModel { Id = 9, Name = "Nikki Singh", YearInSchool = 11, Gpa = 3.85M },
                new StudentModel { Id = 3, Name = "Sammy Sophomore", YearInSchool = 10, Gpa = 3.60M },
                new StudentModel { Id = 1, Name = "Suzy Senior", YearInSchool = 12, Gpa = 4.0M },
                new StudentModel { Id = 10, Name = "Van Ng", YearInSchool = 12, Gpa = 3.67M },
            };
        }

        /// <summary>
        /// Event to fire when a property changes. Required by INotifyPropertyChange.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Private backing field for the collection of students
        /// </summary>
        private ObservableCollection<StudentModel> _students;

        /// <summary>
        /// Gets the observable collection of students
        /// </summary>
        public ObservableCollection<StudentModel> Students
        {
            get { return _students; }
            private set
            {
                _students = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(Students)));
                }
            }
        }

        /// <summary>
        /// Private backing field for the list of sort order options.
        /// </summary>
        private List<string> _sortOrder;

        /// <summary>
        /// Gets or sets the list of sort order options.
        /// </summary>
        public List<string> SortOrder
        {
            get { return _sortOrder; }
            private set
            {
                _sortOrder = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(SortOrder)));
                }
            }
        }

        /// <summary>
        /// Private backing field for the selected sort order.
        /// </summary>
        private string _selectedSortOrder;

        /// <summary>
        /// Gets or sets the selected sort order.
        /// </summary>
        public string SelectedSortOrder
        {
            get { return _selectedSortOrder; }
            set
            {
                _selectedSortOrder = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedSortOrder)));
                }
            }
        }

        /// <summary>
        /// Sort the students collection by the student's names.
        /// </summary>
        public void SortStudentsByName()
        {
            Students.Sort(s => s.Name);
        }

        /// <summary>
        /// Sort the students by the year in school.
        /// </summary>
        public void SortStudentsByYearInSchool()
        {
            Students.Sort(s => s.YearInSchool);
        }

        /// <summary>
        /// Sort the students by their GPA.
        /// </summary>
        public void SortStudentsByGpa()
        {
            Students.Sort(s => s.Gpa);
        }
    }
}
