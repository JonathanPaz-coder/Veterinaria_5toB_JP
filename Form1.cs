using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria_5toB_JP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                pictureBox1.Image = Properties.Resources.perro;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                pictureBox1.Image = Properties.Resources.gato;
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                pictureBox1.Image = Properties.Resources.tortuga;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                pictureBox1.Image = Properties.Resources.pajaro;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Chequeo rutinario");
            comboBox1.Items.Add("Vacunas");
            comboBox1.Items.Add("Enfermedad");
            comboBox1.Items.Add("Otros");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Mostrar el sexo del animal (RadioButtons)
            if (radioButton1.Checked == true)
            {
                listBox1.Items.Add("SEXO: " + radioButton1.Text);
            }
            else if (radioButton2.Checked == true)
            {
                listBox1.Items.Add("SEXO: " + radioButton2.Text);
            }

            //Mostar el tipo de animal (CheckBox)
            if (checkBox1.Checked == true)
            {
                listBox1.Items.Add("TIPO: " + checkBox1.Text);
            }
            else if (checkBox2.Checked == true)
            {
                listBox1.Items.Add("TIPO: " + checkBox2.Text);
            }
            else if (checkBox3.Checked == true)
            {
                listBox1.Items.Add("TIPO: " + checkBox3.Text);
            }
            else if (checkBox4.Checked == true)
            {
                listBox1.Items.Add("TIPO: " + checkBox4.Text);
            }
            //Motivo de la visita (ComboBox)
            string elemento = comboBox1.Text;

            if (elemento == "Chequeo rutinario")
            {
                listBox1.Items.Add("MOTIVO: " + elemento);
            }
            else if (elemento == "Vacunas")
            {
                listBox1.Items.Add("MOTIVO: " + elemento);
            }
            else if (elemento == "Enfermedad")
            {
                listBox1.Items.Add("MOTIVO: " + elemento);
            }
            else if (elemento == "Otros")
            {
                listBox1.Items.Add("MOTIVO: " + elemento);
            }

            //Elegir fecha (MonthCalendar)
            listBox1.Items.Add("FECHA: " + monthCalendar1.SelectionStart.ToShortDateString());
            listBox1.Items.Add("");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }
    }
}
