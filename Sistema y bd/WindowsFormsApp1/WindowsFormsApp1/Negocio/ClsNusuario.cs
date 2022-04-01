using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repository;

namespace WindowsFormsApp1.Negocio
{
    internal class ClsNusuario : RClsUsuario
    {
        public void create(usuario usu)
        {
            Create(usu);
        }

        public void elect(usuario usu)
        {
            delete(usu);
        }
        public void update(usuario usu)
        {
            Update(usu);
        }
    }
}
