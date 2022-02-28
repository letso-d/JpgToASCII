using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Media.Imaging;
using System.IO;

namespace JpgToASCII_WPF
{
    public class ImgConverter
    {
        public static double RED_COEFF = 0.2126;
        public static double BLUE_COEFF = 0.7152;
        public static double GREEN_COEFF = 0.0722;
        public static string chars = "@#Ł=+|:.  ";

        public ImgConverter()
        {

        }

        public ImgConverter(string path, Bitmap bmp)
        {
            this.path = path;
            this.img = GetResizedImage(bmp, 400);
        }

        public ImgConverter(string path)
        {
            this.path = path;
            this.img = new Bitmap(path);
            this.img = GetResizedImage(this.img, 400);
        }

        bool defaultPath = true;
        public bool DefaultPath
        {
            get
            {
                return this.defaultPath;
            }
            set
            {
                this.defaultPath = value;
            }
        }

        Bitmap img;
        public Bitmap Img
        {
            get
            {
                return this.img;
            }
        }

        string path;
        public string Path
        {
            get
            {
                return this.path;
            }
            set
            {
                this.path = value;
            }
        }

        Bitmap grayscaleImg;
        public Bitmap GrayscaleImg 
        {
            get
            {
                return this.grayscaleImg;
            }
        }

        public Bitmap ConvertToGrayscale()
        {
            grayscaleImg = new Bitmap(this.img.Width, this.img.Height);
            for (int i = 0; i < this.img.Width; i++)
            {
                for (int j = 0; j < this.img.Height; j++)
                {
                    Color pixelcolor = (this.img as Bitmap).GetPixel(i, j);
                    Color newcolor = new Color();
                    newcolor = Color.FromArgb((int)(pixelcolor.R * RED_COEFF + pixelcolor.G * GREEN_COEFF + pixelcolor.B * BLUE_COEFF),
                                               (int)(pixelcolor.R * RED_COEFF + pixelcolor.G * GREEN_COEFF + pixelcolor.B * BLUE_COEFF),
                                               (int)(pixelcolor.R * RED_COEFF + pixelcolor.G * GREEN_COEFF + pixelcolor.B * BLUE_COEFF));
                    this.grayscaleImg.SetPixel(i, j, newcolor);
                }
            }
            return this.grayscaleImg;
        }

        public bool SaveGrayscaleImage()
        {
            if (defaultPath)
            {
                var values = path.Split('.');
                string prefix = values[0];
                string postfix = values[1];
                this.path = prefix + "_grayscale." + postfix;
            }
            try
            {
                if (this.grayscaleImg == null)
                {
                    ConvertToGrayscale();
                }

                this.grayscaleImg.Save(this.path);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static BitmapImage BitmapToImageSource(Bitmap bitmap)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Bmp);
                memory.Position = 0;
                BitmapImage bitmapimage = new BitmapImage();
                bitmapimage.BeginInit();
                bitmapimage.StreamSource = memory;
                bitmapimage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapimage.EndInit();

                return bitmapimage;
            }
        }

        public bool ConvertAndSaveToASCII()
        {
            bool result = true;
            if (defaultPath)
            {
                var values = path.Split('.');
                string prefix = values[0];
                this.path = prefix + "_ASCII.txt";
            }
            try
            {
                Bitmap resized = GetResizedImage(grayscaleImg, 400);
                string output = ConvertToASCII(resized);
                result =  SaveASCII(output, path);
                return result;
            }
            catch (Exception)
            {
                result = false;
                return result;
            }

        }

        private Bitmap GetResizedImage(Bitmap img, int width)
        {
            int height = 0;
            height = (int)Math.Ceiling((double)img.Height * width / img.Width);
            height += (int)Math.Ceiling(height * 0.1);
            Bitmap result = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(result);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.DrawImage(img, 0, 0, width, height);
            g.Dispose();
            return result;
        }

        private string ConvertToASCII(Bitmap image)
        {
            StringBuilder sb = new StringBuilder();
            for (int j = 0; j < image.Size.Height; j += 2)
            {
                for (int i = 0; i < image.Size.Width; i++)
                {
                    sb.Append(string.Format("{0}", GetASCIIChar(image.GetPixel(i, j).R)));
                }
                sb.Append(string.Format("\n"));
            }
            return sb.ToString();
        }
        private char GetASCIIChar(int grayScale)
        {
            return chars[(grayScale * (chars.Length-1) / 255)];
        }

        private bool SaveASCII(string output, string path)
        {
            StreamWriter sw = new StreamWriter(path);
            try
            {
                sw.Write(output);
                sw.Flush();
                sw.Close();
            }
            catch (Exception)
            {
                sw.Close();
                return false;
            }
            return true;
        }

        public static Bitmap FromASCII_ToImage(string path)
        {
            int index = 1;
            StreamReader sr = new StreamReader(path);
            string line = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                index++;
            }
            Bitmap bmp = new Bitmap(line.Length + 1, index + 1 );
            sr.Dispose();
            sr.Close();
            sr = new StreamReader(path);
            index = 0;
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                for (int j = 0; j < line.Length; j++)
                {
                    bmp.SetPixel(j, index, Color.FromArgb(GetGrayScale(line[j]), GetGrayScale(line[j]), GetGrayScale(line[j])));
                }
                index++;
            }
            sr.Dispose();
            sr.Close();
            Bitmap result = new Bitmap(bmp.Width*2, bmp.Height * 3);
            Graphics g = Graphics.FromImage(result);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.DrawImage(bmp, 0, 0, result.Width, result.Height);
            return result;
        }

        private static int GetGrayScale(char c)
        {
            switch (c)
            {
                case '@': return 0;
                case '#': return GetValue(1);
                case 'Ł': return GetValue(2);
                case '=': return GetValue(3);
                case '+': return GetValue(4);
                case '|': return GetValue(5);
                case ':': return GetValue(6);
                case '.': return GetValue(7);
                case ' ': return 255;
            }
            return 255;
        }
        private static int GetValue(int n)
        {
            return n * 255 / (chars.Length-1);
        }
    }
}
