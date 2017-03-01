using DisplayStudents.ViewModel;
using Windows.UI.Xaml.Controls;

namespace DisplayStudents.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        // This should really use DI for dependencies, creating object directly to make the demo simpler
        private MainPageViewModel _viewModel = new MainPageViewModel();

        /// <summary>
        /// Initializes a new instance of the <see cref="MainPage"/> class.
        /// </summary>
        public MainPage()
        {
            this.InitializeComponent();

            this.DataContext = _viewModel;
        }

        /// <summary>
        /// When the selected item to sort on changes resort the list.
        /// </summary>
        /// <param name="sender">The combobox with the sort options.</param>
        /// <param name="e">A SelectionChangedEventArgs with information about the change.</param>
        private void SortComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selection = (string)((ComboBox)sender).SelectedValue;
            if (selection == "Name")
            {
                _viewModel.SortStudentsByName();
            }

            if (selection == "Year In School")
            {
                _viewModel.SortStudentsByYearInSchool();
            }

            if (selection == "Gpa")
            {
                _viewModel.SortStudentsByGpa();
            }
        }
    }
}
