using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace postgres1
{
    public partial class ventasForm : Form
    {
        public ventasForm()
        {
            InitializeComponent();
        }

        private void ventaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ventaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.basedatos1DataSet);

        }

        private void ventasForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'basedatos1DataSet.venta' Puede moverla o quitarla según sea necesario.
            this.ventaTableAdapter.Fill(this.basedatos1DataSet.venta);

        }
    }
}
