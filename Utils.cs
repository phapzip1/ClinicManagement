﻿using System.Drawing.Text;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ClinicManagement
{
    internal class Utils
    {
        #region FontLoader and Getter

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);
        private static PrivateFontCollection pfc { get; set; }
        private static FontFamily _fmCache;

        static Utils()
        {
            if (pfc == null) { pfc = new PrivateFontCollection(); }
            if (_fmCache == null) { _fmCache = new FontFamily(GenericFontFamilies.SansSerif); }
        }

        public static void AddMemoryFont(byte[] fontResource)
        {
            IntPtr p;
            uint c = 0;

            p = Marshal.AllocCoTaskMem(fontResource.Length);
            Marshal.Copy(fontResource, 0, p, fontResource.Length);
            AddFontMemResourceEx(p, (uint)fontResource.Length, IntPtr.Zero, ref c);
            pfc.AddMemoryFont(p, fontResource.Length);
            Marshal.FreeCoTaskMem(p);
            p = IntPtr.Zero;
        }

        public static Font GetFont(string fontName, float fontSize = 16, FontStyle fontStyle = FontStyle.Regular)
        {
            if (_fmCache.Name.Contains(fontName))
                return new Font(_fmCache,fontSize, fontStyle);
            foreach (FontFamily fm in pfc.Families)
                if (fm.Name.Contains(fontName))
                {
                    _fmCache = fm;
                    return new Font(fm, fontSize, fontStyle);
                }
            throw new Exception("Font Failure!");
        }

        #endregion

        #region ColorConverter
        public static Color FromHex(string code) => ColorTranslator.FromHtml(code);

        #endregion
    }
}
