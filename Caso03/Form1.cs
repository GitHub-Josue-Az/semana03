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
    public partial class Form1 : Form
    {
        Repository repository = new Repository();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Load(repository.listarCliente());
            dgForm01.DataSource = dt;
        }
    }
}
