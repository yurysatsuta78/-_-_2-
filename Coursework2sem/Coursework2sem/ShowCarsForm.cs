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
        Database DB = new Database(); 
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
            if (checkedListBox1.CheckedItems.Count > 0)
            {
                    foreach (Car item in checkedListBox1.CheckedItems)
                    {
                        bool success = false;
                        string check = String.Format("Select * From Basket Where UserId = {0} And CarId = {1}", User.userid, item.Carid);
                        try
                        {
                            SqlCommand cmd = new SqlCommand(check, DB.getConnection());
                            DB.openConnection();
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                success = reader.Read();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка в проверке корзины!");
                        }
                        if (success == false)
                        {
                            string intobask = String.Format("Insert Into Basket Values ('{0}','{1}')", User.userid, item.Carid);
                            SqlCommand cmd0 = new SqlCommand(intobask, DB.getConnection());
                            DB.openConnection();
                            cmd0.ExecuteNonQuery();
                            DB.closeConnection();
                            MessageBox.Show("Автомобиль(и) добавлен(ы) в корзину");
                        }
                        else 
                        {
                            MessageBox.Show("Уже в корзине!");
                        }
                    }
                    List.BasketReload();
            }
            else 
            {
                return;
            }
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
            List.BasketReload();
            checkedListBox1.DataSource = null;
            checkedListBox1.DataSource = List.carList;
        }
    }
}
