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
using System.Windows.Shapes;
using Microsoft.Win32;

namespace JpgToASCII_WPF
{

    public partial class GrayscaleWindow : Window
    {
        public static string OK_MESSAGE = "Image saved successfully";
        public static string ERROR_MESSAGE = "An error occurred during image saving";
        ImgConverter CONVERTER;
        public GrayscaleWindow(ImgConverter CONVERTER)
        {
            InitializeComponent();
            this.CONVERTER = CONVERTER;
        }

        private void grayscaleImage_Loaded(object sender, RoutedEventArgs e)
        {
            grayscaleImage.MaxWidth = grayScaleWindow.ActualWidth * 0.6;
            grayscaleImage.Source = ImgConverter.BitmapToImageSource(CONVERTER.GrayscaleImg);
        }

        private void grayScaleWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            grayscaleImage.MaxWidth = grayScaleWindow.ActualWidth * 0.6;
        }

        private void MenuItem_Close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.IsEnabled = true;
            this.Close();
        }

        private void MenuItem_SaveGrayscale_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show(CONVERTER.SaveGrayscaleImage() ? (OK_MESSAGE) : (ERROR_MESSAGE));
            }
            catch (Exception)
            {
                MessageBox.Show(ERROR_MESSAGE);
            }
            
        }

        private void ConvertGrayscaleButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg";
                if (saveFileDialog.ShowDialog() == true)
                {
                    CONVERTER.Path = saveFileDialog.FileName;
                    CONVERTER.DefaultPath = false;
                    MessageBox.Show(CONVERTER.SaveGrayscaleImage() ? (OK_MESSAGE) : (ERROR_MESSAGE));
                }
            }
            catch(Exception)
            {
                MessageBox.Show(ERROR_MESSAGE);
            }
            CONVERTER.DefaultPath = false;
        }

        private void grayScaleWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.MainWindow.IsEnabled = true;
        }

        private void MenuItem_SaveASCII_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show(CONVERTER.ConvertAndSaveToASCII() ? (OK_MESSAGE) : (ERROR_MESSAGE));
            }
            catch (Exception)
            {
                MessageBox.Show(ERROR_MESSAGE);
            }
        }

        private void ConvertASCIIButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text File (*.txt)|*.txt";
                if (saveFileDialog.ShowDialog() == true)
                {
                    CONVERTER.Path = saveFileDialog.FileName;
                    CONVERTER.DefaultPath = false;
                    MessageBox.Show(CONVERTER.ConvertAndSaveToASCII() ? (OK_MESSAGE) : (ERROR_MESSAGE));
                }
            }
            catch (Exception)
            {
                MessageBox.Show(ERROR_MESSAGE);
            }
            CONVERTER.DefaultPath = false;
        }
    }
}
