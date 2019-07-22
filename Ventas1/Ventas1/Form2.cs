using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Cliente = new Cliente();
            Cliente.Id = 1;
            Cliente.Nombre = "Eduardo Coello";
            Cliente.Telefono = "9875-2376";
            Cliente.Direccion = " Barrio Medina";
            var ciudad1 =  new Ciudad();

            var Cliente2 = new Cliente();
            Cliente2.Id = 2;
            Cliente2.Nombre = "Leonel Osorio";
            Cliente2.Telefono = "9737-1319";
            Cliente2.Direccion = "Colonia Modelo";
            var ciudad2 = new Ciudad();

            var Cliente3 = new Cliente();
            Cliente3.Id = 3;
            Cliente3.Nombre = "Wendy Ramos";
            Cliente3.Telefono = "9493-0868";
            Cliente3.Direccion = "Colonia Ideal";
            var ciudad3 = new Ciudad();

            var listadeClientes = new List<Cliente>();
            listadeClientes.Add(Cliente);
            listadeClientes.Add(Cliente2);
            listadeClientes.Add(Cliente3);

            foreach (var cliente in listadeClientes)
            {
                MessageBox.Show(cliente.Id + "\n" + cliente.Nombre + "\n" + cliente.Telefono + "\n" + cliente.Direccion +
                    "\n" + cliente.Ciudad);
            }




        }
    }
}
