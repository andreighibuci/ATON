using ATON.Helpers;
using ATON.Models;
using ATON.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace ATON.ViewModels
{

    //MainWindow ViewModel
    public class MainWindowViewModel:INotifyPropertyChanged
    {

        //List with all available Functions that is automatically updated on delete and add 
        public ObservableCollection<AtonFunction> Functions { get; set; }

        //List with all availabe Tests that is automatically updated on delete and add
        public ObservableCollection<AtonTestCase> Tests { get; set; }

        //Command Declarations
        public ICommand FunctionEditCommand { get; set; }
        public ICommand SaveCommand { get; set; }   

        //Initialization of Binded Elements
        public MainWindowViewModel()
        {
            //Initialization of Observalbe lists so they can be updated all the time on GUI
            Functions = new ObservableCollection<AtonFunction>();
            Tests = new ObservableCollection<AtonTestCase>();

            //Initialisation of Commands
            FunctionEditCommand = new RelayCommand(onFunctionEditMethod);
            SaveCommand = new RelayCommand(onSaveMethod);

            //Mocking Up List of Functions
            foreach (var func in Mockuper.CreateRandFuncs()) {
                Functions.Add(func);   
            }

            //Mocking Up List of Testcases
            foreach (var test in Mockuper.CreateRandTestCases())
            {
                Tests.Add(test);
            }


        }

        private void onSaveMethod(object obj)
        {
            try
            {
                //Create new list with code to be saved
                String[] pyCodeLines = Helper.TextEditorString.Split("\r\n");
                Helper.ATONFunctionEditViewModel.function.PyCode = pyCodeLines;

                //Saving the code
                Helper.SaveAtonFunction(Helper.ATONFunctionEditViewModel.function);

                //Disable * from name after Save
                Helper.ATONFunctionEditViewModel.Name = Helper.ATONFunctionEditViewModel.Name.Replace("*","");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


        //Open Function Editor on Desired Element
        private void onFunctionEditMethod(object obj)
        {
            //Retrieve FunctionName and search for corresponding Element in available functions
            var funcName = (TextBlock)obj;
            var atonFunction = Functions.Where(o => o.Name == funcName.Text).FirstOrDefault();

            //Inject Function into editor and open (Maybe in future implement a TabControlling Behaviour)
            ATONFunctionEditPage atonFuncEditor = new ATONFunctionEditPage(atonFunction);
            Helper.EditorFrame.Navigate(atonFuncEditor);
        }


        //INotify Implementations for notifiying the GUI on Binding values change
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
