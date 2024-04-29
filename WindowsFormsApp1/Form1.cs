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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*
            txtfechainicio.Text=FechaInicio.SelectionRange.ToString
            txtfechafin.Text = Fechafin.SelectionRange.ToString


            txtfechainicio.Text = FechaInicio.SelectionStart.Date
            txtfechafin.Text=FechaFin.SelectionRange.end


            

            TxtRangoFecha.Text=CalendarFecha.SelectionRange.ToString

            TxtFechaInicioCalendar.Text=CalendarFecha.SelectionStart.Date

            TxtFechaFinCalendar.Text=CalendarFecha.SelectionRange.End

            */

            DateTime inicio = CalendarFecha.SelectionStart;
            DateTime fin = CalendarFecha.SelectionEnd;

            TxtFechaInicioCalendar.Text = inicio.ToString();
            TxtFechaFinCalendar.Text = fin.ToString();



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void TxtRangoFecha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
