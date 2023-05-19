using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace ShowWpfWindow1Lib
{
    public class WindowExhibitor
    {
        public PictureWindow PictWindow { get; set; }
        public Thread PictureWindowThread { get; set; }
        //public MyWpfPictureControl1 MyPicture { get; set; }
        public void InitWindow(string initialPicturePath)
        {
            
            PictureWindowThread = new Thread(() =>
            {
                //MyPicture = new MyWpfPictureControl1(initialPicturePath);
                //PictWindow = new PictureWindow
                //{
                //    Content = MyPicture,
                //    Width = 800,
                //    Height = 600,
                //    WindowStartupLocation = WindowStartupLocation.CenterScreen,
                //    Topmost= true
                //};
                PictWindow = new PictureWindow(initialPicturePath);
                PictWindow.ShowDialog();
            });
            PictureWindowThread.SetApartmentState(ApartmentState.STA);
            PictureWindowThread.Start();
        }

        public void ShowPicture(string picturePath)
        {
            if(PictureWindowThread !=null && PictureWindowThread.IsAlive && PictWindow != null) 
            {
                //PictureWindow.Content = new MyWpfPictureControl1(picturePath);
                //PictureWindow.BeginInvoke((Action)(() => PictureWindow.Content = picturePath));
                //MyPicture.MyImage = new System.Windows.Media.Imaging.BitmapImage(new System.Uri(picturePath));
                //Dispatcher.Invoke((Action)(() => PictureWindow.Content = picturePath));
                //Dispatcher.Invoke(new MyWpfPictureControl1.UpdatePictureDelegate(picturePath), true);

                //MyPicture.UpdatePictureExternal(picturePath);
                PictWindow.UpdatePicture(picturePath);
            }

           
        }

        public void ShowHideWindow(bool show)
        {
            if (PictureWindowThread != null && PictureWindowThread.IsAlive && PictWindow != null)
            {
                //PictureWindow.Content = new MyWpfPictureControl1(picturePath);
                //PictureWindow.BeginInvoke((Action)(() => PictureWindow.Content = picturePath));
                //MyPicture.MyImage = new System.Windows.Media.Imaging.BitmapImage(new System.Uri(picturePath));
                //Dispatcher.Invoke((Action)(() => PictWindow.Hide()));
                //Dispatcher.Invoke(new MyWpfPictureControl1.UpdatePictureDelegate(picturePath), true);
                //MyPicture.UpdatePictureExternal(picturePath);
                if (show)
                    PictWindow.ShowWindow();
                else
                    PictWindow.HideWindow();
            }


        }
    }
}
