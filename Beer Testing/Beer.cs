using System;

namespace Beer_Testing
{
    public class Beer
    {
        private int _id;
        private string _name;
        private double _price;
        private double _abv;

        public Beer(int id, string name, double price, double abv)
        {
            this._id = id;
            this._name = name;
            this._price = price;
            this._abv = abv;
        }

        public string Name
        {
            get => _name;
            set
            {
                if (value == null) { throw new ArgumentNullException();}
                if (value.Length < 4) { throw new ArgumentException();}

                _name = value;
            }
        }

        public double Price
        {
            get => _price;
            set
            {
                if (value <= 0) { throw new ArgumentException();}

                _price = value;
            }
        }

        public double Abv
        {
            get => _abv;
            set
            {
                if (value < 0 || value > 100) throw new ArgumentOutOfRangeException();

                _abv = value;
            }
        }
    }
}
