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
    public partial class PerfilUsuario: Form
    {
        public PerfilUsuario()
        {
            InitializeComponent();
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

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SistemaTrans miFormulario = new SistemaTrans();
            miFormulario.Show();
            this.Hide();
            miFormulario.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Inicio miFormulario = new Inicio();
            miFormulario.Show();
            this.Hide();
            miFormulario.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Seleccionar imagen";
            openFileDialog.Filter = "Archivos de imagen (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
