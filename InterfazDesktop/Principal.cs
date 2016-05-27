using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace InterfazDesktop
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            Load();
            this.Text = "Jugando con Strings V" + Application.ProductVersion;
            //menuStrip1.Items.Add("Versión " + Application.ProductVersion);
        }

        #region Metodos

        /// <summary>
        /// Carga los contenidos del formulario
        /// </summary>
        void Load()
        {
            Selector.DataSource = Enum.GetValues(typeof(Opcion));
        }

        /// <summary>
        /// Cierra la aplicación
        /// </summary>
        void Salir()
        {
            Application.Exit();
        }

        /// <summary>
        /// Copia el contenido del resultado al clipboard
        /// </summary>
        void Copiar()
        {
            Clipboard.SetText(cajaSalida.Text);
        }

        /// <summary>
        /// Ejecuta una opción del menu de conversión
        /// </summary>
        /// <param name="entrada">Texto a procesar</param>
        /// <param name="opcion">Indice seleccionado del ComboBox</param>
        void Procesar(String entrada, Opcion opcion, String extra1, String extra2)
        {
            String resultado = "";

            switch (opcion)
            {
                case Opcion.Alrevesar: resultado = Wiri.Conversion.Alrevesar(entrada);
                    break;
                case Opcion.Borrar: resultado = Wiri.Conversion.Borrar(entrada, extra1);
                    break;
                case Opcion.Reemplazar: resultado = Wiri.Conversion.Reemplazar(entrada, extra1, extra2);
                    break;
                case Opcion.Regex: resultado = Wiri.Conversion.Regex(entrada, extra1);
                    break;
                case Opcion.Mayusculizar:resultado =  Wiri.Conversion.Mayusculizar(entrada);
                    break;
                case Opcion.Minusculizar: resultado = Wiri.Conversion.Minusculizar(entrada);
                    break;
                case Opcion.InvertirCase: resultado = Wiri.Conversion.InvertirCase(entrada);
                    break;
                case Opcion.Enumerar: resultado = Wiri.Conversion.Enumerar(entrada);
                    break;
                default:
                    break;
            }

            cajaSalida.Text = resultado;
        }

         #region Mostrar/Ocultar Componentes
        void MostrarCajita1(bool va, string label)
        {
            if (va)
            {
                labelCajita1.Show();
                cajita1.Show();

                labelCajita1.Text = label;
            }
            else
            {
                labelCajita1.Hide();
                cajita1.Hide();
            }
        }

        void MostrarCajita2(bool va, string label)
        {
            if (va)
            {
                labelCajita2.Show();
                cajita2.Show();

                labelCajita2.Text = label;
            }
            else
            {
                labelCajita2.Hide();
                cajita2.Hide();
            }
        }

        void MostrarCajitasExtra(bool cajita1, bool cajita2, string label1, string label2)
        {
            MostrarCajita1(cajita1,label1);
            MostrarCajita2(cajita2,label2);
        }

        /// <summary>
        /// Decide qué cajitas se muestran.
        /// </summary>
        /// <param name="opcion">Indice seleccionado del ComboBox</param>
        void DecidirCajitasExtra(Opcion opcion)
        {
            switch (opcion)
            {
                case Opcion.Alrevesar: MostrarCajitasExtra(false, false, "", "");
                    break;
                case Opcion.Borrar: MostrarCajitasExtra(true, false, "Texto a Borrar", "");
                    break;
                case Opcion.Reemplazar: MostrarCajitasExtra(true, true, "A Buscar", "A Reemplazar");
                    break;
                case Opcion.Regex: MostrarCajitasExtra(true, false, "Regex a Aplicar", "");
                    break;
                case Opcion.Mayusculizar: MostrarCajitasExtra(false, false, "", "");
                    break;
                case Opcion.Minusculizar: MostrarCajitasExtra(false, false, "", "");
                    break;
                default:
                    break;
            }
        }
         #endregion

        /// <summary>
        /// 
        /// </summary>
        void desplegarManualUsuario()
        {
            MessageBox.Show("Resuelve lol");
        }

        /// <summary>
        /// 
        /// </summary>
        void desplegarPreferencias()
        {
            MessageBox.Show("0 preferencias");
        }
        #endregion

        #region Eventos
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salir();
        }
        
        private void botonCopiar_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void botonProcesar_Click(object sender, EventArgs e)
        {
            Procesar(cajaEntrada.Text,(Opcion)Selector.SelectedIndex,cajita1.Text,cajita2.Text);
        }

        private void Selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            DecidirCajitasExtra((Opcion)Selector.SelectedIndex);
            
        }

        private void enviarADocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string nombre = saveFileDialog1.FileName;
            File.WriteAllText(nombre, cajaSalida.Text);
        }

        private void manualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            desplegarManualUsuario();
        }

        private void preferenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            desplegarPreferencias();
        }
        #endregion

        enum Opcion
        {
            Alrevesar=0,
            Borrar,
            Reemplazar,
            Regex,
            Mayusculizar,
            Minusculizar,
            InvertirCase,
            Enumerar
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
