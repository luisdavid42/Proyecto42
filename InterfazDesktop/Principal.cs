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

            tiempo1.Format = DateTimePickerFormat.Long;
            tiempo2.Format = DateTimePickerFormat.Short;
            //selectorTiempo.ShowUpDown = true;
        }

        #region Metodos

        /// <summary>
        /// Carga los contenidos del formulario
        /// </summary>
        void Load()
        {
            selectorManejoStrings.DataSource = Enum.GetValues(typeof(ManejoStringsOpcion));
            selectorTiempo.DataSource = Enum.GetValues(typeof(TiempoOpcion));
            selectorTiempo.DataSource = Enum.GetValues(typeof(MatematicasOpcion));
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
        void CopiarManejoStrings()
        {
            Clipboard.SetText(cajaSalidaManejoStrings.Text);
        }

        /// <summary>
        /// Ejecuta una opción del menu de conversión
        /// </summary>
        /// <param name="entrada">Texto a procesar</param>
        /// <param name="opcion">Indice seleccionado del ComboBox</param>
        void ProcesarManejoStrings(String entrada, ManejoStringsOpcion opcion, String extra1, String extra2)
        {
            String resultado = "";

            switch (opcion)
            {
                case ManejoStringsOpcion.Alrevesar: resultado = Wiri.Strings.Alrevesar(entrada);
                    break;
                case ManejoStringsOpcion.Borrar: resultado = Wiri.Strings.Borrar(entrada, extra1);
                    break;
                case ManejoStringsOpcion.Reemplazar: resultado = Wiri.Strings.Reemplazar(entrada, extra1, extra2);
                    break;
                case ManejoStringsOpcion.Regex: resultado = Wiri.Strings.Regex(entrada, extra1);
                    break;
                case ManejoStringsOpcion.Mayusculizar:resultado =  Wiri.Strings.Mayusculizar(entrada);
                    break;
                case ManejoStringsOpcion.Minusculizar: resultado = Wiri.Strings.Minusculizar(entrada);
                    break;
                case ManejoStringsOpcion.InvertirCase: resultado = Wiri.Strings.InvertirCase(entrada);
                    break;
                case ManejoStringsOpcion.Enumerar: resultado = Wiri.Strings.Enumerar(entrada);
                    break;
                case ManejoStringsOpcion.MontanaRusa: resultado = Wiri.Strings.MontanaRusa(entrada);
                    break;
                case ManejoStringsOpcion.Atigerear: resultado = Wiri.Strings.Atigerear(entrada);
                    break;
                default:
                    break;
            }

            cajaSalidaManejoStrings.Text = resultado;
        }

        /// <summary>
        /// Ejecuta una opción del menu de conversión
        /// </summary>
        /// <param name="entrada">Texto a procesar</param>
        /// <param name="opcion">Indice seleccionado del ComboBox</param>
        void ProcesarTiempo(String entrada, TiempoOpcion opcion)
        {
            String resultado = "";

            switch (opcion)
            {
                case TiempoOpcion.Sumar:
                    resultado = "";
                    break;

                default:
                    break;
            }

            //visualizacion de resultado
            //cajaSalidaManejoStrings.Text = resultado;
        }

        /// <summary>
        /// Ejecuta una opción del menu de conversión
        /// </summary>
        /// <param name="entrada">Texto a procesar</param>
        /// <param name="opcion">Indice seleccionado del ComboBox</param>
        void ProcesarMatematicas(String entrada, MatematicasOpcion opcion)
        {
            String resultado = "";

            switch (opcion)
            {
                case MatematicasOpcion.Permutacion:
                    char[] arr = entrada.ToCharArray();
                    Wiri.Matematicas.GetPer(arr);
                    resultado = arr.ToString();
                    break;

                default:
                    break;
            }

            //visualizacion de resultado
            //cajaSalidaManejoStrings.Text = resultado;
        }

        #region Mostrar/Ocultar Componentes
        void MostrarCajita1(bool va, string label)
        {
            if (va)
            {
                labelCajita1.Show();
                cajaAux1.Show();

                labelCajita1.Text = label;
            }
            else
            {
                labelCajita1.Hide();
                cajaAux1.Hide();
            }
        }

        void MostrarCajita2(bool va, string label)
        {
            if (va)
            {
                labelCajita2.Show();
                cajaAux2.Show();

                labelCajita2.Text = label;
            }
            else
            {
                labelCajita2.Hide();
                cajaAux2.Hide();
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
        void DecidirCajitasExtra(ManejoStringsOpcion opcion)
        {
            switch (opcion)
            {
                case ManejoStringsOpcion.Alrevesar: MostrarCajitasExtra(false, false, "", "");
                    break;
                case ManejoStringsOpcion.Borrar: MostrarCajitasExtra(true, false, "Texto a Borrar", "");
                    break;
                case ManejoStringsOpcion.Reemplazar: MostrarCajitasExtra(true, true, "A Buscar", "A Reemplazar");
                    break;
                case ManejoStringsOpcion.Regex: MostrarCajitasExtra(true, false, "Regex a Aplicar", "");
                    break;
                case ManejoStringsOpcion.Mayusculizar: MostrarCajitasExtra(false, false, "", "");
                    break;
                case ManejoStringsOpcion.Minusculizar: MostrarCajitasExtra(false, false, "", "");
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
            CopiarManejoStrings();
        }

        private void botonProcesar_Click(object sender, EventArgs e)
        {
            ProcesarManejoStrings(cajaEntradaManejoStrings.Text,(ManejoStringsOpcion)selectorManejoStrings.SelectedIndex,cajaAux1.Text,cajaAux2.Text);
        }

        private void Selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            DecidirCajitasExtra((ManejoStringsOpcion)selectorManejoStrings.SelectedIndex);
            
        }

        private void enviarADocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string nombre = saveFileDialog1.FileName;
            File.WriteAllText(nombre, cajaSalidaManejoStrings.Text);
        }

        private void manualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            desplegarManualUsuario();
        }

        private void preferenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            desplegarPreferencias();
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            cajaEntradaManejoStrings.Clear();
        }
        #endregion

        #region Enumerativos
        enum ManejoStringsOpcion
        {
            Alrevesar=0,
            Borrar,
            Reemplazar,
            Regex,
            Mayusculizar,
            Minusculizar,
            InvertirCase,
            Enumerar,
            MontanaRusa,
            Atigerear
        }

        enum TiempoOpcion
        {
            Sumar = 0,
            Restar,
            Duracion
        }

        enum MatematicasOpcion
        {
            Permutacion = 0,

        }

        enum ArchivosOpcion
        {
            lol = 0,

        }
        #endregion


        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1Strings_Click(object sender, EventArgs e)
        {

        }

        private void botonProcesarMat_Click(object sender, EventArgs e)
        {
            ProcesarManejoStrings(cajaEntradaManejoStrings.Text, (ManejoStringsOpcion)selectorManejoStrings.SelectedIndex, cajaAux1.Text, cajaAux2.Text);
        }
    }
}
