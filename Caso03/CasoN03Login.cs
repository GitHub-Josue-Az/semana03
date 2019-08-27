using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caso03
{
    public partial class CasoN03Login : Form
    {
        Repository repository = new Repository();

        public CasoN03Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contra = textBox2.Text;

            if (repository.Login(usuario,contra))
            {
                MessageBox.Show("Bienvenido a la aplicación");
            }
            else
            {
                MessageBox.Show("Error de Autenticacion");
            }
        }
    }
}
