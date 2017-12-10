using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
   public class myEventArgs : EventArgs
    {
	 	private   string str;
		public myEventArgs(string S)
		{
			str = S;
		}
        public string myString
        {
            get
            {
                return str;
            }
        }
    }
}
