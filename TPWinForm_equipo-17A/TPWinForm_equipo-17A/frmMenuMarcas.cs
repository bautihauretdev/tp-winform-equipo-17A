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

        private List<Marca> listaMarcas;

        private void btnListarMarcas_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            listaMarcas = negocio.Listar(); 
            dgvMarca.DataSource = listaMarcas;
        }
    }
}
