using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WindowsFormsApp1
{
    public class Car
    {
        protected string Brand;
        protected int NumCylinders;
        protected int Power;
        protected ListBox listBox;

        public Car(string brand, int numCylinders, int power, ListBox listBox)
        {
            this.Brand = brand;
            this.NumCylinders = numCylinders;
            this.Power = power;
            this.listBox = listBox;
        }

        public void Print()
        {
            MessageBox.Show($"Бренд: {Brand}\nЧисло цилиндров: {NumCylinders}\nМощность: {Power}лс/т");
        }

        public void CarAddListBox()
        {
            listBox.Items.Add($"Марка - {Brand}: {NumCylinders} цил., {Power}лс/т");
        }
        ~Car() { }
    }
    public class Truck : Car
    {
        public double Payload;

        public Truck(string brand, int numCylinders, int power, ListBox listBox, double payload) : base(brand, numCylinders, power, listBox)
        {
            this.Payload = payload;
        }

        public new void Print()
        {
            base.Print();
            PrintPayload();
        }
        public void PrintPayload()
        {
            MessageBox.Show($"Грузоподъемность: {Payload}");
        }
        public void TruckAddListBox()
        {
            listBox.Items.Add($"Марка - {Brand}: {NumCylinders} цил., {Power}лс/т (грузоподьемность: {Payload})");
        }
        public void SetBrand(string brand)
        {
            this.Brand = brand;
        }
        public void SetPayload(double payload)
        {
            this.Payload = payload;
        }
        ~Truck() { }
    }
}
