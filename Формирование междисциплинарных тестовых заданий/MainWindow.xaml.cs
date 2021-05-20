using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;

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
        public MainWindow()
        {
            InitializeComponent();
            subjectViewSource =
         (CollectionViewSource)FindResource(nameof(subjectViewSource));
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _context.Database.EnsureCreated();
            _context.Subjects.Load();
            // bind to the source
            subjectViewSource.Source =
                _context.Subjects.Local.ToObservableCollection();
        }
    }
}
 