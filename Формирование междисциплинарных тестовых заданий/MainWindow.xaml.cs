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
        private CollectionViewSource subjectsViewSource;
        private CollectionViewSource answersViewSource;
        public MainWindow()
        {
            InitializeComponent();
            subjectsViewSource =
         (CollectionViewSource)FindResource(nameof(subjectsViewSource));
            //answersViewSource =
            //    (CollectionViewSource)FindResource(nameof(answerViewSource));
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _context.Database.EnsureCreated();
            _context.Subjects.Load();
 //           _context.Questions.Load();
 //           _context.Answers.Load();
            // bind to the source
            subjectsViewSource.Source =
                _context.Subjects.Local.ToObservableCollection();
            //answersViewSource.Source =
            //    _context.Answers.Local.ToObservableCollection();

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
            //  subjectsDataGrid.Items.Refresh();
            // questionsDataGrid.Items.Refresh();
            // answersDataGrid.Items.Refresh();
            //MessageBox.Show("Selection changed!");
            //answerViewSource.Source =
            //     _context.Answers.Local.ToObservableCollection().Take(3);
            //answersDataGrid.Items.Refresh();
            //MessageBox.Show("Selection changed!");
        }
        private void RibbonApplicationMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
 