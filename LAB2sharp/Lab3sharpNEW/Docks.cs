using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3sharpNEW
{
    class Docks<T>  :  IEnumerator<T>, IEnumerable<T>, IComparable<Docks<T>> where T : ITransport
    {
        private Dictionary<int, T> docks;
        private T defaultVal;
        private int maxCount;

        private int currentIndex;

        public T Current
        {
            get
            {
                return docks[docks.Keys.ToList()[currentIndex]];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            if (currentIndex + 1 >= docks.Count)
            {
                Reset();
                return false;
            }
            currentIndex++;
            return true;
        }

        public void Reset()
        {
            currentIndex = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int CompareTo(Docks<T> other)
        {
            if (this.Count() > other.Count())
                return -1;
            else if (this.Count() < other.Count())
                return 1;
            else
            {
                var thisKeys = this.docks.Keys.ToList();
                var otherKeys = other.docks.Keys.ToList();
                for (int i = 0; i < this.docks.Count; i++)
                {
                    if (this.docks[thisKeys[i]] is Boat && other.docks[thisKeys[i]] is Sailing_ship)
                        return 1;
                    if (this.docks[thisKeys[i]] is Sailing_ship && other.docks[thisKeys[i]] is Boat)
                        return -1;
                    if (this.docks[thisKeys[i]] is Boat && other.docks[thisKeys[i]] is Boat)
                    {
                        return (this.docks[thisKeys[i]] is Boat).CompareTo(other.docks[thisKeys[i]] is Boat);
                    }
                    if (this.docks[thisKeys[i]] is Sailing_ship && other.docks[thisKeys[i]] is Sailing_ship)
                    {
                        return (this.docks[thisKeys[i]] is Sailing_ship).CompareTo(other.docks[thisKeys[i]] is Sailing_ship);
                    }

                }
            }
            return 0;
        }

        public Docks(int size, T defV)
        {
            defaultVal = defV;
            docks = new Dictionary<int, T>();
            maxCount = size;
           
        }

        public static int operator +(Docks<T> plc, T ship)
        {
            var isSailingShip = ship is Sailing_ship;
			if (plc.docks.Count == plc.maxCount)
				throw new ParkingOverflowException();
            int index = plc.docks.Count;




            for (int i=0; i<plc.docks.Count; i++)
            {
                if (plc.checkIfFree(i))
                {   
                    index = i;
                }
                if(ship.GetType()==plc.docks[i].GetType())
                {
                    if (isSailingShip)
                    {
                        if ((ship as Sailing_ship).Equals(plc.docks[i]))
                            throw new PortAlreadyHaveException();
                    }
                    else if((ship as Boat).Equals(plc.docks[i]))
                        throw new PortAlreadyHaveException();
                }
            }
            if (index != plc.docks.Count)
            {
                plc.docks.Add(index, ship);
                return index;
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
			throw new ParkingIndexOutOfRangeException();
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
