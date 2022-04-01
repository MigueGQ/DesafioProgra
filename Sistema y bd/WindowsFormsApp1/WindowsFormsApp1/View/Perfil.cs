using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.View
{
    public partial class Perfil : Form
    {
        public string usuariof;
        
        
        


        public Perfil( string usauarioI)
        {
            InitializeComponent();
            usuariof = usauarioI;
            
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = usuariof;
            IniciarSeccion bb = new IniciarSeccion();
            
        }

        private void actualizarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            podate up = new podate(usuariof);
            up.ShowDialog();
            
        }

        private void borrarEstePerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cerrarSeccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            IniciarSeccion jj = new IniciarSeccion();
            jj.Show();
        }

        private void borrarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            delecte Iniciar = new delecte();
            Iniciar.ShowDialog();
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
