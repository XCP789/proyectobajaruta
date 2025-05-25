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
    public partial class InfoTrans2: Form
    {
        public InfoTrans2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio miFormulario = new Inicio();
            miFormulario.Show();
            this.Hide();
            miFormulario.Show();
        }
    }
}
