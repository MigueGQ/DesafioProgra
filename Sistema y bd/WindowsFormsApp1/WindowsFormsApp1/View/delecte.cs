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
    public partial class delecte : Form
    {
        
        public delecte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Perfil hh = new Perfil("");
            hh.Hide();
            usuario database = new usuario();
            database.usuario1 = textBox1.Text;
            database.contraseña=textBox2.Text;
            ClsNusuario proceso = new ClsNusuario();
            proceso.delete(database);
            
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IniciarSeccion hh = new IniciarSeccion();
            this.Close();
            hh.Show();
            
            
        }

        private void delecte_Load(object sender, EventArgs e)
        {

        }
    }
}
