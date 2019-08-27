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
    public partial class Caso04 : Form
    {
        Repository repository = new Repository();
        public Caso04()
        {
            InitializeComponent();
        }

        private void Caso04_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = repository.ListaEmpleados();
        }
    }
}
