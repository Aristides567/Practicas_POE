using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_ListBox
{
    public partial class FormDescripcion : Form
    {
        public string Descripcion { get; private set; }

        public FormDescripcion()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            Descripcion = txtDescripcion.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }

}
