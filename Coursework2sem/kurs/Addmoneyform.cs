using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurs
{
    public partial class Addmoneyform : Form
    {
        public Addmoneyform()
        {
            InitializeComponent();
        }
        Database DB = new Database();
        string balanceupdate = String.Format("INSERT INTO BalanceUpdates VALUES (@userid, @money, @datetime)");

        private void Addmoneyform_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm f1 = new MainForm();
            f1.Show();
        }

        private void Addmoneyform_Load(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(User.balance);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User.balance = User.balance + 100;
            label2.Text = Convert.ToString(User.balance);
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
                try
                {
                    SqlCommand cmd1 = new SqlCommand(balanceupdate, DB.getConnection());
                    cmd1.Parameters.AddWithValue("@userid", User.userid);
                    cmd1.Parameters.AddWithValue("@money", 100);
                    cmd1.Parameters.AddWithValue("@datetime", DateTime.Now);
                    DB.openConnection();
                    cmd1.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Данные о пополнении не добавлены!");
                }
                finally
                {
                    DB.closeConnection();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User.balance = User.balance + 1000;
            label2.Text = Convert.ToString(User.balance);
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
                try
                {
                    SqlCommand cmd1 = new SqlCommand(balanceupdate, DB.getConnection());
                    cmd1.Parameters.AddWithValue("@userid", User.userid);
                    cmd1.Parameters.AddWithValue("@money", 1000);
                    cmd1.Parameters.AddWithValue("@datetime", DateTime.Now);
                    DB.openConnection();
                    cmd1.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Данные о пополнении не добавлены!");
                }
                finally
                {
                    DB.closeConnection();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            User.balance = User.balance + 10000;
            label2.Text = Convert.ToString(User.balance);
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
                try
                {
                    SqlCommand cmd1 = new SqlCommand(balanceupdate, DB.getConnection());
                    cmd1.Parameters.AddWithValue("@userid", User.userid);
                    cmd1.Parameters.AddWithValue("@money", 10000);
                    cmd1.Parameters.AddWithValue("@datetime", DateTime.Now);
                    DB.openConnection();
                    cmd1.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Данные о пополнении не добавлены!");
                }
                finally
                {
                    DB.closeConnection();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
