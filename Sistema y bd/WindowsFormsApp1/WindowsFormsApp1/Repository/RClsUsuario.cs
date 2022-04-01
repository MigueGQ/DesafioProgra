using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.services;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1.Repository
{
    internal class RClsUsuario : Iusuario
    {
        program1Entities conexiondb = new program1Entities();
        
        public void Create(usuario usuario11)
        {
            using (conexiondb)
            {
                try
                {
                    usuario db = new usuario();
                    db.usuario1 = usuario11.usuario1;
                    db.nombre=usuario11.nombre;
                    db.contraseña=usuario11.contraseña;
                    conexiondb.usuario.Add(db);
                    conexiondb.SaveChanges();
                    MessageBox.Show("el usuario fue agregado exitosamente");
                    IniciarSeccion vi = new IniciarSeccion();
                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show("por favor asegurece de llenar todos los campos y que los datos sean correctos"+ex);
                }
            }
        }

        public void delete(usuario usuario)
        {
            try
            {
                var djk = from dete in conexiondb.usuario
                          where dete.usuario1 == usuario.usuario1 && dete.contraseña == usuario.contraseña
                          select dete;
                if (djk.Count()>0)
                {
                    using (conexiondb)
                    {
                        usuario = conexiondb.usuario.Find(usuario.usuario1);
                        conexiondb.usuario.Remove(usuario);
                        conexiondb.SaveChanges();
                        MessageBox.Show("exito se borro usuario " + usuario.usuario1);
                        
                    }
                }
                else
                {
                    MessageBox.Show("usuario o contraseña incorreto");
                }

                
            }
            catch
            {
                
            }
            
        }

        public void Update(usuario usuario)
        {


            try
            {
                using (conexiondb)
                {
                    usuario Db = conexiondb.usuario.Find(usuario.usuario1);

                    Db.nombre = usuario.nombre;
                    Db.contraseña = usuario.contraseña;

                    conexiondb.SaveChanges();

                    MessageBox.Show("Se actualizo el Usuario");

                }
            }
            catch
            {

            }
                


            
        }
    }
}
