using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BajaRuta
{
    public partial class Inicio: Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Inicio miFormulario = new Inicio();
            miFormulario.Show();
            this.Hide();
            miFormulario.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SistemaTrans miFormulario = new SistemaTrans();
            miFormulario.Show();
            this.Hide();
            miFormulario.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los micros amarillos operan en diversas rutas dentro de Ensenada, por ejemplo la casa del marco xddd.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los micros rojos cubren diversas rutas en Ensenada, incluyendo zonas como Lázaro Cárdenas, Márquez de León, Popular, CBTIS, entre otras.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los micros azules de El Vigía operan en varias rutas dentro de Ensenada, por ejemplo la casita de memo.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los micros naranjas son una de las líneas de transporte público que operan en Ensenada, ofreciendo rutas que conectan diversas zonas de la ciudad aunque sea una zona olvidada por dios.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El Transporte Violeta es un servicio de transporte público gratuito y exclusivo para mujeres, niñas y niños menores de 12 años, implementado por el gobierno de Baja California como parte de sus políticas de movilidad segura y con perspectiva de género. Este programa busca ofrecer un medio de transporte seguro y accesible para las mujeres y sus hijos en el municipio de Ensenada.");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Conductor")
            {
                PerfilConductor conductorForm = new PerfilConductor();
                conductorForm.Show();
                this.Hide();
            }
            else if (comboBox1.SelectedItem.ToString() == "Usuario")
            {
                PerfilUsuario usuarioForm = new PerfilUsuario();
                usuarioForm.Show();
                this.Hide();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            InfoTrans1 miFormulario = new InfoTrans1();
            miFormulario.Show();
            this.Hide();
            miFormulario.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            InfoTrans2 miFormulario = new InfoTrans2();
            miFormulario.Show();
            this.Hide();
            miFormulario.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            InfoTrans3 miFormulario = new InfoTrans3();
            miFormulario.Show();
            this.Hide();
            miFormulario.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            InfoTrans4 miFormulario = new InfoTrans4();
            miFormulario.Show();
            this.Hide();
            miFormulario.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            InfoTrans5 miFormulario = new InfoTrans5();
            miFormulario.Show();
            this.Hide();
            miFormulario.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
