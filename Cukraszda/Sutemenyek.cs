using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cukraszda
{
	class Sutemenyek
	{
		public string nev { get; private set; }
		public int ar { get; private set; }

		public Sutemenyek(string sor)
		{
			string[] d = sor.Split(';');
			nev = d[0];
			ar = Convert.ToInt32(d[1]);
		}
	}
}
