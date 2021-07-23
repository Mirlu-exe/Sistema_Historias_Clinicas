using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace CapaPresentacion
{
    public partial class frmRecuperarContrasenaEmail : Form
    {

        private static frmRecuperarContrasenaEmail _instancia;
        //Creacion de una Instancia
        public static frmRecuperarContrasenaEmail GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new frmRecuperarContrasenaEmail();
            }
            return _instancia;
        }
        public frmRecuperarContrasenaEmail()
        {
            InitializeComponent();
        }


        public void GenerarNuevaContrasena(string email)
        {
            Random rd = new Random(DateTime.Now.Second);
            int nuevaContrasena = rd.Next(10000, 99999);
            SqlConnection sc = new SqlConnection(CapaDatos.Conexion.Cn);

            SqlCommand cmd = new SqlCommand("spNuevaClave", sc);

            string str = Convert.ToBase64String(BitConverter.GetBytes(nuevaContrasena));

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Correo", email);
            cmd.Parameters.AddWithValue("@Clave", str);
            try
            {
                sc.Open();
                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas != 0)
                {
                    EnviarCorreoContrasena(nuevaContrasena, email);
                }
            }
            catch
            {

            }
        }



        private void EnviarCorreoContrasena(int contrasenaNueva, string correo)
        {
            string contraseña = this.Contrasena;
            string mensaje = string.Empty;

            //Creando el correo electronico
            string destinatario = correo;
            string remitente = "CrystalClearSoporte@gmail.com";
            string asunto = "Nueva Contraseña";
            string cuerpoDelMesaje = "Hola! Usted ha solicitado una nueva contraseña, la cual es: " + " " + Convert.ToString(contrasenaNueva) + ", esta contraseña es provisional, al iniciar sesion le recomendamos cambiarla. Muchas Gracias por usar nuestro Servicio.";
            MailMessage ms = new MailMessage(remitente, destinatario, asunto, cuerpoDelMesaje);


            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("CrystalClearSoporte@gmail.com", contraseña);

            try
            {
                Task.Run(() =>
                {
                    smtp.Send(ms);
                    ms.Dispose();
                    MessageBox.Show("Correo enviado, por favor revise su bandeja de entrada");
                }
                );
                MessageBox.Show("Esta tarea puede tardar unos segundos, por favor espere...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar correo electronico: " + ex.Message);
            }
        }

        public string Contrasena
        {
            get
            {
                return "Karol123*";
            }
        }
        private void btnCorreo_Click(object sender, EventArgs e)
        {
           
        }

        private void btnVerificarExistenciaUsername_Click(object sender, EventArgs e)
        {
           // tmrTiempo.Enabled = true;

            bool RedActiva = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable(); //esto chequea que esta conectado a la red

            if (RedActiva)
            {
                string result = "";
                System.Uri Url = new System.Uri("http://www.google.com/"); //esto es lo que le hace ping a google para saber si hay internet
                System.Net.WebRequest WebRequest;
                WebRequest = System.Net.WebRequest.Create(Url);
                System.Net.WebResponse objResp;
                try
                {
                    objResp = WebRequest.GetResponse();
                    //  result = "Su dispositivo está correctamente conectado a internet";
                    objResp.Close();
                    WebRequest = null;

                    //SqlConnection sc = new SqlConnection(ConfigurationManager.ConnectionStrings["dbLSV"].ToString());        
                    SqlConnection sc = new SqlConnection(CapaDatos.Conexion.Cn);//ConfigurationManager.ConnectionStrings[""].ToString());
                    {
                        SqlCommand cmd = new SqlCommand("spVerificarCorreo", sc);

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text);
                        try
                        {
                            sc.Open();
                            SqlDataReader lector = cmd.ExecuteReader();
                            if (lector.Read())
                            {

                                GenerarNuevaContrasena(txtCorreo.Text);
                            }
                            else
                            {
                                MessageBox.Show("Correo No Encontrado");

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);

                        }
                    }
                }
                catch (Exception ex)
                {
                    result = "Error al intentar conectarse a internet " + ex.Message;
                    WebRequest = null;
                }
            }
            else
            {
                MessageBox.Show("No esta conectado a la Red");
            }

        }
    }
}
