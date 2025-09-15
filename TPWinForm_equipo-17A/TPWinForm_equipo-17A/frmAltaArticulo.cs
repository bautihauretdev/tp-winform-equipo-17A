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
        private Articulo articulo = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
        }
        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio(); 
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio(); 
            cbMarca.DataSource = marcaNegocio.Listar();
            cbMarca.DisplayMember = "descripcion";
            cbMarca.ValueMember = "id";

            cbCategoria.DataSource = categoriaNegocio.Listar();
            cbCategoria.DisplayMember = "Descripcion";
            cbCategoria.ValueMember = "Id";

            if (articulo!= null)
            {
                txtCodigo.Text = articulo.Codigo;
                txtNombre.Text = articulo.Nombre;
                txtDescripcion.Text = articulo.Descripcion;
                txtPrecio.Text = articulo.Precio.ToString();
                cbMarca.SelectedValue = articulo.Marca.id;
                cbCategoria.SelectedValue = articulo.Categoria.Id;
                btnAgregar.Text = "Modificar";
                this.Text = "Modificar Artículo";
            }
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
                ArticuloNegocio negocio = new ArticuloNegocio();
                if (articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Marca = (Marca)cbMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecio.Text);

                if (articulo.Id !=0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Artículo modificado exitosamente.");

                }
                else
                {
                    negocio.Agregar(articulo);
                    MessageBox.Show("Artículo agregado exitosamente.");
                }

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
