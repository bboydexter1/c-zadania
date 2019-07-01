using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Windows.Media.Imaging;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            int resX = 512;
            int resY = 512;
            string inCatalog = Directory.GetCurrentDirectory();
            string outCatalog = Directory.GetCurrentDirectory()+"//output";

            foreach (string param in args)
            {
                if (param.StartsWith("-res=") == true)
                {
                    string res = param.Split('=')[1];
                    try
                    {
                        resX = Convert.ToInt32(res.Split('x')[0]);
                        resY = Convert.ToInt32(res.Split('x')[1]);
                    } catch (Exception e)
                    {
                        Console.WriteLine("You typed -res=reXxresY wrong, check if there are something more than numbers and separator x after =");
                        break;
                    }
                }
                else if (param.StartsWith("-inputdir=") == true)
                {
                    inCatalog = param.Split('=')[1];
                    if (!Directory.Exists(inCatalog))
                    {
                        throw new Exception();
                    }
                }
                else if (param.StartsWith("-outputdir=") == true)
                {
                    outCatalog = param.Split('=')[1];
                }
                else
                {
                    Console.WriteLine("parametr : " + param + " is wrong");
                }
            }

                    if (!Directory.Exists(outCatalog))
                    {
                        Directory.CreateDirectory(outCatalog);
                    }

            List<string> files = new List<string>(Directory.GetFiles(inCatalog));

            foreach (string file in files)
            {
                bool freeSpace = false;
                string tmp = Path.GetFileName(file);
                int fileNumber = 1;

                while (freeSpace == false)
                {
                    if (File.Exists(outCatalog+"//"+tmp))
                    {
                        tmp = Path.GetFileNameWithoutExtension(file)+"_"+fileNumber+Path.GetExtension(file);
                        fileNumber++;
                    }
                    else
                    {
                        freeSpace = true;
                    }
                }

                try
                {
                    Image imgPhoto = Image.FromFile(file);
                    var destRect = new Rectangle(0, 0, resX, resY);
                    var destImage = new Bitmap(resX, resY);

                    destImage.SetResolution(imgPhoto.HorizontalResolution, imgPhoto.VerticalResolution);

                    using (var graphics = Graphics.FromImage(destImage))
                    {
                        graphics.CompositingMode = CompositingMode.SourceCopy;
                        graphics.CompositingQuality = CompositingQuality.HighQuality;
                        graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        graphics.SmoothingMode = SmoothingMode.HighQuality;
                        graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                        using (var wrapMode = new ImageAttributes())
                        {
                            wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                            graphics.DrawImage(imgPhoto, destRect, 0, 0, imgPhoto.Width, imgPhoto.Height, GraphicsUnit.Pixel, wrapMode);
                        }
                    }
                    destImage.Save(outCatalog+"//"+tmp);
                }
                catch (Exception e)
                {
                    Console.WriteLine(file + " may not be a graphical file");
                }
            }
            
            Console.WriteLine("operaction ended, press Enter to continue");
            Console.ReadLine();
        }
    }
}
