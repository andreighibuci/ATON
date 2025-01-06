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

namespace ATON.Views
{
    /// <summary>
    /// Interaction logic for ATONFunctionEditPage.xaml
    /// </summary>
    public partial class ATONFunctionEditPage : Page
    {
        public ATONFunctionEditPage()
        {
            InitializeComponent();
            LoadPythonSyntaxHighlighting();
        }

        private void LoadPythonSyntaxHighlighting()
        {
            using (var stream = typeof(MainWindow).Assembly.GetManifestResourceStream("ATON.Resources.Python.xshd"))
            using (var reader = new XmlTextReader(stream))
            {
                TextEditor.SyntaxHighlighting = HighlightingLoader.Load(reader, HighlightingManager.Instance);
            }
        }
    }
}
