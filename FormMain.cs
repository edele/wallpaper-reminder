using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wallpaper_reminder
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            var mainScreen = Screen.PrimaryScreen;
            tbResW.Text = mainScreen.Bounds.Width.ToString();
            tbResH.Text = mainScreen.Bounds.Height.ToString();
        }

        private void bSetWallpaper_Click(object sender, EventArgs e)
        {
            int w = int.Parse(tbResW.Text);
            int h = int.Parse(tbResH.Text);
            var wr = new WallpaperReminder(w,h);
            wr.Draw(tbText.Text);
            wr.Set();
            wr.DeleteImage();
            Application.Exit();
        }

        private void bSetWallpaper_Click_NoArgs()
        {
            int w = int.Parse(tbResW.Text);
            int h = int.Parse(tbResH.Text);
            var wr = new WallpaperReminder(w, h);
            wr.Draw(tbText.Text);
            wr.Set();
            wr.DeleteImage();
            Application.Exit();
        }

        private void tbText_KeyUp(object sender, KeyEventArgs ё)
        {
            if (ё.KeyValue == 27)
            {
                Application.Exit();
                ё.Handled = true;
            }
            if (ё.KeyValue == 13)
                bSetWallpaper_Click_NoArgs();
        }
    }
}
