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
    public partial class ListadoArticuloForm : Form
    {
        private List<Articulo> listaArticulos;

        public ListadoArticuloForm(List<Articulo> articulos)
        {
            InitializeComponent();
            listaArticulos = articulos;
            dgvArticulos.ReadOnly = true;
            dgvArticulos.DataSource = listaArticulos;
        }

        private void ListadoArticuloForm_Load(object sender, EventArgs e)
        {
            cargarArticulos();
        }
            private void cargarArticulos()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulos = negocio.Listar();
           dgvArticulos.DataSource = listaArticulos.Select(a => new {
                a.Id,
                a.Codigo,
                a.Nombre,
                a.Descripcion,
                Marca = a.Marca.descripcion,
                Categoria = a.Categoria.descripcion,
                a.Precio
            }).ToList();
           dgvArticulos.AutoGenerateColumns = true;
            dgvArticulos.Refresh();
        }
    }
    }

