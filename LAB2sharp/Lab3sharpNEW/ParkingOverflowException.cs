using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3sharpNEW
{
	class ParkingOverflowException : Exception
	{
		public ParkingOverflowException():base("Нет мест"){ }
		
	}
}
