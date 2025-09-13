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
    public partial class frmMenuMarcas : Form
    {
        public frmMenuMarcas()
        {
            InitializeComponent();
        }

        private void btnListarMarcas_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            List<Marca> marcas = negocio.Listar();

            ListadoMarcaForm vista = new ListadoMarcaForm(marcas);
            vista.ShowDialog();
        }

        private void btnAgregarMarcas_Click(object sender, EventArgs e)
        {
            frmAgregarMarca ventanaAgregarMarca = new frmAgregarMarca();
            ventanaAgregarMarca.ShowDialog();
        }
    }
}
