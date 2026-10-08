using Core.clases;
using Core.interfaces.Repositorios;

namespace Market
{
    public partial class Form1 : Form
    {
        private Empleado empleadoLogueado;
        private Venta venta;

        // Constructor que se ejecuta cuando inicias sesión
        public Form1(Empleado empleado)
        {
            InitializeComponent();
            this.empleadoLogueado = empleado;

            // La Venta recibe el objeto Empleado completo (con el ID obtenido de MySQL)
            this.venta = new Venta(this.empleadoLogueado);
        }

        // Constructor por defecto (para pruebas directas)
        public Form1()
        {
            InitializeComponent();

            // Si pruebas ejecutando directamente Form1 sin login, obtienes el empleado 159753:
            REmpleado rEmpleado = new REmpleado();
            this.empleadoLogueado = rEmpleado.Verificacion("159753");
            this.venta = new Venta(this.empleadoLogueado);
        }

        private void Bt_Agregar_Click_1(object sender, EventArgs e)
        {
            // 1. Validar entradas de texto
            if (!int.TryParse(textBox1.Text, out int idProducto)) // Validar que el ID del producto sea un número entero
            // El out int idProducto crea una variable temporal para almacenar el valor convertido si la conversión es exitosa
            {
                MessageBox.Show("Por favor, ingrese un ID de producto válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(textBox2.Text, out decimal cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Por favor, ingrese una cantidad mayor a cero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Consultar el producto en BD
            RProductos rProducto = new RProductos();
            var response = rProducto.ObtenerID(idProducto);

            if (response.Codigo == 200 && response.Datos != null)
            {
                Producto producto = response.Datos;

                // 3. Agregar a la entidad Venta
                venta.AgregarProducto(producto, cantidad);

                // 4. Actualizar el DataGridView (Refresco de DataBinding)
                dataGridView1.DataSource = null; // Limpiar el DataGridView
                dataGridView1.DataSource = venta.productos; // Asignar la lista actualizada

                // 5. Actualizar la etiqueta del Total
                label6.Text = venta.total.ToString("C2"); // Formato moneda ($)

                // Limpiar entradas
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            else if (response.Codigo == 404)
            {
                MessageBox.Show("Error: " + response.Mensaje, "Producto no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al obtener el producto: " + response.Mensaje, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Bt_Cobrar_Click(object sender, EventArgs e)
        {
            if (venta.productos == null || venta.productos.Count == 0)
            {
                MessageBox.Show("No hay productos agregados en la venta actual.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RVentas rVentas = new RVentas();
            var response = rVentas.RegistrarVenta(venta);

            if (response.Codigo == 200)
            {
                MessageBox.Show(
                    $"Venta registrada correctamente.\nAtendió: {venta.empleado.Nombre}\nCódigo: {venta.codigoVenta}",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Reiniciar la venta conservando el empleado activo
                venta = new Venta(empleadoLogueado);
                dataGridView1.DataSource = null; // Limpiar el DataGridView
                label6.Text = "$0.00";
            }
            else
            {
                MessageBox.Show("Error al registrar la venta: " + response.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}