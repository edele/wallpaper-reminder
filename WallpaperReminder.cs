using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;
using Microsoft.Win32;
using System.Drawing;
using System.Drawing.Imaging;

namespace wallpaper_reminder
{
    class WallpaperReminder
    {
        int w = 1366; int h = 768;
        Bitmap b;
        Graphics canvas;
        SolidBrush bgBrush;
        string imgPath;


        public WallpaperReminder(int w = 1366, int h = 768)
        {
            this.w = w; this.h = h;
            b = new Bitmap(w, h);
            canvas = Graphics.FromImage(b);
            bgBrush = new SolidBrush(Color.FromArgb(240, 240, 240));
            imgPath = "img.png";
        }

        public void Draw(string text)
        {
            canvas.FillRectangle(bgBrush, new Rectangle(0, 0, w, h));
            canvas.DrawString(text,
                new Font("Verdana", 12),
                new SolidBrush(Color.FromArgb(60, 60, 60)),
                new Point(w / 2, h - 60));
        }
        public void Save()
        {
            b.Save(imgPath, ImageFormat.Png);
        }
        public void Set()
        {
            Save();
            var uri = new System.Uri("c:\\foo");
            var converted = uri.AbsoluteUri;
            Wallpaper.Set((Image)b, Wallpaper.Style.Centered);
        }
    }

    public sealed class Wallpaper
    {// All credits to http://stackoverflow.com/questions/1061678/change-desktop-wallpaper-using-code-in-net
    
        Wallpaper() { }

        const int SPI_SETDESKWALLPAPER = 20;
        const int SPIF_UPDATEINIFILE = 0x01;
        const int SPIF_SENDWININICHANGE = 0x02;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        public enum Style : int
        {
            Tiled,
            Centered,
            Stretched
        }

        public static void Set(Image img, Style style)
        {
            string tempPath = Path.Combine(Path.GetTempPath(), "wallpaper.bmp");
            img.Save(tempPath, System.Drawing.Imaging.ImageFormat.Bmp);

            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
            if (style == Style.Stretched)
            {
                key.SetValue(@"WallpaperStyle", 2.ToString());
                key.SetValue(@"TileWallpaper", 0.ToString());
            }

            if (style == Style.Centered)
            {
                key.SetValue(@"WallpaperStyle", 1.ToString());
                key.SetValue(@"TileWallpaper", 0.ToString());
            }

            if (style == Style.Tiled)
            {
                key.SetValue(@"WallpaperStyle", 1.ToString());
                key.SetValue(@"TileWallpaper", 1.ToString());
            }

            SystemParametersInfo(SPI_SETDESKWALLPAPER,
                0,
                tempPath,
                SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
        }
    }
}
