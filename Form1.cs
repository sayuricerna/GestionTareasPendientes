using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionTareasPendientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            string tareas = txtTarea.Text;
            if (tareas == "")
            {
                MessageBox.Show("Escriba una tarea");
            }
            else
            {
                lstTareas.Items.Add(tareas);
                MessageBox.Show("Se ha agregado la Tarea con éxito.");
                txtTarea.Clear();
            }
        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            if (lstTareas.Items.Count == 0)
            {
                MessageBox.Show("No hay tareas para eliminar");
            }
            else if (lstTareas.SelectedIndex < 0)
            {
                MessageBox.Show("No se ha seleccionado ninguna tarea para eliminar");
            }
            else
            {
                int index = lstTareas.SelectedIndex;
                lstTareas.Items.RemoveAt(index);
            }
        }

        private void btnLimpiarLista_Click(object sender, EventArgs e)
        {
            lstTareas.Items.Clear();
        }
    }
}
