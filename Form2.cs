using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsisMed
{
    public partial class frmRegistrarUsuario : Form
    {

        private Datos nUsuario;
        private Modelos iUsuario;
        private frmInicioSesion regresarInicio;

        public frmRegistrarUsuario()
        {
            InitializeComponent();
            nUsuario = new Datos();
            iUsuario = new Modelos();
            regresarInicio = new frmInicioSesion();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            regresarInicio.Show();
            this.Hide();
        }

        private void btnInsertarUsuario_Click(object sender, EventArgs e)
        {

            if (!ValidacionTxt())
            {
                return;
            }

            datosUsuario();

            if (iUsuario.validarUsuarioInsert(nUsuario.User))
            {
                MessageBox.Show("Este usuario ya existe.");
            }
            else
            {
               if (iUsuario.insertarUsuario(nUsuario))
                {
                    MessageBox.Show("Se ha registrado correctamente.");
                    datosUsuario();
                    regresarInicio.Show();
                    this.Hide();
                }
            }
        }

        private void datosUsuario()
        {
            nUsuario.User = txtUsuario.Text.Trim();
            nUsuario.Password = txtContrasenia.Text.Trim();
            nUsuario.Name = txtNombre.Text.Trim();
            nUsuario.FirstName = txtApePaterno.Text.Trim();
            nUsuario.LastName = txtApeMaterno.Text.Trim();
        }

        private bool ValidacionTxt()
        {

            if (txtUsuario.Text.Trim().Equals("") || txtNombre.Text.Trim().Equals("") || txtContrasenia.Text.Trim().Equals("")
                || txtApePaterno.Text.Trim().Equals("") || txtApeMaterno.Text.Trim().Equals("")) {
                MessageBox.Show("Llenar todos los campos");
                return false;
            }

            return true;

        }

    }
}
