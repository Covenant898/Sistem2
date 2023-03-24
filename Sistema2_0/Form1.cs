using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System.Web;
using System.Data.SqlClient;
using System.ServiceModel.Description;
using System.Security.Cryptography;

namespace Sistema2_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"D:\ICO10\Aldo\Sistem2\Images\Lava.gif");
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIni_Click(object sender, EventArgs e)
        {
            string usr, pass;
            usr = textBox1.Text;
            pass = textBox2.Text;

            login();
            if(usr == "Os621")
            {
                VentanaFun();
            }
            if (usr == "Sinu43")
            {
                VentanaFun();
            }
            if (usr == "Raul76")
            {
                Trabajador ventana = new Trabajador();
                ventana.Show();

                this.Hide();
            }


        }

        private void btnInvi_Click(object sender, EventArgs e)
        {
            VentanaFun();
        }
        private void VentanaFun()
        {
            Admin ventana = new Admin();
            ventana.Show();

            this.Hide();
        }

        public void login()
        {
            MySqlConnection connection = Conexion.conex();


            string usr, pass;
            usr = textBox1.Text;
            pass = textBox2.Text;
            connection.Open();

            MySqlCommand comando = new MySqlCommand();
            comando.Connection = connection;
            comando.CommandText = ("Select usuario, contrasena, id_tipo from sistema WHERE usuario LIKE @usuario and contrasena LIKE @contrasena");
            comando.Parameters.AddWithValue("@usuario", usr);
            comando.Parameters.AddWithValue("@contrasena", generarMD5(pass));
            


            MySqlDataReader reader = comando.ExecuteReader();

            if (string.IsNullOrEmpty(usr) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Debe llenar todos los campos ");
            }
            else
            {
                
                if (reader.Read())
                {
                    MessageBox.Show("Bienvenido "+ usr);
                }
                else
                {
                    MessageBox.Show("El usuario o contraseña no se encuentra en la BD");
                }
            }

        }
        public String generarMD5(string cadena)
        {
           MD5CryptoServiceProvider provider = new MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.ASCII.GetBytes(cadena);
            data = provider.ComputeHash(data);
            string md5 = string.Empty;
            for (int i = 0; i < data.Length; i++)
            {
                md5 += data[i].ToString("x2").ToLower();            
            }
            return md5;
        }
    }
}
