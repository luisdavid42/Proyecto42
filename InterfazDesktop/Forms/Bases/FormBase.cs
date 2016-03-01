using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazDesktop.Forms.Bases
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }

        #region Metodos
        /// <summary>
        /// Cierra la aplicación
        /// </summary>
        void Salir()
        {
            Application.Exit();
        }
        #endregion

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salir();
        }
    }
}
