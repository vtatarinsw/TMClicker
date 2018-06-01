using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowManager
{
    public class TMPart
    {
        public string PartName;
        public string Filename;
        public string Description;
        public Rectangle Position;
        public Bitmap Bitmap;
    }

    public class TMScreens
    {
        public TMScreens()
        {


        }

        private const int PartWidth = 25;
        private const int PartHeight = 25;

        private const string ScreensPath = @".\Screens\";



        private Dictionary<string, TMPart> Parts = new Dictionary<string, TMPart>()
        {
            { "RumbleStart", new TMPart() { PartName = "RumbleStart",
                                            Filename = "R01.bmp",
                                            Description = "Main Rumble Screen with RUMBLE button on center bottom part",
                                            Position = new Rectangle(550, 607, PartWidth, PartHeight),
                                            Bitmap = new Bitmap(ScreensPath + "R01.bmp")} },

            { "RumbleAuto", new TMPart() {  PartName = "RumbleAuto",
                                            Filename = "R02.0.bmp",
                                            Description = "Rumble Play Screen with AUTO button that is NOT activated",
                                            Position = new Rectangle(1192, 774, PartWidth, PartHeight),
                                            Bitmap = new Bitmap(ScreensPath + "R02.0.bmp")} },

            { "RumbleAutoOn", new TMPart() { PartName = "RumbleAutoOn",
                                            Filename = "R02.1.bmp",
                                            Description = "Rumble Play Screen with AUTO button that is Activated",
                                            Position = new Rectangle(1192, 774, PartWidth, PartHeight),
                                            Bitmap = new Bitmap(ScreensPath + "R02.1.bmp")} },

            { "RumbleWon", new TMPart() {   PartName = "RumbleWon",
                                            Filename = "R03.bmp",
                                            Description = "Rumble After play Screen with Won or Defeat title and OK button",
                                            Position = new Rectangle(716, 706, PartWidth, PartHeight),
                                            Bitmap = new Bitmap(ScreensPath + "R03.bmp")} },

            { "RumbleClaim", new TMPart() { PartName = "RumbleClaim",
                                            Filename = "R04.bmp",
                                            Description = "Rumble After play Screen with Won or Defeat title and OK button",
                                            Position = new Rectangle(606, 550, PartWidth, PartHeight),
                                            Bitmap = new Bitmap(ScreensPath + "R04.bmp")} },

            { "RumbleArena", new TMPart() { PartName = "RumbleArena",
                                            Filename = "R05.bmp",
                                            Description = "Rumble After play Screen with change Arena",
                                            Position = new Rectangle(610, 760, PartWidth, PartHeight),
                                            Bitmap = new Bitmap(ScreensPath + "R05.bmp")} },

            { "RumbleGold", new TMPart() { PartName = "RumbleGold",
                                            Filename = "R06.bmp",
                                            Description = "Rumble After play Screen with gold prize claim",
                                            Position = new Rectangle(1110, 530, PartWidth, PartHeight),
                                            Bitmap = new Bitmap(ScreensPath + "R06.bmp")} },

            { "RumbleGoldClaim", new TMPart() { PartName = "RumbleGoldClaim",
                                            Filename = "R07.bmp",
                                            Description = "Rumble After play Screen with gold prize confirm claim dialog",
                                            Position = new Rectangle(606, 550, PartWidth, PartHeight),
                                            Bitmap = new Bitmap(ScreensPath + "R07.bmp")} }
        };

        public TMPart GetPart(string partName)
        {
            if (!Parts.Keys.Contains(partName))
            {
                return null;
            }

            return Parts[partName];
        }

        public bool CompareImages(TMPart part, Bitmap image)
        {
            int diff = 0;

            // Alternative code that is slower than memcmp
            for (int i = 0; i < image.Width; i++)
                for (int k = 0; k < image.Height; k++)
                {
                    Color c1 = image.GetPixel(i, k);
                    Color c2 = part.Bitmap.GetPixel(i, k);

                    if (c1 != c2)
                    {
                        diff += (c1.R > c2.R ? c1.R - c2.R : c2.R - c1.R) +
                            (c1.G > c2.G ? c1.G - c2.G : c2.G - c1.G) +
                            (c1.B > c2.B ? c1.B - c2.B : c2.B - c1.B);
                    }
                }

            if (diff < 0 || diff > 1000)
            {
                return false;
            }

            if (diff != 0)
            {
                Debug.WriteLine(string.Format("Checking {0}, Diff = {1}", part.PartName, diff));
            }

            return true;

            //return CompareMemCmp(part.Bitmap, image);
        }

        [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int memcmp(IntPtr b1, IntPtr b2, long count);

        public static bool CompareMemCmp(Bitmap b1, Bitmap b2)
        {
            if ((b1 == null) != (b2 == null)) return false;
            if (b1.Size != b2.Size) return false;

            var bd1 = b1.LockBits(new Rectangle(new Point(0, 0), b1.Size), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            var bd2 = b2.LockBits(new Rectangle(new Point(0, 0), b2.Size), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            try
            {
                IntPtr bd1scan0 = bd1.Scan0;
                IntPtr bd2scan0 = bd2.Scan0;

                int stride = bd1.Stride;
                int len = stride * b1.Height;

                return memcmp(bd1scan0, bd2scan0, len) == 0;
            }
            catch
            {
                return false;
            }
            finally
            {
                b1.UnlockBits(bd1);
                b2.UnlockBits(bd2);
            }
        }

    }
}
