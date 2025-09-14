using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TPWinForm_equipo_17A
{
    public partial class frmAltaArticulo : Form
    {
        public frmAltaArticulo()
        {
            InitializeComponent();
        }
        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio(); 
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio(); 
            cbMarca.DataSource = marcaNegocio.Listar();
            cbMarca.DisplayMember = "Descripcion";
            cbMarca.ValueMember = "Id";

            cbCategoria.DataSource = categoriaNegocio.Listar();
            cbCategoria.DisplayMember = "Descripcion";
            cbCategoria.ValueMember = "Id";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Articulo nuevoArticulo = new Articulo();
            try
            {
                nuevoArticulo.Codigo = txtCodigo.Text;
                nuevoArticulo.Codigo = txtCodigo.Text;
                nuevoArticulo.Nombre = txtNombre.Text;
                nuevoArticulo.Descripcion = txtDescripcion.Text;
                nuevoArticulo.Marca = (Marca)cbMarca.SelectedItem;
                nuevoArticulo.Categoria = (Categoria)cbCategoria.SelectedItem;
                nuevoArticulo.Precio = decimal.Parse(txtPrecio.Text);
                ArticuloNegocio negocio = new ArticuloNegocio();
                negocio.Agregar(nuevoArticulo);
                MessageBox.Show("Artículo agregado exitosamente.");

            }
            catch (FormatException)
            {
                MessageBox.Show("El precio debe ser un valor numérico válido.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el artículo: " + ex.Message);
            }
            finally   
            {
                this.Close();
            }   
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
