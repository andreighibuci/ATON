using ATON.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ATON.Views
{
    /// <summary>
    /// Interaction logic for AddModal.xaml
    /// </summary>
    public partial class AddModal : Window
    {

        private AddModalViewModel addModalViewModel;
        public AddModal()
        {
            InitializeComponent();
            addModalViewModel = new AddModalViewModel();
            DataContext = addModalViewModel;
        }
    }
}
