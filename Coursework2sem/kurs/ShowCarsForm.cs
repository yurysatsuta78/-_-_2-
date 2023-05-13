using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

namespace kurs
{
    public partial class ShowCarsForm : Form
    {
        public ShowCarsForm()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection();
        private void ShowCarsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Открыть начальную форму при нажатии на крестик
            MainForm f1 = new MainForm();
            f1.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            //Закрыть форму = нажать на крестик
            Close();
        }

        private void ShowCarsForm_Load(object sender, EventArgs e)
        {
            //Загружает в список объекты
            checkedListBox1.DataSource = List.carList;
            label5.Text = Convert.ToString(User.balance);
        }


        private void Buy_Click(object sender, EventArgs e)
        {
            foreach (Car item in checkedListBox1.CheckedItems) 
            {
                List.basket.Add(item);
                List.carList.Remove(item);
            }
            foreach (Car item in List.basket)
            {
                cn.ConnectionString = @"Data Source=HOME-PC;Initial Catalog=Sacuta-kurs;Integrated Security=True";
                cn.Open();
                string del = "DELETE FROM Car WHERE CarId =" + item.Carid;
                SqlCommand cmd = new SqlCommand(del, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            MessageBox.Show("Автомобиль(автомобили) добавлен(ы) в корзину!");
            checkedListBox1.DataSource = null;
            checkedListBox1.DataSource = List.carList;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex > -1 && checkedListBox1.SelectedIndex < List.carList.Count)
            {
                label3.Text = " Марка: " + List.carList[checkedListBox1.SelectedIndex].Brand
                              + "\n Модель: " + List.carList[checkedListBox1.SelectedIndex].Model
                              + "\n Год выпуска: " + List.carList[checkedListBox1.SelectedIndex].Year
                              + "\n Цена: " + List.carList[checkedListBox1.SelectedIndex].Price + " $"
                              + "\n Объем двигателя: " + List.carList[checkedListBox1.SelectedIndex].EngineVolume + " л"
                              + "\n Тип двигателя: " + List.carList[checkedListBox1.SelectedIndex].EngineType
                              + "\n Привод: " + List.carList[checkedListBox1.SelectedIndex].DriveUnit
                              + "\n Тип КПП: " + List.carList[checkedListBox1.SelectedIndex].Transmission
                              + "\n Номер телефона: " + List.carList[checkedListBox1.SelectedIndex].PhoneNumber;
                label2.Text = "Доп. информация: " + List.carList[checkedListBox1.SelectedIndex].Comment;
            }
        }

        private void Reloadbutton_Click(object sender, EventArgs e)
        {
            checkedListBox1.DataSource = null;
            checkedListBox1.DataSource = List.carList;
        }
    }
}
