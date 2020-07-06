using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Keywords
{
    public partial class Main : Form
    {
        Tema[] temas = new Tema[5];
        int activo = 0;
        public Main()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void chkOver_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOver.Checked)
                this.TopMost = true;
            else
                this.TopMost = false;
        }
        private void selecTextOnFocus(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTitulo.Text))
            {
                ((TextBox)sender).SelectionStart = 0;
                ((TextBox)sender).SelectionLength = ((TextBox)sender).Text.Length;
            }
        }

        private void btnVaciarTexto_Click(object sender, EventArgs e)
        {
            txtContenido.Text = String.Empty;
            txtContenido.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            txtFontSize.Text = txtContenido.Font.Size.ToString();
            temas[activo] = new Tema();
        }

        private void txtFontSize_TextChanged(object sender, EventArgs e)
        {
            FontFamily fontFamily = txtContenido.Font.FontFamily;
            FontStyle fontStyle = txtContenido.Font.Style;
            try
            {
                txtContenido.Font = new Font(fontFamily, float.Parse(txtFontSize.Text), fontStyle);
            }
            catch (Exception) { }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            guardar();
            if (activo == 0)
                activo = 4;
            else
                activo--;
            refrescar();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            guardar();
            if (activo == 4)
                activo = 0;
            else
                activo++;
            
            refrescar();
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.X)
                btnSiguiente.PerformClick();
            if (e.Alt && e.KeyCode == Keys.Z)
                btnAnterior.PerformClick();
            if (e.Alt && e.KeyCode == Keys.Space)
                chkOver.Checked = chkOver.Checked == false;
            if (e.Alt && e.KeyCode == Keys.Q)
                btnVaciarTexto.PerformClick();
        }
        private void guardar()
        {
            temas[activo].Titulo = txtTitulo.Text;
            temas[activo].Contenido = txtContenido.Text;
        }
        private void refrescar()
        {
            if (temas[activo] == null)
                temas[activo] = new Tema();
            txtTitulo.Text = temas[activo].Titulo;
            txtContenido.Text = temas[activo].Contenido;
        }
    }
}
