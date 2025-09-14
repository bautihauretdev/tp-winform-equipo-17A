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
            dgvArticulos.DataSource = articulos.Select(a => new {
                a.Id,
                a.Codigo,
                a.Nombre,
                a.Descripcion,
                Marca = a.Marca.descripcion,
                Categoria = a.Categoria.descripcion,
                a.Precio
            }).ToList();
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

        
    }
}
