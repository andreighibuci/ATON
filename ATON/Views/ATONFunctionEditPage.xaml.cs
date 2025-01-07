using ICSharpCode.AvalonEdit.Highlighting.Xshd;
using ICSharpCode.AvalonEdit.Highlighting;
using System.Windows.Controls;
using System.Xml;
using ATON.Models;
using System.IO;
using ATON.Helpers;
using ATON.ViewModels;
using ICSharpCode.AvalonEdit;

namespace ATON.Views
{
    /// <summary>
    /// Interaction logic for ATONFunctionEditPage.xaml
    /// </summary>
    public partial class ATONFunctionEditPage : Page
    {
        //bool to see if the text is loaded or edited
        private bool TextEdit = false;  
        //DataContext VM
        private ATONFunctionEditViewModel viewModel;
        public ATONFunctionEditPage(AtonFunction atonFunction)
        {
            InitializeComponent();
            viewModel = new ATONFunctionEditViewModel(atonFunction);
            DataContext = viewModel;

            

            //Keeping editor options functions in the xaml area (break MVVM) due to easy handling over editor load in Avalon lib
            LoadPythonSyntaxHighlighting();
            OpenFunction(atonFunction);

            
        }


        //Highlight Python Syntax and load rulesets via Python.xshd file
        private void LoadPythonSyntaxHighlighting()
        {
            using (var stream = typeof(MainWindow).Assembly.GetManifestResourceStream("ATON.Resources.Python.xshd"))
            using (var reader = new XmlTextReader(stream))
            {
                TextEditor.SyntaxHighlighting = HighlightingLoader.Load(reader, HighlightingManager.Instance);            
            }
        }

        //Open desired function (if code is allready available)
        private void OpenFunction(AtonFunction atonFunction)
        {
            //Check if file allready available to open
            if (File.Exists(Helper.pCodePath + atonFunction.Name+".py"))
            {
                TextEditor.Load(Helper.pCodePath + atonFunction.Name + ".py");
            }

        }

        private void TextEditor_TextChanged(object sender, EventArgs e)
        {
            Helper.TextEditorString = TextEditor.Text;
            if(!Helper.ATONFunctionEditViewModel.Name.Contains("*") && TextEdit)
                Helper.ATONFunctionEditViewModel.Name = Helper.ATONFunctionEditViewModel.Name + "*";

            //Allow to see changes
            TextEdit = true;
        }
    }
}
