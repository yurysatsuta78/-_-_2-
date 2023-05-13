using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs
{
    internal class Transport
    {
        #region поля
        string brand;
        string model;
        int year;
        double price;
        string enginevolume;
        string enginetype;
        string comment;
        string phonenumber;
        #endregion

        #region свойства
        public string Brand { get { return brand; } }
        public string Model { get { return model; } }
        public int Year { get { return year; } }
        public double Price { get { return price; } }
        public string EngineVolume { get { return enginevolume; } }
        public string EngineType { get { return enginetype; } }
        public string Comment { get { return comment; } }
        public string PhoneNumber { get { return phonenumber; } }
        #endregion

        #region конструкторы
        public Transport(string brand, string model, int year, double price, string enginevolume, string enginetype, string comment, string phonenumber)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.price = price;
            this.enginevolume = enginevolume;
            this.enginetype = enginetype;
            this.comment = comment;
            this.phonenumber = phonenumber;
        }
        public Transport(string brand, string model, int year) 
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
        }
        #endregion
    }
}
