using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kurs
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //Создаем 4 формы
        AddCarForm f2 = new AddCarForm();
        ShowCarsForm f4 = new ShowCarsForm();
        Basket f5 = new Basket();
        Addmoneyform f6 = new Addmoneyform();
        SqlConnection cn = new SqlConnection();

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            for(int i = 0; i < List.basket.Count; i++)
            {
                cn.ConnectionString = @"Data Source=HOME-PC;Initial Catalog=Sacuta-kurs;Integrated Security=True";
                cn.Open();
                string brand = List.basket[i].Brand;
                string model = List.basket[i].Model;
                int year = Convert.ToInt32(List.basket[i].Year);
                double price = Convert.ToDouble(List.basket[i].Price);
                double enginevolume = Convert.ToDouble(List.basket[i].EngineVolume);
                string enginetype = List.basket[i].EngineType;
                string comment = List.basket[i].Comment;
                string phonenumber = List.basket[i].PhoneNumber;
                string driveunit = List.basket[i].DriveUnit;
                string transmission = List.basket[i].Transmission;
                string strInsertCar = string.Format("INSERT INTO Car VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", brand, model, year, price, enginevolume, enginetype, comment, phonenumber, driveunit, transmission);
                SqlCommand cmdInsertCar = new SqlCommand(strInsertCar, cn);
                cmdInsertCar.ExecuteNonQuery();
                cn.Close();
            }
            List.basket.Clear();
            Application.Exit();
        }

        private void AddCar_Click(object sender, EventArgs e)
        {
            Hide();
            f2.Show();
        }


        private void ShowCars_Click(object sender, EventArgs e)
        {
            List.Reload();
            Hide();
            f4.Show();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(User.balance);
            label5.Text = User.login;
            //cn.ConnectionString = @"Data Source=HOME-PC;Initial Catalog=Sacuta-kurs;Integrated Security=True";
            //cn.Open();
            //string strCars = "Select * From Car";
            //SqlCommand cmdCars = new SqlCommand(strCars, cn);
            //SqlDataReader CarsDataReader = cmdCars.ExecuteReader();
            //List.carList.Clear();
            //while (CarsDataReader.Read())
            //{
            //    int carid = CarsDataReader.GetInt32(0);
            //    string brand = CarsDataReader.GetString(1);
            //    string model = CarsDataReader.GetString(2);
            //    int year = CarsDataReader.GetInt32(3);
            //    double price = CarsDataReader.GetDouble(4);
            //    string enginevolume = CarsDataReader.GetString(5);
            //    string enginetype = CarsDataReader.GetString(6);
            //    string comment = CarsDataReader.GetString(7);
            //    string phonenumber = CarsDataReader.GetString(8);
            //    string driveunit = CarsDataReader.GetString(9);
            //    string transmission = CarsDataReader.GetString(10);

            //    Car car = new Car(carid, brand, model, year, price, enginevolume, enginetype, driveunit, comment, phonenumber, transmission);
            //    List.AddCar(car);
            //}
            //cn.Close();
        }

        private void Basket_Click(object sender, EventArgs e)
        {
            Hide();
            f5.Show();
        }

        private void AddMoney_Click(object sender, EventArgs e)
        {
            Hide();
            f6.Show();
        }
    }
}
