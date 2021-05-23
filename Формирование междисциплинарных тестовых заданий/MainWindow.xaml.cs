using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using System.Linq;

namespace Формирование_междисциплинарных_тестовых_заданий
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly QuestionContext _context =
     new QuestionContext();
        private CollectionViewSource subjectViewSource;
        private CollectionViewSource questionViewSource;
        private CollectionViewSource questionAnswersViewSource;
        public MainWindow()
        {
            InitializeComponent();
            subjectViewSource =
         (CollectionViewSource)FindResource(nameof(subjectViewSource));
            questionViewSource =
                (CollectionViewSource)FindResource(nameof(questionViewSource));
            questionAnswersViewSource =
                (CollectionViewSource)FindResource(nameof(questionAnswersViewSource));
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _context.Database.EnsureCreated();
            _context.Subjects.Load();
            _context.Questions.Load();
            // bind to the source
            subjectViewSource.Source =
                _context.Subjects.Local.ToObservableCollection();
   
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            _context.SaveChanges();
            // clean up database connections
            _context.Dispose();
            base.OnClosing(e);
        }

        private void questionsDataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            //  subjectDataGrid.Items.Refresh();
            // questionsDataGrid.Items.Refresh();
            // answersDataGrid.Items.Refresh();
            //MessageBox.Show("Selection changed!");
            questionAnswersViewSource.Source =
                _context.Questions.Local.ToObservableCollection().Take<Question>(2);
            answersDataGrid.Items.Refresh();
            //MessageBox.Show("Selection changed!");
        }
    }
}
 