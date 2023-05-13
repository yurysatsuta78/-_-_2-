using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace kurs
{
    internal class Car : Transport
    {
        #region поля
        int carid;
        string driveunit;
        string transmission;
        #endregion

        #region свойства
        public int Carid { get { return carid; } }
        public string DriveUnit {get { return driveunit; } }
        public string Transmission{ get { return transmission; } }
        #endregion

        #region конструкторы
        public Car(int carid, string brand, string model, int year, double price, string enginevolume, string enginetype, string driveunit, string comment, string phonenumber, string transmission)
            : base(brand, model, year, price, enginevolume, enginetype, comment, phonenumber) 
        {
            this.carid = carid;
            this.driveunit = driveunit;
            this.transmission = transmission;
        }

        public Car(string brand, string model, int year)
            : base(brand, model, year) 
        {

        }
        #endregion

        public override string ToString()
        {
            string st = string.Format("{0} {1} /  {2} г", Brand, Model, Year);
            return st;
        }
    }
}
