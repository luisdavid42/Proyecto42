namespace InterfazDesktop
{
    partial class Principal
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
            this.cajaSalida = new System.Windows.Forms.TextBox();
            this.cajaEntrada = new System.Windows.Forms.TextBox();
            this.botonCopiar = new System.Windows.Forms.Button();
            this.Selector = new System.Windows.Forms.ComboBox();
            this.botonProcesar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wiriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarADocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.labelCajita1 = new System.Windows.Forms.Label();
            this.cajita1 = new System.Windows.Forms.TextBox();
            this.cajita2 = new System.Windows.Forms.TextBox();
            this.labelCajita2 = new System.Windows.Forms.Label();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cajaSalida
            // 
            this.cajaSalida.Location = new System.Drawing.Point(367, 39);
            this.cajaSalida.Multiline = true;
            this.cajaSalida.Name = "cajaSalida";
            this.cajaSalida.Size = new System.Drawing.Size(222, 233);
            this.cajaSalida.TabIndex = 14;
            // 
            // cajaEntrada
            // 
            this.cajaEntrada.Location = new System.Drawing.Point(39, 39);
            this.cajaEntrada.Multiline = true;
            this.cajaEntrada.Name = "cajaEntrada";
            this.cajaEntrada.Size = new System.Drawing.Size(222, 233);
            this.cajaEntrada.TabIndex = 13;
            // 
            // botonCopiar
            // 
            this.botonCopiar.Location = new System.Drawing.Point(431, 293);
            this.botonCopiar.Name = "botonCopiar";
            this.botonCopiar.Size = new System.Drawing.Size(75, 23);
            this.botonCopiar.TabIndex = 12;
            this.botonCopiar.Text = "Copiar";
            this.botonCopiar.UseVisualStyleBackColor = true;
            this.botonCopiar.Click += new System.EventHandler(this.botonCopiar_Click);
            // 
            // Selector
            // 
            this.Selector.FormattingEnabled = true;
            this.Selector.Location = new System.Drawing.Point(258, 293);
            this.Selector.Name = "Selector";
            this.Selector.Size = new System.Drawing.Size(111, 21);
            this.Selector.TabIndex = 11;
            this.Selector.SelectedIndexChanged += new System.EventHandler(this.Selector_SelectedIndexChanged);
            // 
            // botonProcesar
            // 
            this.botonProcesar.Location = new System.Drawing.Point(109, 293);
            this.botonProcesar.Name = "botonProcesar";
            this.botonProcesar.Size = new System.Drawing.Size(75, 23);
            this.botonProcesar.TabIndex = 10;
            this.botonProcesar.Text = "Dale";
            this.botonProcesar.UseVisualStyleBackColor = true;
            this.botonProcesar.Click += new System.EventHandler(this.botonProcesar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.wiriToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(611, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // wiriToolStripMenuItem
            // 
            this.wiriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enviarADocumentoToolStripMenuItem});
            this.wiriToolStripMenuItem.Name = "wiriToolStripMenuItem";
            this.wiriToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.wiriToolStripMenuItem.Text = "Wiri";
            // 
            // enviarADocumentoToolStripMenuItem
            // 
            this.enviarADocumentoToolStripMenuItem.Name = "enviarADocumentoToolStripMenuItem";
            this.enviarADocumentoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.enviarADocumentoToolStripMenuItem.Text = "Enviar a Documento";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // labelCajita1
            // 
            this.labelCajita1.AutoSize = true;
            this.labelCajita1.Location = new System.Drawing.Point(275, 63);
            this.labelCajita1.Name = "labelCajita1";
            this.labelCajita1.Size = new System.Drawing.Size(35, 13);
            this.labelCajita1.TabIndex = 16;
            this.labelCajita1.Text = "label1";
            // 
            // cajita1
            // 
            this.cajita1.Location = new System.Drawing.Point(278, 79);
            this.cajita1.Name = "cajita1";
            this.cajita1.Size = new System.Drawing.Size(74, 20);
            this.cajita1.TabIndex = 17;
            // 
            // cajita2
            // 
            this.cajita2.Location = new System.Drawing.Point(278, 136);
            this.cajita2.Name = "cajita2";
            this.cajita2.Size = new System.Drawing.Size(74, 20);
            this.cajita2.TabIndex = 19;
            // 
            // labelCajita2
            // 
            this.labelCajita2.AutoSize = true;
            this.labelCajita2.Location = new System.Drawing.Point(275, 120);
            this.labelCajita2.Name = "labelCajita2";
            this.labelCajita2.Size = new System.Drawing.Size(35, 13);
            this.labelCajita2.TabIndex = 18;
            this.labelCajita2.Text = "label2";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 334);
            this.Controls.Add(this.cajita2);
            this.Controls.Add(this.labelCajita2);
            this.Controls.Add(this.cajita1);
            this.Controls.Add(this.labelCajita1);
            this.Controls.Add(this.cajaSalida);
            this.Controls.Add(this.cajaEntrada);
            this.Controls.Add(this.botonCopiar);
            this.Controls.Add(this.Selector);
            this.Controls.Add(this.botonProcesar);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Principal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cajaSalida;
        private System.Windows.Forms.TextBox cajaEntrada;
        private System.Windows.Forms.Button botonCopiar;
        private System.Windows.Forms.ComboBox Selector;
        private System.Windows.Forms.Button botonProcesar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wiriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarADocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label labelCajita1;
        private System.Windows.Forms.TextBox cajita1;
        private System.Windows.Forms.TextBox cajita2;
        private System.Windows.Forms.Label labelCajita2;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;

    }
}