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
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                usuario datausuario = new usuario();
                datausuario.usuario1 = textBox1.Text;
                datausuario.nombre= textBox2.Text;
                datausuario.contraseña = textBox3.Text;
                ClsNusuario usuaN = new ClsNusuario();
                usuaN.create(datausuario);
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

        private void Create_Load(object sender, EventArgs e)
        {

        }
    }
}
