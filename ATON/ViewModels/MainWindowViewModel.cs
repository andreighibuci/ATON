using ATON.Helpers;
using ATON.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ATON.ViewModels
{
    public class MainWindowViewModel:INotifyPropertyChanged
    {

        //Objects List
        public ObservableCollection<AtonObject> AtonObjects { get; set; }



        //Image Setter for UI
        private Image _image;
        public Image Image { get { return _image;  } set { _image = value; OnPropertyChanged("Image"); } }
        public MainWindowViewModel()
        {
            
            AtonObjects = new ObservableCollection<AtonObject>();

            //Mockuper Use TO DELETE ON REAL USAGE
            StaticDB.AtonObjects = Mockuper.CreateRandObjects();

            //Initialisation of Editor Objects List
            foreach (var atonObject in StaticDB.AtonObjects)
            {
                AtonObjects.Add(atonObject);
            }


        }





        //INotify Implementations
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
