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
using Microsoft.Win32;
using System.Drawing;

namespace JpgToASCII_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static ImgConverter CONVERTER;
        GrayscaleWindow window;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.DefaultExt = ".png";
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg";

            dlg.ShowDialog();

            if (dlg.FileName!="")
            {
                CONVERTER = new ImgConverter(dlg.FileName);
                mainImage.MaxWidth = mainWindow.ActualWidth * 0.4;
                mainImage.Source = ImgConverter.BitmapToImageSource(CONVERTER.Img);
            }

        }

        private void mainWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            mainImage.MaxWidth = mainWindow.ActualWidth * 0.4;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ImagePanel_Drop(object sender, DragEventArgs e)
        {
            try
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                CONVERTER = new ImgConverter(files[0]);
                mainImage.MaxWidth = mainWindow.ActualWidth * 0.4;
                mainImage.Source = ImgConverter.BitmapToImageSource(CONVERTER.Img);
            }
            catch(Exception)
            {
                MessageBox.Show("The given file is not an image.");
            }
        }

        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            if (CONVERTER != null)
            {
                CONVERTER.ConvertToGrayscale();
                window = new GrayscaleWindow(CONVERTER);
                window.Show();
                mainWindow.IsEnabled = false;
            }
            else
            {
                MessageBox.Show("There is nothing to convert.");
            }
        }

        private void MenuItem_grayscaleConvert_Click(object sender, RoutedEventArgs e)
        {
            if (CONVERTER != null)
            {
                MessageBox.Show(CONVERTER.SaveGrayscaleImage() ? ("Image saved successfully") : ("An error occurred while saving the image"));
            }
            else
            {
                MessageBox.Show("There is nothing to save.");
            }
        }

        private void MenuItem_ASCII_Save_Click(object sender, RoutedEventArgs e)
        {
            if (CONVERTER != null)
            {
                CONVERTER.ConvertToGrayscale();
                MessageBox.Show(CONVERTER.ConvertAndSaveToASCII() ? ("Image saved successfully") : ("An error occurred while saving the image"));
            }
            else
            {
                MessageBox.Show("There is nothing to save.");
            }
        }

        private void MenuItem_FromASCII_To_Grayscale_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text Files (*.txt)|*.txt";

            dlg.ShowDialog();

            if (dlg.FileName != "")
            {
                try
                {
                    BitmapImage bmp = ImgConverter.BitmapToImageSource(ImgConverter.FromASCII_ToImage(dlg.FileName));
                    mainImage.Source = bmp;
                    CONVERTER = new ImgConverter(dlg.FileName, ImgConverter.FromASCII_ToImage(dlg.FileName));
                }
                catch (Exception)
                {
                    MessageBox.Show("Converting error");
                }
            }
        }
    }
}
