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
    
    public partial class podate : Form
    {


        public string usuariogg;


        

        public podate(string usuariof)
        {
            InitializeComponent();
            this.usuariogg = usuariof;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                usuario datausuario = new usuario();
                datausuario.usuario1 = usuariogg;
                datausuario.nombre=textBox2.Text;
                datausuario.contraseña = textBox3.Text;
                ClsNusuario usuaN = new ClsNusuario();
                usuaN.update(datausuario);
                this.Close();
            }
            catch
            {
                MessageBox.Show("porfavor llene todos los campos");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            label1.Text = usuariogg;
        }
    }
}
