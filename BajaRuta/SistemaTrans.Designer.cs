using System;

namespace BajaRuta
{
    partial class SistemaTrans
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SistemaTrans));
            this.webBrowserMapa = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comBoxOrigen = new System.Windows.Forms.ComboBox();
            this.comBoxDestino = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.webView2Control = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.webBrowserMapa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView2Control)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowserMapa
            // 
            this.webBrowserMapa.BackColor = System.Drawing.Color.White;
            this.webBrowserMapa.Controls.Add(this.pictureBox1);
            this.webBrowserMapa.Controls.Add(this.label1);
            this.webBrowserMapa.Controls.Add(this.label2);
            this.webBrowserMapa.Controls.Add(this.linkLabel1);
            this.webBrowserMapa.Controls.Add(this.linkLabel2);
            this.webBrowserMapa.Controls.Add(this.linkLabel3);
            this.webBrowserMapa.Controls.Add(this.comboBox1);
            this.webBrowserMapa.Dock = System.Windows.Forms.DockStyle.Top;
            this.webBrowserMapa.Location = new System.Drawing.Point(0, 0);
            this.webBrowserMapa.Name = "webBrowserMapa";
            this.webBrowserMapa.Size = new System.Drawing.Size(800, 59);
            this.webBrowserMapa.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BajaRuta.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label1.Size = new System.Drawing.Size(88, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "BajaRuta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(170, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
            this.label2.Size = new System.Drawing.Size(174, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "\"La mejor ruta para llegar\"";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(350, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Padding = new System.Windows.Forms.Padding(70, 20, 0, 0);
            this.linkLabel1.Size = new System.Drawing.Size(121, 43);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Inicio";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(477, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.linkLabel2.Size = new System.Drawing.Size(179, 43);
            this.linkLabel2.TabIndex = 2;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Sistema de Transporte";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.linkLabel3.LinkColor = System.Drawing.Color.Black;
            this.linkLabel3.Location = new System.Drawing.Point(662, 0);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(0, 23);
            this.linkLabel3.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Usuario",
            "Conductor"});
            this.comboBox1.Location = new System.Drawing.Point(668, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(121, 29);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Perfil";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comBoxOrigen
            // 
            this.comBoxOrigen.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.comBoxOrigen.FormattingEnabled = true;
            this.comBoxOrigen.Items.AddRange(new object[] {
            "Centro",
            "Valle Dorado",
            "Presa 89",
            "Zorrillo",
            "Maneadero",
            "Sauzal",
            "UABC Punta Banda",
            "Ojos Negros",
            "CBTIS",
            "San Miguel",
            "Blvd Costero",
            "Fraccionamiento Porticos del Mar",
            "Valle de Guadalupe"});
            this.comBoxOrigen.Location = new System.Drawing.Point(174, 149);
            this.comBoxOrigen.Name = "comBoxOrigen";
            this.comBoxOrigen.Size = new System.Drawing.Size(146, 27);
            this.comBoxOrigen.TabIndex = 4;
            this.comBoxOrigen.Text = "Seleccione una ruta";
            // 
            // comBoxDestino
            // 
            this.comBoxDestino.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.comBoxDestino.FormattingEnabled = true;
            this.comBoxDestino.Items.AddRange(new object[] {
            "Centro",
            "Valle Dorado",
            "Presa 89",
            "Zorrillo",
            "Maneadero",
            "Sauzal",
            "UABC Punta Banda",
            "Ojos Negros",
            "CBTIS",
            "San Miguel",
            "La Mision"});
            this.comBoxDestino.Location = new System.Drawing.Point(354, 149);
            this.comBoxDestino.Name = "comBoxDestino";
            this.comBoxDestino.Size = new System.Drawing.Size(144, 27);
            this.comBoxDestino.TabIndex = 6;
            this.comBoxDestino.Text = "Seleccione su zona";
            this.comBoxDestino.SelectedIndexChanged += new System.EventHandler(this.comBoxDestino_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(555, 149);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 29);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(287, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sistema de Transporte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(399, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Destino";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(203, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Origen";
            // 
            // webView2Control
            // 
            this.webView2Control.AllowExternalDrop = true;
            this.webView2Control.CreationProperties = null;
            this.webView2Control.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView2Control.Location = new System.Drawing.Point(111, 184);
            this.webView2Control.Name = "webView2Control";
            this.webView2Control.Size = new System.Drawing.Size(581, 306);
            this.webView2Control.TabIndex = 14;
            this.webView2Control.ZoomFactor = 1D;
            // 
            // SistemaTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = global::BajaRuta.Properties.Resources.mejores_playas_de_ensenada_el_faro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.webView2Control);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.comBoxDestino);
            this.Controls.Add(this.comBoxOrigen);
            this.Controls.Add(this.webBrowserMapa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SistemaTrans";
            this.Text = "Sistema de Transporte";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.webBrowserMapa.ResumeLayout(false);
            this.webBrowserMapa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView2Control)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel webBrowserMapa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comBoxOrigen;
        private System.Windows.Forms.ComboBox comBoxDestino;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView2Control;
    }
}