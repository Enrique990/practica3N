using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciarSesión_Click(object sender, EventArgs e)
        {
            if (tbUsuario.Text == "" || tbContraseña.Text == "")
            {
                MessageBox.Show("Debe completar ambos campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbUsuario.Text == "admin" || tbContraseña.Text == "1234")
            {
                MessageBox.Show("Bienvenido Administrador");
                return; 
            }
            MessageBox.Show("Bienvenido " + tbUsuario.Text);
        }
    }
}
