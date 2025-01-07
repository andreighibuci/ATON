using ICSharpCode.AvalonEdit.Highlighting.Xshd;
using ICSharpCode.AvalonEdit.Highlighting;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using ATON.Models;
using System.IO;
using ATON.Helpers;

namespace ATON.Views
{
    /// <summary>
    /// Interaction logic for ATONFunctionEditPage.xaml
    /// </summary>
    public partial class ATONFunctionEditPage : Page
    {
        public ATONFunctionEditPage(AtonFunction atonFunction)
        {
            InitializeComponent();



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
    }
}
