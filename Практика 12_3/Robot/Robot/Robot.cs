using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
	internal class Robot
	{
		public int kollife;
		public int Getlife() { return kollife; }

		public void min(int a)
		{
			Random rn1 = new Random();
			kollife = a;
			kollife = rn1.Next(0, (a * 70 / 100));
		}
		public void kol(int a, int k)
		{
			if (k == a / 2)
			{
				kollife += 30;
			}
			else if (k == a * 0.7)
			{
				kollife += 20;
			}
			else if (k >= a / 2 && k < a * 0.7)
			{
				kollife += 40;
			}
			else if (k < a / 2 && k > 0)
			{
				kollife += 50;
			}
			else if (k == 0)
			{
				kollife += 100;
			}
		}
	}
}
