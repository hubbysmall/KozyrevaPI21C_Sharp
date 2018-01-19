using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2sharp
{
    class Docks<T> where T : ITransport
    {
        private T[] places;
        private T defaultVal;

        public Docks(int size, T defV)
        {
            defaultVal = defV;
            places = new T[size];
            for (int i = 0; i < places.Length; i++)
            {
                places[i] = defaultVal;
            }
        }

        public static int operator +(Docks<T> plc, T ship)
        {
            for (int i = 0; i < plc.places.Length; i++)
            {
                if (plc.checkIfFree(i))
                {
                    plc.places[i] = ship;
                    return i;
                }

            }
            return -1;
        }

        public static T operator -(Docks<T> plc, int index)
        {
            if (!plc.checkIfFree(index))
            {
                T ship = plc.places[index];
                plc.places[index] = plc.defaultVal;
                return ship;
            }
            return plc.defaultVal;
        }

        private bool checkIfFree(int index)
        {
            if (index < 0 || index > places.Length)
                return false;
            if (places[index] == null)
                return true;
            if (places[index].Equals(defaultVal))
                return true;
            return false;
        }

        public T getShip(int index)
        {
            if (index >= 0 && index < places.Length)
                return places[index];
            return defaultVal;
        }
    }
}
