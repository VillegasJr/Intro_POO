using Core.clases;
using Core.interfaces.Repositorios;

namespace Market
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Venta venta = new Venta();

        private void Bt_Cobrar_Click(object sender, EventArgs e)
        {
            // Instancia de la clase RProductos
            RProductos rProducto = new RProductos();

            // Obtener los valores de los TextBox
            string IDProducto = textBox1.Text;
            string cantidad = textBox2.Text;

            // Instancia de la clase VentaProductos y asignación de valores
            VentaProductos vPrd = new VentaProductos();
            vPrd.Cantidad = Convert.ToDecimal(cantidad);
            vPrd.Producto = rProducto.ObtenerID(Convert.ToInt32(IDProducto));
            
            venta.AgregraProducto(vPrd.Producto, vPrd.Cantidad);

        }
    }
}
