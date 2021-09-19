using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLINQS
{
    public partial class btnbuscar : Form
    {
        public btnbuscar()
        {
            InitializeComponent();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            List<string> students = new List<string>() { "Jorge Flores", "Maria Osorios", "Galeo Callejas", "Ulises Judices", "Eduardo Alegria", "Mario Vallecillo", "Alvaro Leoncio", "Hernan Hernandez", "Tiago Benavides", "Dakota Albas,Humberto Calida" };
            string respuesta = txtestudiante.Text;
            bool busquedas = students.Contains(respuesta);
            if (busquedas == true)
            {
                MessageBox.Show(Convert.ToString(busquedas) + " Lo que quiere decir que " + respuesta + "si esta en el curso");
            }
            else
            {
                MessageBox.Show(Convert.ToString(busquedas) + " Lo que quiere decir que " + respuesta + "no esta en el  curso");
            }
        }
    }
}
