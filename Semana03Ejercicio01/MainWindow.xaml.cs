using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Semana03Ejercicio01
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ClsDatos obj = new ClsDatos();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void DgvPedido_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int idPedido;

            //SELECCION DE UNA FILA
            var item = dgvPedido.SelectedItem as DataRowView;

            //EN CASO SELECCIONE UNA FILA NULA
            if (null == item) return;

            //METE LA FILA SELECCIONADA EN UNA VARIABLE DE TIPO ENTERA
            idPedido = Convert.ToInt32(item.Row["IdPedido"]);
            
            dgvDetallePedido.ItemsSource = obj.ListarDetalle(idPedido).DefaultView;

            txtTotal.Text = Convert.ToString(obj.PedidoTotal(idPedido));
        }
        

        private void BtnConsultar_Click(Object sender, RoutedEventArgs e)
        {
            //TOMA LA  FECHA DE INICIO - LA FECHA DE FIN  Y LO METE EN LA FUNCION LISTAPEDIDOS
            dgvPedido.ItemsSource = obj.ListaPedidoFechas(Convert.ToDateTime(txtFechaInicio.Text),
                Convert.ToDateTime(txtFechaFin.Text)).DefaultView;
        }
        


    }
}
