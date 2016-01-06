using System;
using System.Drawing;

namespace RPON
{
    public static class Utils
    {
        public static void UpdateScreen(ref Bitmap screen, Image newPartialScreen, Rectangle boundingBox)
        {
            if (screen == null)
            {
                screen = new Bitmap(boundingBox.Width, boundingBox.Height);
            }

            Graphics g = null;
            try
            {
                lock (screen)
                {
                    g = Graphics.FromImage(screen);
                    g.DrawImage(newPartialScreen, boundingBox);
                    g.Flush();
                }
            }
            catch (Exception)
            {
                
            }
            finally
            {
                if (g != null) g.Dispose();
            }
        }
    }
}
