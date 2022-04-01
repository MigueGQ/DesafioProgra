using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.services
{
    internal interface Iusuario
    {
        
        void Create(usuario usuario);
        void Update(usuario usuario);

        void delete(usuario usuario);
    }
}
