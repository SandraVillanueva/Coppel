using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Npgsql;

namespace Coppel
{
    public class Conexion
    {

        private static string servidor;
        private static string conexion = ("server = localhost\\sqlexpress;database = Coppel; trusted_connection = true;");
        private static SqlConnection cn = new SqlConnection(conexion);
        private static MySqlConnection mysqlconexion;
        private static NpgsqlConnection postgreconexion;

        public static void Manejadores(ComboBox ComboBox3, ComboBox ComboBox1, DataGridView dataGridView1)
        {
            switch (ComboBox3.Text)
            {
                case "SQL":
                    conexion = "server = localhost\\sqlexpress;database = Coppel; trusted_connection = true;";
                    cn = new SqlConnection(conexion);
                    MessageBox.Show("Se realizo correctamente la conexion");
                    ComboBox1.Text = "TABLAS";
                    dataGridView1.Columns.Clear();
                    servidor = "SQL";
                    break;

                case "MYSQL":
                    conexion = "server = localhost;database = Coppel; uid = root;pwd = Ferrocarril1999;";
                    mysqlconexion = new MySqlConnection(conexion);
                    MessageBox.Show("Se realizo correctamente la conexion");
                    ComboBox1.Text = "TABLAS";
                    dataGridView1.Columns.Clear();
                    servidor = "MYSQL";
                    break;

                case "POSTGRE":
                    conexion = "server=localhost;port=5432; database=CoppelPostgre; user id=postgres; password=Ferrocarril1999";
                    postgreconexion = new NpgsqlConnection(conexion);
                    MessageBox.Show("Se realizo correctamente la conexion");
                    ComboBox1.Text = "TABLAS";
                    dataGridView1.Columns.Clear();
                    servidor = "POSTGRE";
                    break;
            }
        }

        public static void tablas(string consulta, DataSet ds, ComboBox ComboBox1, DataGridView DataGridView1)
        {
            if (servidor == "SQL")
            {
                SqlDataAdapter da = new SqlDataAdapter(consulta, cn);
                ds = new DataSet();
                da.Fill(ds, "Coppel");
                DataGridView1.DataSource = ds.Tables["Coppel"];
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            else if (servidor == "MYSQL")
            {
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, mysqlconexion);
                ds = new DataSet();
                da.Fill(ds, "Coppel");
                DataGridView1.DataSource = ds.Tables["Coppel"];
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if (servidor == "POSTGRE")
            {
                postgreconexion.Open();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(consulta, postgreconexion);
                ds = new DataSet();
                da.Fill(ds, "Coppel");
                DataGridView1.DataSource = ds.Tables["Coppel"];
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
               
                postgreconexion.Close();
            }

        }
        public static void insertar(string consulta)
        {
            if (servidor == "SQL")
            {
                try
                {


                    SqlCommand comando = new SqlCommand(consulta, cn);
                    cn.Open();
                    if (comando.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("Registro Exitoso");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("No se ha registrado");
                }
                cn.Close();
            }
            else if (servidor == "MYSQL")

            {
                try
                {


                    MySqlCommand comando = new MySqlCommand(consulta, mysqlconexion);
                    mysqlconexion.Open();
                    if (comando.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("Registro Exitoso");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("No se ha registrado");
                }
                mysqlconexion.Close();
            }

            else if (servidor == "POSTGRE")

            {
                try
                {

                    postgreconexion.Open();
                    NpgsqlCommand comando = new NpgsqlCommand(consulta, postgreconexion);
                   
                    if (comando.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("Registro Exitoso");
                    }
                }
                catch (PostgresException ex)
                {
                    MessageBox.Show("No se ha registrado");
                }
                postgreconexion.Close();
            }
        }

        public static void eliminar(string consulta)
        {
            if (servidor == "SQL")
            {
                try
                {


                    SqlCommand comando = new SqlCommand(consulta, cn);
                    cn.Open();
                    if (comando.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("Registro elimnado exitosamente");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("No se ha eliminado su registro");
                }
                cn.Close();
            }
            else if (servidor == "MYSQL")

            {
                try
                {


                    MySqlCommand comando = new MySqlCommand(consulta, mysqlconexion);
                    mysqlconexion.Open();
                    if (comando.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("Registro elimnado exitosamente");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("No se ha eliminado su registro");
                }
                mysqlconexion.Close();
            }

            else if (servidor == "POSTGRE")

            {
                try
                {

                    postgreconexion.Open();
                    NpgsqlCommand comando = new NpgsqlCommand(consulta, postgreconexion);
                  
                    if (comando.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("Registro elimnado exitosamente");
                    }
                }
                catch (PostgresException ex)
                {
                    MessageBox.Show("No se ha eliminado su registro");
                }
                postgreconexion.Close();
            }
        }
        public static void modificar(string consulta)
        {
            if (servidor == "SQL")
            {
                try
                {


                    SqlCommand comando = new SqlCommand(consulta, cn);
                    cn.Open();
                    if (comando.ExecuteNonQuery() != 0)
                    {

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("No se ha registrado");
                }
                cn.Close();
            }
            else if (servidor == "MYSQL")

            {
                try
                {


                    MySqlCommand comando = new MySqlCommand(consulta, mysqlconexion);
                    mysqlconexion.Open();
                    if (comando.ExecuteNonQuery() != 0)
                    {

                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("No se ha registrado");
                }
                mysqlconexion.Close();
            }

            else if (servidor == "POSTGRE")

            {
                try
                {

                    postgreconexion.Open();
                    NpgsqlCommand comando = new NpgsqlCommand(consulta, postgreconexion);
                   
                    if (comando.ExecuteNonQuery() != 0)
                    {

                    }
                }
                catch (PostgresException ex)
                {
                    MessageBox.Show("No se ha registrado");
                }
                postgreconexion.Close();
            }
        }
    }
}


