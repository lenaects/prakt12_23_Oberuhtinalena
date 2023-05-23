using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)) return;

            string brand = textBox1.Text;
            int numCylinders = (int)numericUpDown1.Value;
            int power = (int)numericUpDown2.Value;

            Car newCar = new Car(brand, numCylinders, power, listBox1);

            // функция добавления данных об авто в listBox
            newCar.CarAddListBox();

            // функция печати данных об авто в MessageBox
            newCar.Print();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)) return;

            string brand = textBox1.Text;
            int numCylinders = (int)numericUpDown1.Value;
            int power = (int)numericUpDown2.Value;
            double payload = (double)numericUpDown3.Value;

            Truck newTruck = new Truck(brand, numCylinders, power, listBox1, payload);

            // функция переназначения марки
            newTruck.SetBrand("MAN");

            // функция переназначения грузоподъемности
            newTruck.SetPayload(1200);

            // функция добавления данных об грузовике в listBox
            newTruck.TruckAddListBox();

            // функция печати данных об грузовике в MessageBox
            newTruck.Print();
        }
    }
}
