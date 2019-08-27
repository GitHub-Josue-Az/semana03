using Caso03.Models;
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
    public partial class CasoN02Proveedores : Form
    {
        Repository repository = new Repository();
        public CasoN02Proveedores()
        {
            InitializeComponent();
        }

        private void CasoN02Proveedores_Load(object sender, EventArgs e)
        {
            List<Proveedor> proveedors = repository.ListarProveedores();
            dgProveedores.DataSource = proveedors;
            txtTotal.Text = proveedors.Count().ToString();
        }
    }
}
