using ATON.Helpers;
using ATON.ViewModels;
using System.Windows;


namespace ATON
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //View Model to be injected as DataContext
        private MainWindowViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();

            //Inject Helper with EditorFrame
            Helper.EditorFrame = EditorFrame;

            //Initialisation of ViewModel and injection to DataContext for XAML Binding
            viewModel = new MainWindowViewModel();
            DataContext = viewModel;

        }
    }
}