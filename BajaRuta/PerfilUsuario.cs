using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BajaRuta
{
    public partial class PerfilUsuario: Form
    {
        public string UsuarioActual { get; internal set; }

        public PerfilUsuario()
        {
            InitializeComponent();
        }

        private DbConnection ObtenerConexion()
        {
            string servidor = "localhost";
            string baseDatos = "transporte";
            string usuarioId = "root";
            string password = "berenice";

            string connectionString = $"Server={servidor};Database={baseDatos};Uid={usuarioId};Pwd={password};";
            return new MySqlConnection(connectionString);
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
            using (DbConnection conn = ObtenerConexion())
            {
                conn.Open();
                using (DbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE cliente " +
                                      "SET nombre = @nombre, direccion = @direccion, correo = @correo, telefono = @telefono " +
                                      "WHERE idUsuario = (SELECT idUsuario FROM usuario WHERE username = @username)";

                    cmd.Parameters.AddRange(new[]
                    {
                new MySqlParameter("@nombre", txtNombre.Text),
                new MySqlParameter("@direccion", txtDireccion.Text),
                new MySqlParameter("@correo", txtCorreo.Text),
                new MySqlParameter("@telefono", txtTelefono.Text),
                new MySqlParameter("@username", UsuarioActual)
            });

                    int rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected > 0 ? "Datos actualizados correctamente." : "No se pudo actualizar la información.");
                }
            }
        }

        private void PerfilUsuario_Load(object sender, EventArgs e)
        {
            using (DbConnection conn = ObtenerConexion())
            {
                conn.Open();
                using (DbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT c.nombre, c.direccion, c.correo, c.telefono FROM cliente c " +
                                      "INNER JOIN usuario u ON c.idUsuario = u.idUsuario " +
                                      "WHERE u.username = @username";

                    var param = cmd.CreateParameter();
                    param.ParameterName = "@username";
                    param.Value = UsuarioActual;
                    cmd.Parameters.Add(param);

                    using (DbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtNombre.Text = reader.GetString(0); // Nombre del cliente
                            txtDireccion.Text = reader.GetString(1); // Dirección
                            txtCorreo.Text = reader.GetString(2); // Correo
                            txtTelefono.Text = reader.GetString(3); // Teléfono
                        }
                    }
                }
            }
        }
    }
}
