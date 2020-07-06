namespace Keywords
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.chkOver = new System.Windows.Forms.CheckBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.pnlTools = new System.Windows.Forms.Panel();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnVaciarTexto = new System.Windows.Forms.Button();
            this.txtFontSize = new System.Windows.Forms.TextBox();
            this.pnlEspacio = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlBarraTitulo.SuspendLayout();
            this.pnlTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlBarraTitulo.Controls.Add(this.btnCerrar);
            this.pnlBarraTitulo.Controls.Add(this.chkOver);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(204, 25);
            this.pnlBarraTitulo.TabIndex = 3;
            this.pnlBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(179, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "X";
            this.toolTip.SetToolTip(this.btnCerrar, "Cierra la ventana (Alt + F4)");
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // chkOver
            // 
            this.chkOver.AutoSize = true;
            this.chkOver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkOver.FlatAppearance.BorderSize = 0;
            this.chkOver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkOver.Location = new System.Drawing.Point(5, 5);
            this.chkOver.Name = "chkOver";
            this.chkOver.Size = new System.Drawing.Size(46, 17);
            this.chkOver.TabIndex = 0;
            this.chkOver.Text = "Over";
            this.toolTip.SetToolTip(this.chkOver, "Mantiene la ventana siempre\r\nvisible (Alt + Espacio)");
            this.chkOver.UseVisualStyleBackColor = true;
            this.chkOver.CheckedChanged += new System.EventHandler(this.chkOver_CheckedChanged);
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitulo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTitulo.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.White;
            this.txtTitulo.Location = new System.Drawing.Point(0, 25);
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(204, 78);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.Text = "\r\nTítulo";
            this.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTitulo.Click += new System.EventHandler(this.selecTextOnFocus);
            this.txtTitulo.Enter += new System.EventHandler(this.selecTextOnFocus);
            // 
            // txtContenido
            // 
            this.txtContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtContenido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContenido.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContenido.ForeColor = System.Drawing.Color.White;
            this.txtContenido.Location = new System.Drawing.Point(0, 110);
            this.txtContenido.Multiline = true;
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(204, 184);
            this.txtContenido.TabIndex = 1;
            this.txtContenido.Text = "Contenido";
            this.txtContenido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtContenido.Click += new System.EventHandler(this.selecTextOnFocus);
            this.txtContenido.Enter += new System.EventHandler(this.selecTextOnFocus);
            // 
            // pnlTools
            // 
            this.pnlTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlTools.Controls.Add(this.btnSiguiente);
            this.pnlTools.Controls.Add(this.btnAnterior);
            this.pnlTools.Controls.Add(this.btnVaciarTexto);
            this.pnlTools.Controls.Add(this.txtFontSize);
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTools.Location = new System.Drawing.Point(0, 294);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(204, 17);
            this.pnlTools.TabIndex = 2;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Image = global::Keywords.Properties.Resources.siguiente;
            this.btnSiguiente.Location = new System.Drawing.Point(57, 0);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(17, 17);
            this.btnSiguiente.TabIndex = 2;
            this.toolTip.SetToolTip(this.btnSiguiente, "Tema siguiente (Alt + X)");
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnterior.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Image = global::Keywords.Properties.Resources.anterior;
            this.btnAnterior.Location = new System.Drawing.Point(40, 0);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(17, 17);
            this.btnAnterior.TabIndex = 1;
            this.toolTip.SetToolTip(this.btnAnterior, "Tema anterio (Alt + Z)");
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnVaciarTexto
            // 
            this.btnVaciarTexto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVaciarTexto.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnVaciarTexto.FlatAppearance.BorderSize = 0;
            this.btnVaciarTexto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaciarTexto.ForeColor = System.Drawing.Color.White;
            this.btnVaciarTexto.Location = new System.Drawing.Point(179, 0);
            this.btnVaciarTexto.Name = "btnVaciarTexto";
            this.btnVaciarTexto.Size = new System.Drawing.Size(25, 17);
            this.btnVaciarTexto.TabIndex = 3;
            this.btnVaciarTexto.Text = "—";
            this.toolTip.SetToolTip(this.btnVaciarTexto, "Vaciar Contenido (Alt + Q)");
            this.btnVaciarTexto.UseVisualStyleBackColor = true;
            this.btnVaciarTexto.Click += new System.EventHandler(this.btnVaciarTexto_Click);
            // 
            // txtFontSize
            // 
            this.txtFontSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtFontSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFontSize.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtFontSize.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFontSize.ForeColor = System.Drawing.Color.White;
            this.txtFontSize.Location = new System.Drawing.Point(0, 0);
            this.txtFontSize.Multiline = true;
            this.txtFontSize.Name = "txtFontSize";
            this.txtFontSize.Size = new System.Drawing.Size(40, 17);
            this.txtFontSize.TabIndex = 0;
            this.txtFontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.txtFontSize, "Cambie el tamaño \r\ndel contenido");
            this.txtFontSize.Click += new System.EventHandler(this.selecTextOnFocus);
            this.txtFontSize.TextChanged += new System.EventHandler(this.txtFontSize_TextChanged);
            this.txtFontSize.Enter += new System.EventHandler(this.selecTextOnFocus);
            // 
            // pnlEspacio
            // 
            this.pnlEspacio.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEspacio.Location = new System.Drawing.Point(0, 103);
            this.pnlEspacio.Name = "pnlEspacio";
            this.pnlEspacio.Size = new System.Drawing.Size(204, 7);
            this.pnlEspacio.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(204, 311);
            this.Controls.Add(this.txtContenido);
            this.Controls.Add(this.pnlEspacio);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.pnlTools);
            this.Controls.Add(this.pnlBarraTitulo);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(220, 300);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keywords";
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.pnlBarraTitulo.ResumeLayout(false);
            this.pnlBarraTitulo.PerformLayout();
            this.pnlTools.ResumeLayout(false);
            this.pnlTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.CheckBox chkOver;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.TextBox txtFontSize;
        private System.Windows.Forms.Button btnVaciarTexto;
        private System.Windows.Forms.Panel pnlEspacio;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.ToolTip toolTip;
    }
}