﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BajaRuta
{
    public partial class SistemaTrans : Form
    {
        public SistemaTrans()
        {
            InitializeComponent();
        }

       

        private void SistemaTrans_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=transporte;Uid=root;Pwd=berenice;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string queryOrigen = "SELECT DISTINCT origen FROM ruta";
                    string queryDestino = "SELECT DISTINCT destino FROM ruta";

                    MySqlCommand cmdOrigen = new MySqlCommand(queryOrigen, connection);
                    MySqlCommand cmdDestino = new MySqlCommand(queryDestino, connection);

                    using (MySqlDataReader readerOrigen = cmdOrigen.ExecuteReader())
                    {
                        while (readerOrigen.Read())
                        {
                            comBoxOrigen.Items.Add(readerOrigen["origen"].ToString());
                        }
                    }

                    using (MySqlDataReader readerDestino = cmdDestino.ExecuteReader())
                    {
                        while (readerDestino.Read())
                        {
                            comBoxDestino.Items.Add(readerDestino["destino"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Inicio miFormulario = new Inicio();
            miFormulario.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SistemaTrans miFormulario = new SistemaTrans();
            miFormulario.Show();
            this.Hide();
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

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=transporte;Uid=root;Pwd=berenice;";

            if (string.IsNullOrEmpty(comBoxOrigen.Text) || string.IsNullOrEmpty(comBoxDestino.Text))
            {
                MessageBox.Show("Por favor selecciona un origen y un destino.");
                return;
            }

            string origen = comBoxOrigen.Text; 
            string destino = comBoxDestino.Text; 

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT nombre_ruta, tiempo_estimado, tarifa FROM ruta WHERE origen = @origen AND destino = @destino";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@origen", origen);
                    command.Parameters.AddWithValue("@destino", destino);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string nombreRuta = reader["nombre_ruta"].ToString();
                                string tiempoEstimado = reader["tiempo_estimado"].ToString();
                                string tarifa = reader["tarifa"].ToString();

                                MessageBox.Show($"Ruta: {nombreRuta}\nTiempo Estimado: {tiempoEstimado}\nTarifa: ${tarifa}");
                            }

                            string urlMapa = $"https://www.google.com/maps/dir/{Uri.EscapeDataString(origen)}/{Uri.EscapeDataString(destino)}";

                            webView2Control.Source = new Uri(urlMapa); 
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron rutas para el origen y destino seleccionados.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }
        

        private void comBoxDestino_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}



