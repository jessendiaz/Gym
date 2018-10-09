using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using System.Runtime.InteropServices;



namespace Gym
{
    public partial class frmLogin : Form
    {
        public int xClick = 0, yClick = 0;
        //MySqlCommand Query = new MySqlCommand();
        //MySqlConnection Conexion;
        //MySqlDataReader consultar;
       
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    //Conexion = new MySqlConnection();
            //    //Conexion.ConnectionString = sql;
            //    //Conexion.Open();
            //    //MessageBox.Show("Conectado con éxito");
            //    //Conexion.Close();
            //    get_cliente();
            //}
            //catch (MySqlException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        //public void get_cliente()
        //{
        //    try
        //    {
                
        //    }
        //    catch (MySqlException e)
        //    {
        //        MessageBox.Show(e.Message);
        //    }
        //}

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = string.Empty;
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == string.Empty)
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = string.Empty;
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == string.Empty)
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }



 

        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }

        }
    }
}
