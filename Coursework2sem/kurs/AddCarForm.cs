using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kurs
{
    public partial class AddCarForm : Form
    {
        public AddCarForm()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection();

        private void CloseForm2_Click(object sender, EventArgs e)
        {
            //Закрыть форму = нажать на крестик
            Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm f1 = new MainForm();
            f1.Show();
        }

        private void AddYourCar_Click(object sender, EventArgs e)
        {
            //Заполнение информации об объекте
            if (Brand.Text == string.Empty || Model.Text == string.Empty || Year.Text == string.Empty || Price.Text == string.Empty || EngineVolume.Text == string.Empty || EngineType.Text == string.Empty || DriveUnit.Text == string.Empty || Number.Text == string.Empty)
            {
                return;
            }
            else
            {
                if (Comment.Text == string.Empty)
                {
                    Comment.Text = " ";
                }
                try
                {
                    cn.ConnectionString = @"Data Source=HOME-PC;Initial Catalog=Sacuta-kurs;Integrated Security=True";
                    cn.Open();
                    string brand = Brand.Text;
                    string model = Model.Text;
                    int year = Convert.ToInt32(Year.Text);
                    double price = Convert.ToDouble(Price.Text);
                    double enginevolume = Convert.ToDouble(EngineVolume.Text);
                    string enginetype = EngineType.Text;
                    string comment = Comment.Text;
                    string phonenumber = Number.Text;
                    string driveunit = DriveUnit.Text;
                    string transmission = Transmission.Text;
                    string strInsertCar = string.Format("INSERT INTO Car VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", brand, model, year, price, enginevolume, enginetype, comment, phonenumber, driveunit, transmission);
                    SqlCommand cmdInsertCar = new SqlCommand(strInsertCar, cn);
                    cmdInsertCar.ExecuteNonQuery();
                    cn.Close();
                }
                catch
                {
                    MessageBox.Show("Не удалось добавить объявление!");
                }
                finally
                {
                    MessageBox.Show("Объявление добавлено");
                    Close();
                }
            }
        }

        private void Brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Показать модели при выборе марки
            if (Brand.SelectedItem is "Mazda")
            {
                Model.DataSource = List.mazdacarModels;
            }
            if (Brand.SelectedItem is "Nissan")
            {
                Model.DataSource = List.nissancarModels;
            }
            if (Brand.SelectedItem is "Toyota")
            {
                Model.DataSource = List.toyotacarModels;
            }
            if (Brand.SelectedItem is "Audi")
            {
                Model.DataSource = List.audicarModels;
            }
            if (Brand.SelectedItem is "Lada(ВАЗ)")
            {
                Model.DataSource = List.ladacarModels;
            }
            if (Brand.SelectedItem is "Mitsubishi")
            {
                Model.DataSource = List.mitsubishicarModels;
            }
            if (Brand.SelectedItem is "Citroen")
            {
                Model.DataSource = List.citroencarModels;
            }
            if (Brand.SelectedItem is "Opel")
            {
                Model.DataSource = List.opelcarModels;
            }
            if (Brand.SelectedItem is "BMW")
            {
                Model.DataSource = List.bmwcarModels;
            }
            if (Brand.SelectedItem is "Subaru")
            {
                Model.DataSource = List.subarucarModels;
            }
            if (Brand.SelectedItem is "Volkswagen")
            {
                Model.DataSource = List.volkswagencarModels;
            }
        }

        private void Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Разрешить вводить только цифры
            if (char.IsNumber(e.KeyChar) | e.KeyChar == '\b') return;
            else e.Handled = true;
        }

        private void PhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Разрешить вводить только цифры и +
            if (char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar("+")) | e.KeyChar == '\b') return;
            else e.Handled = true;
        }

        private void Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Разрешить вводить только цифры и +
            if (char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar("+")) | e.KeyChar == '\b') return;
            else e.Handled = true;
        }
    }
}
