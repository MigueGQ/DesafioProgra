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
    public partial class delect : Form
    {
        program1Entities hh = new program1Entities();
        public delect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                usuario datausuario = new usuario();
                datausuario.usuario1 = textBox1.Text;
                datausuario.contra = textBox2.Text;
                ClsNusuario usuaN = new ClsNusuario();

                usuaN.Delete(datausuario);
               

                
                this.Close();
            }
            catch
            {
                MessageBox.Show("porfavor llene todos los campos");
            }
        }
    }
}
