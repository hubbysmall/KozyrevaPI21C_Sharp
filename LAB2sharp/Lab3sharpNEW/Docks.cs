using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3sharpNEW
{
    class Docks<T> where T : ITransport
    {
        private Dictionary<int, T> docks;
        private T defaultVal;
        private int maxCount;

        public Docks(int size, T defV)
        {
            defaultVal = defV;
            docks = new Dictionary<int, T>();
            maxCount = size;
           
        }

        public static int operator +(Docks<T> plc, T ship)
        {
            if (plc.docks.Count == plc.maxCount)
                return -1;
            for(int i=0; i<plc.docks.Count; i++)
            {
                if (plc.checkIfFree(i))
                {
                    plc.docks.Add(i, ship);
                    return i;
                }
            }
            plc.docks.Add(plc.docks.Count, ship);
            return plc.docks.Count - 1;
        }

        public static T operator -(Docks<T> plc, int index)
        {
            if (plc.docks.ContainsKey(index))
            {
                T ship = plc.docks[index];
                plc.docks.Remove(index);
                return ship;
            }
            return plc.defaultVal;
        }

        private bool checkIfFree(int index)
        {
            return !docks.ContainsKey(index);
        }
        public T this[int indx]
        {
            get
            {
                if (docks.ContainsKey(indx))
                    return docks[indx];
                return defaultVal;
            }
        }

    }
}
