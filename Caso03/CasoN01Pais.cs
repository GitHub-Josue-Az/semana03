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
    public partial class CasoN01Pais : Form
    {
        Repository repository = new Repository();

        public CasoN01Pais()
        {
            InitializeComponent();
        }

        private void CasoN01Pais_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = repository.listaPais();
        }
    }
}
