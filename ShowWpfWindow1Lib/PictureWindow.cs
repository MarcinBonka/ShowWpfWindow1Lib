using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.Windows;

namespace ShowWpfWindow1Lib
{
    public class PictureWindow : Window
    {
        public MyWpfPictureControl1 MyPicture { get; set; }

        public PictureWindow(string initialPicturePath)
        {
            if (!string.IsNullOrEmpty(initialPicturePath))
            {
                MyPicture = new MyWpfPictureControl1(initialPicturePath);
                Content= MyPicture;
            }
            //    Content = MyPicture,
            Width = 800;
            Height = 600;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Topmost = true;
        }

        public void UpdatePicture(string picturePath)
        {
            Dispatcher.Invoke(() =>
            {
                MyPicture.UpdatePicture(picturePath); // Hide the window on the UI thread
            });
        }

        public void HideWindow()
        {
            Dispatcher.Invoke(() =>
            {
                Hide(); // Hide the window on the UI thread
            });
        }

        public void ShowWindow()
        {
            Dispatcher.Invoke(() =>
            {
                ShowDialog(); // Show the window on the UI thread
            });
        }
    }
}
