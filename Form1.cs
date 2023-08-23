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
    public partial class frmInicioSesion : Form
    {

        private Datos nUsuario;
        public frmInicioSesion()
        {
            InitializeComponent();
            nUsuario = new Datos();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            DatosUsuario datosUsuario = new DatosUsuario();

            Modelos sUsuario = new Modelos();
            Datos datosInicio = null;

            if (!ValidacionTxt())
            {
                return;
            } else {
                datosInicioSesion();
                datosInicio = sUsuario.validarInicioSesion(nUsuario.User);

                if (datosInicio == null) {
                    MessageBox.Show("Usuario inexistente");
                } else {
                    if (nUsuario.Password != datosInicio.Password)
                    {
                        MessageBox.Show("Datos incorrectos");
                    } else {
                        datosUsuario.lblUsuario2.Text = datosInicio.User;
                        datosUsuario.lblContrasenia2.Text = datosInicio.Password;
                        datosUsuario.lblNombre2.Text = datosInicio.Name;
                        datosUsuario.lblApePaterno.Text = datosInicio.FirstName;
                        datosUsuario.lblApeMaterno.Text = datosInicio.LastName;
                        datosUsuario.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            frmRegistrarUsuario mostrarForm = new frmRegistrarUsuario();
            mostrarForm.Show();
            this.Hide();

        }

        private void datosInicioSesion()
        {
            nUsuario.User = txtNombreUsuario.Text.Trim();
            nUsuario.Password = txtContraUsuario.Text.Trim();
        }

        private bool ValidacionTxt()
        {

            if (txtNombreUsuario.Text.Trim().Equals("") || txtContraUsuario.Text.Trim().Equals(""))
            {
                MessageBox.Show("Llenar todos los campos");
                return false;
            }

            return true;

        }

    }
}
