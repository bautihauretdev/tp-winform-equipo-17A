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
    public partial class frmAgregarMarca : Form
    {
        public frmAgregarMarca()
        {
            InitializeComponent();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            Marca nuevaMarca = new Marca();
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                nuevaMarca.descripcion = txtNombre.Text;

                negocio.Agregar(nuevaMarca);
                MessageBox.Show("La marca ha sido agregada exitosamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
