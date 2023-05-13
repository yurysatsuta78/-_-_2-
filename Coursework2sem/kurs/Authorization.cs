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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }
        MainForm f1 = new MainForm();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            string userlogin = LoginAuth.Text;
            string userpassword = PasswordAuth.Text;
            bool success = false;
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=HOME-PC;Initial Catalog=Sacuta-kurs;Integrated Security=True";
            string usrs = "SELECT * FROM Users WHERE Login = @userlogin AND Password collate Cyrillic_General_CS_AS = @userpassword";
            try
            {
                SqlCommand cmd = new SqlCommand(usrs, cn);
                cmd.Parameters.AddWithValue("@userlogin", userlogin);
                cmd.Parameters.AddWithValue("@userpassword", userpassword);
                cn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    success = reader.Read();
                }
            }
            finally 
            {
                cn.Close();
            }
            if (success)
            {
                SqlCommand cmd = new SqlCommand(usrs, cn);
                cmd.Parameters.AddWithValue("@userlogin", userlogin);
                cmd.Parameters.AddWithValue("@userpassword", userpassword);
                cn.Open();
                using (SqlDataReader reader2 = cmd.ExecuteReader())
                {
                    while (reader2.Read())
                    {
                        User.userid = reader2.GetInt32(0);
                        User.login = reader2.GetString(3);
                        User.balance = reader2.GetDouble(5);
                    }
                }
                cn.Close();
                MainForm f1 = new MainForm();
                f1.Show();
                Hide();
            }
            else 
            {
                if (LoginAuth.Text == String.Empty || PasswordAuth.Text == String.Empty)
                {
                    return;
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.ShowDialog();           
        }
    }
}
