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
    public partial class trabajadorFormcs : Form
    {
        public trabajadorFormcs()
        {
            InitializeComponent();
        }

        private void tabajadorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabajadorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.basedatos1DataSet);

        }

        private void trabajadorFormcs_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'basedatos1DataSet.tabajador' Puede moverla o quitarla según sea necesario.
            this.tabajadorTableAdapter.Fill(this.basedatos1DataSet.tabajador);

        }
    }
}
