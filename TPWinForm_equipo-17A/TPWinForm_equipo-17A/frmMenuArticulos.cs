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
    public partial class frmMenuArticulos : Form
    {
        private List<Articulo> listaArticulos = new List<Articulo>();
        public frmMenuArticulos()
        {
            InitializeComponent();
        }

        private void frmMenuArticulos_Load(object sender, EventArgs e)
        {
            cargarArticulos();
        }
        private void cargarArticulos()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> articulos = negocio.Listar();
            dgvArticulos.DataSource = articulos;
            dgvArticulos.Columns["Marca"].Visible = false;
            dgvArticulos.Columns["Categoria"].Visible = false;
        }
        private List<Articulo> ObtenerArticulos()
        {
            return listaArticulos ?? new List<Articulo>();
        }



        private void btnAgregarArticulos_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
        }

        private void btnEliminarArticulos_Click(object sender, EventArgs e)
        {
            ArticuloNegocio nuevo = new ArticuloNegocio();  
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar el artículo seleccionado?", "Eliminando...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {                 
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem; 
                    nuevo.eliminar(seleccionado.Id);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
