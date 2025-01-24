using ATON.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace ATON.ViewModels
{
    public class AddModalViewModel : INotifyPropertyChanged
    {
        //use for getting out selected type of creation
        private String _selectedType;

        public ICommand SelectedTestElemCommand {  get; set; }  
        public ICommand SelectedFunElemCommand { get; set; }

        public AddModalViewModel()
        {

            //Init Commands
            SelectedFunElemCommand = new RelayCommand(onSelectedFunElem);
            SelectedTestElemCommand = new RelayCommand(onSelectedTestElem);
        }


        //Selected Testcase
        private void onSelectedTestElem(object obj)
        {
            //Retrieve FunctionName and search for corresponding Element in available functions
            Label testName = (Label)obj;
            string labelContent = testName.Content.ToString();

            //InjectSelectedType
            _selectedType = labelContent;
        }


        //Selected Function
        private void onSelectedFunElem(object obj)
        {
            //Retrieve FunctionName and search for corresponding Element in available functions
            Label funcName =(Label) obj;
            string labelContent = funcName.Content.ToString();

            //InjectSelectedType
            _selectedType = labelContent;
        }









        //INotify Implementations for notifiying the GUI on Binding values change
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
