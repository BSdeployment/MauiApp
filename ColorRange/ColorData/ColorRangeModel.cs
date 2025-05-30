using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorData
{
   public class ColorRangeModel
    {
        public string ColorName { get; set; }

        public (int H, int S, int V) From { get; set; }
        public (int H, int S, int V) To { get; set; }

        // טקסטים לבינדינג
        public string FromText => $"{From.H} {From.S} {From.V}";
        public string ToText => $"{To.H} {To.S} {To.V}";

        public string RangeAsString => $"{FromText} - {ToText}";

        // שימושי להדפסות Log-Debug
        public override string ToString() => $"{ColorName}: {RangeAsString}";
    }
}
