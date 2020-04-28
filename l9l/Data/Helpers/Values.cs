using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace l9l.Data.Helpers
{
    public class Values
    {
        public static int Width = 308;

        public static int Height = 374;

        public static string Index = "Index";

        public static string Key = "UserId";

        public static Point Location = new Point(170, 142);

        public static string TPath = "\\Content\\Design\\Tshirts\\";

        public static string PFolder = "\\Content\\Design\\Products\\";

        public static string CFolder = "\\Content\\Design\\Categories\\";

        public static List<string> Random()
        {
            return new List<string>
            {
                "Asphalt.png", "Dark Heather.png",
                "Heather Gray.png", "red.png", "Silver.png"
            };
        }

        public static bool SessionOk()
        {
            //string v = HttpContext.Session.GetString(Key);
            return true;
        }

    }
}
