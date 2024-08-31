using System.Windows.Forms;

namespace Ejemplo_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (FormDescripcion formDescripcion = new FormDescripcion())
            {
                if (formDescripcion.ShowDialog() == DialogResult.OK)
                {
                    ItemsListBox.Items.Add(formDescripcion.Descripcion);
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                ItemsListBox.Items.RemoveAt(ItemsListBox.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Selecciona un ítem para eliminar.");
            }
        }
    }
}
