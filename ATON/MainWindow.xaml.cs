using ATON.Helpers;
using ATON.ViewModels;
using ATON.Views;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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

            //Beta Init of Editor
          //  ATONFunctionEditPage atonFuncEditor = new ATONFunctionEditPage();
          //  EditorFrame.Navigate(atonFuncEditor);


            //Initialisation of ViewModel and injection to DataContext for XAML Binding
            viewModel = new MainWindowViewModel();
            DataContext = viewModel;

        }
    }
}