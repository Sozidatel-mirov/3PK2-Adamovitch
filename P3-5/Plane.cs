using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_5
{
    internal class Plane : ICloneable
    {
        private int number;
        private string pilot = "";
        private Garage garage = new Garage(16);

        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public string Pilot
        {
            get
            {
                return pilot;
            }
            set { pilot = value; }
        }
        public Garage Garage
        {
            get { return garage; }
            set { garage = value; }

        }

        public Plane(int number, string pilot, Garage garage)
        {
            Number = number;
            Pilot = pilot;
            Garage = garage;
        }

        public object Clone() => new Plane(Number, Pilot, new Garage(garage.num));

        public override string ToString()
        {
            return $"Самолёт №{number}\nПилот {pilot}\nГараж №{garage}";
        }

    }
    internal class Planetwo : IComparable<Planetwo>
    {
        private int number;
        private string pilot = "";
        private Garage garage = new Garage(16);

        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public string Pilot
        {
            get
            {
                return pilot;
            }
            set { pilot = value; }
        }
        public Garage Garage
        {
            get { return garage; }
            set { garage = value; }

        }

        public Planetwo(int number, string pilot, Garage garage)
        {
            Number = number;
            Pilot = pilot;
            Garage = garage;
        }

        public int CompareTo(Planetwo? person)
        {
            if (person is null) throw new ArgumentException("Некорректное значение параметра");
            return pilot.CompareTo(person.pilot);
        }


        public override string ToString()
        {
            return $"Самолёт №{number}\nПилот {pilot}\nГараж №{garage}";
        }

    }
}
