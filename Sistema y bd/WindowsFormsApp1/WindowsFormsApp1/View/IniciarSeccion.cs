using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Negocio;

namespace WindowsFormsApp1.View
{
    public partial class IniciarSeccion : Form
    {
        public string usuarioI;
        public IniciarSeccion()
        {
            InitializeComponent();
        }

        private void RegisterVi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (program1Entities db = new program1Entities())
            {

                usuario usu = new usuario();
                try
                {
                    var tcl = from data in db.usuario
                              where data.usuario1 == UsuarioBox.Text && data.contraseña == passwordBox.Text
                              select data;
                    if(tcl.Count() > 0)
                    {
                        usuarioI = UsuarioBox.Text;
                        Perfil Ft = new Perfil(usuarioI);
                        Ft.Show();
                        this.Hide();

                        
                        
                        
                    }
                    else
                    {
                        MessageBox.Show("usuario o contraseña incorecto");
                    }
                    
                }
                catch
                {
                    
                }

            }
                
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Create create = new Create();
            create.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsuarioBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
