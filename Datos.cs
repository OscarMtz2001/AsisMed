using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsisMed
{
    class Datos
    {

        string usuario, contrasenia, nombre, apellido_paterno, apellido_materno;

        public string User { get => usuario; set => usuario = value; }
        public string Name { get => nombre; set => nombre = value; }
        public string Password { get => contrasenia; set => contrasenia= value; }

        public string FirstName { get => apellido_paterno; set => apellido_paterno = value; }
        public string LastName { get => apellido_materno; set => apellido_materno= value; }


    }
}
