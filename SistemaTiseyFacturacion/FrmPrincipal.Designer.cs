namespace SistemaTiseyFacturacion
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.catalogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSexo = new System.Windows.Forms.ToolStripMenuItem();
            this.mCategoriaProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.datosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.mFaturar = new System.Windows.Forms.ToolStripMenuItem();
            this.pnPrincipal = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogosToolStripMenuItem,
            this.datosToolStripMenuItem,
            this.movimientosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1271, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // catalogosToolStripMenuItem
            // 
            this.catalogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSexo,
            this.mCategoriaProducto});
            this.catalogosToolStripMenuItem.Name = "catalogosToolStripMenuItem";
            this.catalogosToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.catalogosToolStripMenuItem.Text = "Catalogos";
            // 
            // mSexo
            // 
            this.mSexo.Name = "mSexo";
            this.mSexo.Size = new System.Drawing.Size(227, 26);
            this.mSexo.Text = "Sexo";
            this.mSexo.Click += new System.EventHandler(this.mSexo_Click);
            // 
            // mCategoriaProducto
            // 
            this.mCategoriaProducto.Name = "mCategoriaProducto";
            this.mCategoriaProducto.Size = new System.Drawing.Size(227, 26);
            this.mCategoriaProducto.Text = "Categoria Productos";
            // 
            // datosToolStripMenuItem
            // 
            this.datosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mCliente,
            this.mEmpleado});
            this.datosToolStripMenuItem.Name = "datosToolStripMenuItem";
            this.datosToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.datosToolStripMenuItem.Text = "Informacion";
            // 
            // mCliente
            // 
            this.mCliente.Name = "mCliente";
            this.mCliente.Size = new System.Drawing.Size(224, 26);
            this.mCliente.Text = "Cliente";
            // 
            // mEmpleado
            // 
            this.mEmpleado.Name = "mEmpleado";
            this.mEmpleado.Size = new System.Drawing.Size(224, 26);
            this.mEmpleado.Text = "Empleado";
            // 
            // movimientosToolStripMenuItem
            // 
            this.movimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mCompra,
            this.mFaturar});
            this.movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            this.movimientosToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.movimientosToolStripMenuItem.Text = "Movimientos";
            // 
            // mCompra
            // 
            this.mCompra.Name = "mCompra";
            this.mCompra.Size = new System.Drawing.Size(224, 26);
            this.mCompra.Text = "Comprar Productos";
            // 
            // mFaturar
            // 
            this.mFaturar.Name = "mFaturar";
            this.mFaturar.Size = new System.Drawing.Size(224, 26);
            this.mFaturar.Text = "Faturar Productos";
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.Location = new System.Drawing.Point(0, 28);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(1271, 618);
            this.pnPrincipal.TabIndex = 1;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1271, 646);
            this.Controls.Add(this.pnPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Opacity = 0.95D;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem catalogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mSexo;
        private System.Windows.Forms.ToolStripMenuItem mCategoriaProducto;
        private System.Windows.Forms.ToolStripMenuItem datosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mCliente;
        private System.Windows.Forms.ToolStripMenuItem mEmpleado;
        private System.Windows.Forms.ToolStripMenuItem movimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mCompra;
        private System.Windows.Forms.ToolStripMenuItem mFaturar;
        private System.Windows.Forms.Panel pnPrincipal;
    }
}

