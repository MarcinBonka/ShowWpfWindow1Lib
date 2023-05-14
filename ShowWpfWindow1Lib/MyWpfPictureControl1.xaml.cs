using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace ShowWpfWindow1Lib
{
    /// <summary>
    /// Interaction logic for MyWpfPictureControl1.xaml
    /// </summary>
    public partial class MyWpfPictureControl1 : UserControl, INotifyPropertyChanged
    {
        //public BitmapImage MyImage { get; set; }
        public delegate void UpdatePictureDelegate(string picturePath);
        public event PropertyChangedEventHandler PropertyChanged;

        private BitmapImage _MyImage;

        public BitmapImage MyImage
        {
            get { return _MyImage; }
            set { 
                _MyImage = value;
                OnPropertyChanged();
            }
        }


        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public MyWpfPictureControl1(string pictureFilePath)
        {
            InitializeComponent();
            DataContext = this;
            //MyImage = new BitmapImage(new Uri("E:\\Temp\\Pictures\\Electronics1.jpg", UriKind.Absolute));
            MyImage = new BitmapImage(new Uri(pictureFilePath, UriKind.Absolute));
        }

        private void UpdatePicture(string picturePath)
        {
            MyImage = new BitmapImage(new Uri(picturePath, UriKind.Absolute));
        }

        public void UpdatePictureExternal(string path)
        {
            // zmiana stanu przycisku za pomocą delegata i Dispatcher.Invoke()
            Dispatcher.Invoke(new UpdatePictureDelegate(UpdatePicture), path);
        }
    }
}
