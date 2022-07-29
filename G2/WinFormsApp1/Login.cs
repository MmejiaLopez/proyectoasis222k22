using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioClinico
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            string usuario, contraseña, cargo = " ";
            int columna = 4;
            string[] resultado = new string[columna];
            usuario = txtusuario.Text;
            contraseña = txtcontraseña.Text;
            
            if(radioadministrador.Checked== true)
            {
                cargo = "administrador";
            }

            if (radiotrabajador.Checked == true)
            {
                cargo = "trabajador";
            }


            conexion con = new conexion();
            string sql = "select * from tipousuario where nombre = '"+ usuario +"'";

            resultado = con.buscar(sql, columna);

            
                Cita m = new Cita();
                m.Show();
                this.Hide();
                MessageBox.Show("Bienvenido " + usuario);
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
