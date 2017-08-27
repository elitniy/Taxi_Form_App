using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxi_Form_App
{
    public partial class Form1 : Form
    {
        Taxi selectedTaxi;
        Client selectedClient;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Taxi.mytaxi.Add(new Taxi(textBox3.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox1.Text)));
            comboBox1.Items.Add(textBox3.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Client.myclient.Add(new Client(textBox4.Text, Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text)));
            comboBox2.Items.Add(textBox4.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (var taxi in Taxi.mytaxi)
            {
                if (comboBox1.SelectedItem.ToString() == taxi.Num)
                {
                    selectedTaxi = taxi;
                }
            }
            foreach (var client in Client.myclient)
            {
                if (comboBox2.SelectedItem.ToString() == client.Name)
                {
                    selectedClient = client;
                }
            }
            double distance = Math.Sqrt(Math.Pow((Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox6.Text)), 2) + Math.Pow((Convert.ToInt32(textBox2.Text) - Convert.ToInt32(textBox5.Text)), 2));
            double money = Math.Floor(distance * 0.3);
            textBox7.Text = "Gedish haggi: " + money.ToString() + "AZN";
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        class Taxi
        {
            public static List<Taxi> mytaxi = new List<Taxi>();
            public string Num { get; set; }
            public double TaxiX { get; set; }
            public double TaxiY { get; set; }
            public Taxi(string _num, int _x, int _y)
            {
                this.Num = _num;
                this.TaxiX = _x;
                this.TaxiY = _y;
                Taxi.mytaxi.Add(this);

            }
        }
        class Client
        {
            public static List<Client> myclient = new List<Client>();
            public string Name { get; set; }
            public double ClientX { get; set; }
            public double ClientY { get; set; }
            public Client(string _name, int _x, int _y)
            {
                this.Name = _name;
                this.ClientX = _x;
                this.ClientY = _y;
                Client.myclient.Add(this);

            }
        }
    }
}
