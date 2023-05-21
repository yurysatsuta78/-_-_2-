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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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
                    int carid = item.Carid;
                    DateTime date = DateTime.Now;
                    string neword = string.Format("INSERT INTO Paid VALUES ('{0}','{1}','{2}')", userid, carid, date);
                    string buycar = string.Format("Update Car Set Sold = 1 Where CarId = {0}", carid);
                    string delfrombask = string.Format("Delete From Basket Where CarId = {0}", carid);
                    SqlCommand cmd = new SqlCommand(neword, DB.getConnection());
                    SqlCommand cmd0 = new SqlCommand(buycar, DB.getConnection());
                    SqlCommand cmd1 = new SqlCommand(delfrombask, DB.getConnection());
                    DB.openConnection();
                    cmd.ExecuteNonQuery();
                    cmd0.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
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
                List.Reload();
                List.BasketReload();
                Close();
            }
            else MessageBox.Show("Недостаточно средств!");
        }

        private void Nametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Deletefrombasket_Click(object sender, EventArgs e)
        {
            foreach (Car item in basketList.SelectedItems) 
            {
                string delfrombask = string.Format("Delete From Basket Where CarId = {0}", item.Carid);
                SqlCommand baskdel = new SqlCommand(delfrombask, DB.getConnection());
                DB.openConnection();
                baskdel.ExecuteNonQuery();
                DB.closeConnection();
            }
            List.BasketReload();
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
