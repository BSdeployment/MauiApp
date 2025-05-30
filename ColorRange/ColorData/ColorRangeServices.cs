//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ColorData
//{
//  public  class ColorRangeServices
//    {
//      public  IList<ColorRangeModel> ColorRanges { get; set; }

//        public ColorRangeServices()
//        {

//            ColorRanges = new List<ColorRangeModel>
//        {
//            new() { ColorName = "Red",         From = (  0, 100, 100), To = ( 10, 255, 255) },
//            new() { ColorName = "Orange",      From = ( 11, 100, 100), To = ( 25, 255, 255) },
//            new() { ColorName = "Yellow",      From = ( 26, 100, 100), To = ( 34, 255, 255) },
//            new() { ColorName = "LightGreen",  From = ( 35, 100, 100), To = ( 50, 255, 255) },
//            new() { ColorName = "DarkGreen",   From = ( 51, 100, 100), To = ( 85, 255, 255) },
//            new() { ColorName = "Cyan",        From = ( 86, 100, 100), To = (100, 255, 255) },
//            new() { ColorName = "Blue",        From = (101, 100, 100), To = (130, 255, 255) },
//            new() { ColorName = "Purple",      From = (131, 100, 100), To = (160, 255, 255) },
//            new() { ColorName = "Pink",        From = (140,  50, 150), To = (170, 255, 255) },
//            new() { ColorName = "Brown",       From = ( 10, 100,  50), To = ( 20, 255, 150) },
//            new() { ColorName = "White",       From = (  0,   0, 200), To = (180,  30, 255) },
//            new() { ColorName = "Black",       From = (  0,   0,   0), To = (180, 255,  50) },
//        };
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorData
{
    public class ColorRangeServices
    {
        public IList<ColorRangeModel> ColorRanges { get; set; }

        public ColorRangeServices()
        {
            ColorRanges = new List<ColorRangeModel>
            {
                // אדום - חוצה את נקודת האפס, נחלק לשני טווחים
                new() { ColorName = "Red",          From = (  0, 80, 80), To = ( 10, 255, 255) },
                new() { ColorName = "Red",          From = (350, 80, 80), To = (360, 255, 255) },
                
                // כתום
                new() { ColorName = "Orange",       From = ( 11, 70, 100), To = ( 40, 255, 255) },
                
                // צהוב
                new() { ColorName = "Yellow",       From = ( 41, 60, 150), To = ( 70, 255, 255) },
                
                // ירוק-צהוב
                new() { ColorName = "YellowGreen",  From = ( 71, 70, 100), To = ( 90, 255, 255) },
                
                // ירוק
                new() { ColorName = "Green",        From = ( 91, 70, 80), To = (150, 255, 255) },
                
                // ירוק-כחול (טורקיז)
                new() { ColorName = "Cyan",         From = (151, 60, 100), To = (180, 255, 255) },
                
                // כחול בהיר
                new() { ColorName = "LightBlue",    From = (181, 60, 120), To = (200, 255, 255) },
                
                // כחול
                new() { ColorName = "Blue",         From = (201, 80, 80), To = (260, 255, 255) },
                
                // כחול-סגול
                new() { ColorName = "BlueViolet",   From = (261, 70, 100), To = (280, 255, 255) },
                
                // סגול
                new() { ColorName = "Purple",       From = (281, 70, 80), To = (320, 255, 255) },
                
                // ורוד-סגול (מגנטה)
                new() { ColorName = "Magenta",      From = (321, 60, 120), To = (330, 255, 255) },
                
                // ורוד
                new() { ColorName = "Pink",         From = (331, 50, 150), To = (349, 255, 255) },
                
                // חום - גוון כתום עם רוויה ובהירות נמוכים יותר
                new() { ColorName = "Brown",        From = ( 20, 40,  30), To = ( 40, 100, 150) },
                
                // לבן - רוויה נמוכה, בהירות גבוהה
                new() { ColorName = "White",        From = (  0,  0, 200), To = (360,  30, 255) },
                
                // אפור - רוויה נמוכה, בהירות בינונית
                new() { ColorName = "Gray",         From = (  0,  0,  50), To = (360,  30, 180) },
                
                // שחור - בהירות נמוכה
                new() { ColorName = "Black",        From = (  0,  0,   0), To = (360, 255,  50) }
            };
        }
    }
}
