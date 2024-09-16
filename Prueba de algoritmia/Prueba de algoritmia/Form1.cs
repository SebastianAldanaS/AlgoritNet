using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_de_algoritmia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnejec_Click(object sender, EventArgs e)
        {

            // 1) Recibir el tamaño de la lista (número entero) desde txtTamañoLista
            int tamañoLista = int.Parse(txtTamañoLista.Text);

            // 2) Recibir la lista base de números enteros desde txtListaBase, separada por espacios
            List<int> listaBase = txtListaBase.Text
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            // Validar que el número de elementos en la lista coincida con el tamaño ingresado
            if (listaBase.Count != tamañoLista)
            {
                MessageBox.Show("El número de elementos en la lista no coincide con el tamaño ingresado.");
                return;
            }

            // 3) Recibir el número de consultas (número entero) desde txtNumConsultas
            int numConsultas = int.Parse(txtNumConsultas.Text);

            // 4) Recibir la lista de números a consultar desde txtConsultas, separados por espacios
            List<int> consultas = txtConsultas.Text
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            // Validar que el número de consultas coincida con el valor ingresado
            if (consultas.Count != numConsultas)
            {
                MessageBox.Show("El número de consultas no coincide con el valor ingresado.");
                return;
            }

            // Procesar las consultas y almacenar los resultados
            StringBuilder resultado = new StringBuilder();

            foreach (int consulta in consultas)
            {
                // Encontrar el número mayor inferior a la consulta
                int mayorInferior = listaBase.Where(x => x < consulta).DefaultIfEmpty(-1).Max();
                // Encontrar el número menor superior a la consulta
                int menorSuperior = listaBase.Where(x => x > consulta).DefaultIfEmpty(-1).Min();

                // Si no hay número inferior o superior, colocar 'X'
                string menorInfStr = mayorInferior == -1 ? "X" : mayorInferior.ToString();
                string menorSupStr = menorSuperior == -1 ? "X" : menorSuperior.ToString();

                // Formar el resultado de la consulta
                resultado.AppendLine($"{menorInfStr} {menorSupStr}");
            }

            // Mostrar el resultado en un TextBox (txtResultado)
            txtResultado.Text = resultado.ToString();

        }
    }
}
