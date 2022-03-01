using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComp_Oops
{
    internal class Line_Comparison
    {
		public static void Cal_Length()
		{
			int x1, x2, y1, y2;
			double dis;
			x1 = 2; y1 = 2; x2 = 5; y2 = 5;
			dis = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
			Console.WriteLine("\n Length of line of coordinates" + "(" + x1 + "," + y1 + ")," + "(" + x2 + "," + y2 + ") is equal to " + dis);
		}
	}
}
