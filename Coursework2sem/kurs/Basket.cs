using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace kurs
{
    public partial class Basket : Form
    {
        public Basket()
        {
            InitializeComponent();
        }
        Database DB = new Database();

        private void Basket_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm f1 = new MainForm();
            f1.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Basket_Load(object sender, EventArgs e)
        {
            basketList.DataSource = List.basket;
            label4.Text = Convert.ToString(User.balance);
            List.allprice = 0;
            foreach (Car item in List.basket) 
            {
                List.allprice = List.allprice + item.Price;
            }
            label6.Text = Convert.ToString(List.allprice);
        }

        private void Buy_Click(object sender, EventArgs e)
        {
            if (User.balance > List.allprice)
            {
                User.balance = User.balance - List.allprice;
                foreach (Car item in List.basket)
                {
                    int userid = User.userid;
                    string brand = item.Brand;
                    string model = item.Model;
                    int year = item.Year;
                    double price = item.Price;
                    DateTime date = DateTime.Now;
                    string neword = string.Format("INSERT INTO Basket VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", userid, brand, model, year, price, date);
                    SqlCommand cmd0 = new SqlCommand(neword, DB.getConnection());
                    DB.openConnection();
                    cmd0.ExecuteNonQuery();
                    DB.closeConnection();
                }
                string addmoney = String.Format("UPDATE Users SET Balance = @balance WHERE UserID = @userid");
                try
                {
                    SqlCommand cmd = new SqlCommand(addmoney, DB.getConnection());
                    cmd.Parameters.AddWithValue("@balance", User.balance);
                    cmd.Parameters.AddWithValue("@userid", User.userid);
                    DB.openConnection();
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Что-то пошло не так!");
                }
                finally
                {
                    DB.closeConnection();
                }
                MessageBox.Show("Спасибо за покупку!");
                List.basket.Clear();
                Close();
            }
            else MessageBox.Show("Недостаточно средств!");
        }

        private void Nametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Deletefrombasket_Click(object sender, EventArgs e)
        {
            string brand = List.basket[basketList.SelectedIndex].Brand;
            string model = List.basket[basketList.SelectedIndex].Model;
            int year = Convert.ToInt32(List.basket[basketList.SelectedIndex].Year);
            double price = Convert.ToDouble(List.basket[basketList.SelectedIndex].Price);
            string enginevolume = List.basket[basketList.SelectedIndex].EngineVolume;
            string enginetype = List.basket[basketList.SelectedIndex].EngineType;
            string comment = List.basket[basketList.SelectedIndex].Comment;
            string phonenumber = List.basket[basketList.SelectedIndex].PhoneNumber;
            string driveunit = List.basket[basketList.SelectedIndex].DriveUnit;
            string transmission = List.basket[basketList.SelectedIndex].Transmission;
            string strInsertCar = string.Format("INSERT INTO Car VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", brand, model, year, price, enginevolume, enginetype, comment, phonenumber, driveunit, transmission);
            SqlCommand cmdInsertCar = new SqlCommand(strInsertCar, DB.getConnection());
            DB.openConnection();
            cmdInsertCar.ExecuteNonQuery();
            DB.closeConnection();
            List.basket.Remove((Car)basketList.SelectedItem);
            basketList.DataSource = null;
            basketList.DataSource = List.basket;
            List.allprice = 0;
            foreach (Car item in List.basket)
            {
                List.allprice = List.allprice + item.Price;
            }
            label6.Text = Convert.ToString(List.allprice);
            label8.Text = " ";
        }

        private void basketList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (basketList.SelectedIndex > -1 && basketList.SelectedIndex < List.basket.Count)
            {
                label8.Text = Convert.ToString(List.basket[basketList.SelectedIndex].Price);
            }
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            basketList.DataSource = null;
            basketList.DataSource = List.basket;
        }
    }
}
