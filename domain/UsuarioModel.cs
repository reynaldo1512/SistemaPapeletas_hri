using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionDB;

namespace domain
{
    public class UsuarioModel
    {
        UsuarioDao usuarioDao = new UsuarioDao();
        public bool LoginUsuario(string user, string pass)
        {
            return usuarioDao.Login(user, pass);
        }
    }
}
