using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Meat
    {
        private int is_ready = 0;
        public int Is_ready {
            get {
                return is_ready;
            }
        }
        public bool not_in_pieces
        {
            set;
            get;
        }

        public void get_heat() {
            if (is_ready < 10)
                is_ready++;
        }
    }

    class spice {
        public double Count { set; get;}
    }

    class vegs
    {
        public bool not_in_pieces
        {
            set;
            get;
        }

    }

    class rice {
        private int dirty = 10;
        public int Dirty {
            set {
                if (value > -1 && value < 11)
                    dirty = value;
            }
            get {
                return dirty;
            }
        }
        private int is_ready = 0;
        public int Is_ready
        {
            get
            {
                return is_ready;
            }
        }
    }

    class water {
        private int temperature = 0;
        public int Temperature{
            get {
                return temperature;
            }
        }

        public void get_heat() {
            if (temperature < 100)
                temperature++;
        }
    }

    class Knife {
        public void cut(Meat m, vegs v) {
            if (m.not_in_pieces)
                m.not_in_pieces = false;
            if(v.not_in_pieces)
                v.not_in_pieces = false;
        }
    }

    class Tap {

        public bool State
        {
            set;
            get;
        }

        public void wash(rice r) {
            if (State) {
                r.Dirty = 0;
            }
        }

        public water get_water() {
            if (State)
                return new water();
            else
                return null;
        }
    }

    class Pan {

        private water[] Water;
        private vegs Vegs;
        private Meat meat;
        private spice Spice;
        private rice Rice;

        public void Init() {
            Water = new water[2];
        }

        public void Add_water(water w) {
            for (int i = 0; i < Water.Length; i++) {
                if (Water[i] == null)
                {
                    Water[i] = w;
                    return;
                }

            }
        }

        public void Add_spice(spice s) {
            Spice = s;
        }

        public void Add_vegs(vegs v) {
            Vegs = v;
        }

        public void Add_meat(Meat m)
        {
            meat = m;
        }

        public void Add_rice(rice r)
        {
            Rice = r;
        }

        private bool Check() {
            if (Water.Length == 0)
                return false;
            if (meat == null)
                return false;
            if (Spice == null)
                return false;
            if (Rice == null)
                return false;
            for (int i = 0; i < Water.Length; i++)
            {
                if (Water[i] == null)
                    return false;
            }
            return true;
        }

        public bool Ready_to_go {
            get {
                return Check();
            }
        }

        public void Heating() {
            if (!Check())
                return;
            if (Water.Length > 0) {
                if (Water[0].Temperature < 100) {
                    for (int i = 0; i < Water.Length; i++) {
                        Water[i].get_heat();
                    }
                    bool flag = false;
                    switch (Water[0].Temperature) {
                        case 20: flag = true; break;
                        case 40: flag = true; break;
                        case 60: flag = true; break;
                        case 80: flag = true; break;
                        case 100: flag = true; break;

                    }
                    if (flag) {
                        meat.get_heat();
                    }
                }
                else
                    meat.get_heat();
            }
        }

        public bool Is_ready() {
            for (int i = 0; i < Water.Length; i++)
            {
                if (Water[i].Temperature < 100)
                    return false;
            }

            if (meat.Is_ready < 10)
                return false;
            return true;
        }

        public rice Get_food() {
            return Rice;
        }

    }

    class Stove {

        private Pan pan;
        public bool State {
            set;
            get;
        }
        public Pan Pan {
            set {
                pan = value;
            }
            get {
                return pan;
            }
        }

        public void Cook() {
            if (State) {
                while (!pan.Is_ready())
                    pan.Heating();
            }
        }

    }


}
