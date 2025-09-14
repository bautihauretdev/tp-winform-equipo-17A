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
    public partial class frmMenuCategorias : Form
    {
        private List<Categoria> listaCategorias;
         
        public frmMenuCategorias(List<Categoria> categorias)
        {
            InitializeComponent();
            listaCategorias = categorias;
            dgvCategorias.ReadOnly = true;
            dgvCategorias.DataSource = listaCategorias;
        }

        private void frmMenuCategorias_Load(object sender, EventArgs e)
        {
            cargarCategorias();
        }

        private void cargarCategorias()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            listaCategorias = negocio.Listar();
            dgvCategorias.DataSource = listaCategorias;
            dgvCategorias.AutoGenerateColumns = true;
            dgvCategorias.Refresh();
        }

        private void btnAgregarCategorias_Click(object sender, EventArgs e)
        {
            frmAltaCategoria alta = new frmAltaCategoria();
            alta.ShowDialog();
        }
    }
}
