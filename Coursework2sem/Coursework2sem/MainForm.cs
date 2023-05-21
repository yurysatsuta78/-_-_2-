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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            List.BasketReload();
            Application.Exit();
        }

        private void AddCar_Click(object sender, EventArgs e)
        {
            Hide();
            f2.Show();
        }


        private void ShowCars_Click(object sender, EventArgs e)
        {
            Hide();
            f4.Show();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            List.Reload();
            List.BasketReload();
            label3.Text = Convert.ToString(User.balance);
            label5.Text = User.login;
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
