using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3sharpNEW
{
	class ParkingIndexOutOfRangeException : Exception
	{
		public ParkingIndexOutOfRangeException():base("Нет такого места"){ }
		//fileName="C://Users//user//Desktop//log.txt" />
	}
}
