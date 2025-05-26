
using System;
using System.Data.Common;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BajaRuta
{
    public partial class Form1 : Form
    {
        private string Servidor = "localhost";//servidor en el que se encuentra la base de datos
        private string Basedatos = "transporte";//base de datos ya creada
        private string UsuarioId = "root";//usuario de la base de datos 
        private string Password = "berenice";//contraseña del usuario 

        public Form1()
        {
            InitializeComponent();//iniciar componentes 
        }

        private string ObtenerCadenaConexion()//base principal, no tocar
        {
            return $"Server={Servidor};Database={Basedatos};User Id={UsuarioId};Password={Password};SslMode=None";
        }

        private DbConnection ObtenerConexion()//conexion principal, no tocar
        {
            return new MySqlConnection(ObtenerCadenaConexion());
        }

        private void btningresar_Click(object sender, EventArgs e)
        
            {
                string usuario = txtusuario.Text.Trim();
                string contraseña = txtcontraseña.Text.Trim();

                if (usuario == "" || contraseña == "")//en balnqueamiento por si no se ingresan los datos y se preciona el boton
                {
                    MessageBox.Show("Por favor ingresa usuario y contraseña.");
                    return;
                }

                try//manejar try-catch, surgen muchas exepciones
                {
                    using (DbConnection conn = ObtenerConexion())
                    {
                        conn.Open();
                        using (DbCommand cmd = conn.CreateCommand())
                        {//comando principal para el login
                            cmd.CommandText = "SELECT COUNT(*) FROM usuario WHERE username = @usuario AND contraseña = @contraseña";

                            var p1 = cmd.CreateParameter();
                            p1.ParameterName = "@usuario";
                            p1.Value = usuario;
                            cmd.Parameters.Add(p1);

                            var p2 = cmd.CreateParameter();
                            p2.ParameterName = "@contraseña";
                        p2.Value = contraseña;
                            cmd.Parameters.Add(p2);

                            int count = Convert.ToInt32(cmd.ExecuteScalar());

                            if (count > 0)
                            {
                            Inicio miFormulario = new Inicio();
                            miFormulario.Show();
                            this.Hide();
                            miFormulario.Show(); //reemplazar por la pagina de Aria

                        }
                            else
                            {
                                MessageBox.Show("Usuario o contraseña incorrectos");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar iniciar sesión: " + ex.Message);
                }
            }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
