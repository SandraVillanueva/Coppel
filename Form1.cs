using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coppel
{
    public partial class Form1 : Form
    {
        string consulta;
        DataSet ds = new DataSet();
        public Form1()
        {
            InitializeComponent();
            Ocultar.ocultar(this);
            button2.Visible = false;
            button5.Visible = false;
            label21.Visible = false;
            comboBox2.Visible = false;
            textBox21.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            consulta = "select * from " + comboBox1.Text;
            Conexion.tablas (consulta, ds, comboBox1, dataGridView1);
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ocultar.ocultar(this);
            if (dataGridView1.Columns.Count == 0)
            {
                MessageBox.Show("Selecciona una tabla");
                return;
            }
            button2.Visible = true;
            button5.Visible = false;
            label21.Visible = false;
            comboBox2.Visible = false;
            textBox21.Visible = false;

            switch (comboBox1.Text)
            {
                case "Apple":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "piezasEntregaran";
                    label2.Text = "totalPedido";
                    label3.Text = "idElectronica";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;

                    break;

                case "AuxiliarPiso":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "apellidoPaterno";
                    label3.Text = "apellidoMaterno";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;

                    break;

                case "BabyLulu":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "piezasEntregaran";
                    label2.Text = "totalPedido";
                    label3.Text = "idBebesNiños";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;

                    break;

                case "Banco":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "apellidoPaterno";
                    label3.Text = "apellidoMaterno";
                    label4.Text = "plazosPagar";
                    label5.Text = "tipoFinanciamiento";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;

                    break;

                case "Barbie":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "piezasEntregaran";
                    label2.Text = "totalPedido";
                    label3.Text = "idJugueteria";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;

                    break;

                case "BebesNiños":
                    label1.Visible = true;
                    label1.Text = "piezasExistencia";
                    textBox1.Visible = true;
                    
                    break;

                case "Cajero":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "apellidoPaterno";
                    label3.Text = "apellidoMaterno";
                    label4.Text = "total";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;

                    break;


                case "Celulares":
                    label1.Visible = true;
                    label1.Text = "piezasExistencia";
                    textBox1.Visible = true;

                    break;

                case "Cliente":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "apellidoPaterno";
                    label3.Text = "apellidoMaterno";
                    label4.Text = "direccion";
                    label5.Text = "telefono";
                    label6.Text = "idContado";
                    label7.Text = "idCredito";
                    label8.Text = "idTarjeta";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    textBox7.Visible = true;
                    textBox8.Visible = true;

                    break;

                case "Cobranza":
                    label1.Visible = true;
                    label1.Text = "totalCobrar";
                    textBox1.Visible = true;

                    break;

                case "ConsolaVideojuego":
                    label1.Visible = true;
                    label1.Text = "piezasExistencia";
                    textBox1.Visible = true;

                    break;

                case "Contado":
                    label1.Visible = true;
                    label2.Visible = true; 
                    label1.Text = "fechaCompra";
                    label2.Text = "total";
                    textBox1.Visible = true;
                    textBox2.Visible = true;

                    break;

                case "Contador":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "apellidoPaterno";
                    label3.Text = "apellidoMaterno";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;

                    break;

                case "Credito":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "tipoCredito";
                    label2.Text = "total";
                    label3.Text = "fechaInicio";
                    label4.Text = "fechaPegar";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;


                    break;

                case "Deportes":
                    label1.Visible = true;
                    label1.Text = "piezasExistencia";
                    textBox1.Visible = true;

                    break;

                case "DineroElectronica":
                    label1.Visible = true;
                    label1.Text = "dineroAcumulado";
                    textBox1.Visible = true;

                    break;

                case "Electronica":
                    label1.Visible = true;
                    label1.Text = "piezasExistencia";
                    textBox1.Visible = true;

                    break;

                case "EncargadoBodega":
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "piezasDisponibles";
                    label2.Text = "idEncargadoEntrega";
                    textBox1.Visible = true;
                    textBox2.Visible = true;

                    break;

                case "EncargadoEntrega":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "apellidoPaterno";
                    label3.Text = "apellidoMaterno";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;

                    break;

                case "Garantia":
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "fechaCompra";
                    label2.Text = "fechaTermino";
                    textBox1.Visible = true;
                    textBox2.Visible = true;

                    break;

                case "Gerente":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "apellidoPaterno";
                    label3.Text = "apellidoMaterno";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;

                    break;

                case "HogarMuebles":
                    label1.Visible = true;
                    label1.Text = "piezasExistencia";
                    textBox1.Visible = true;

                    break;

                case "Hombres":
                    label1.Visible = true;
                    label1.Text = "piezasExistencia";
                    textBox1.Visible = true;

                    break;

                case "Italika":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "piezasEntregaran";
                    label2.Text = "totalPedido";
                    label3.Text = "idMotosAutomotriz";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;

                    break;

                case "JenniferLopez":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "piezasEntregaran";
                    label2.Text = "totalPedido";
                    label3.Text = "idMujeres";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;

                    break;

                case "Jugueteria":
                    label1.Visible = true;
                    label1.Text = "piezasExistencia";
                    textBox1.Visible = true;

                    break;

                case "Levis":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "piezasEntregaran";
                    label2.Text = "totalPedido";
                    label3.Text = "idHombres";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;

                    break;

                case "LineaBlanca":
                    label1.Visible = true;
                    label1.Text = "piezasExistencia";
                    textBox1.Visible = true;

                    break;

                case "Mabe":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "piezasEntregaran";
                    label2.Text = "totalPedido";
                    label3.Text = "idLineaBlanca";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;

                    break;

                case "Mantenimiento":
                    label1.Visible = true;
                    label1.Text = "piezasCambiar";
                    textBox1.Visible = true;

                    break;

                case "MobiBoston":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "piezasEntregaran";
                    label2.Text = "totalPedido";
                    label3.Text = "idTrabajoCasa";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;

                    break;

                case "MotosAutomotriz":
                    label1.Visible = true;
                    label1.Text = "piezasExistencia";
                    textBox1.Visible = true;

                    break;

                case "Mujeres":
                    label1.Visible = true;
                    label1.Text = "piezasExistencia";
                    textBox1.Visible = true;

                    break;

                case "Nike":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "piezasEntregaran";
                    label2.Text = "totalPedido";
                    label3.Text = "idZapatos";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;

                    break;

                case "Nintendo":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "piezasEntregaran";
                    label2.Text = "totalPedido";
                    label3.Text = "idConsolasVideojuego";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;

                    break;

                case "Oferta":
                    label1.Visible = true;
                    label1.Text = "tipoOferta";
                    textBox1.Visible = true;

                    break;

                case "RayBan":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "piezasEntregaran";
                    label2.Text = "totalPedido";
                    label3.Text = "idRelojLentes";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;

                    break;


                case "RecursosHumanos":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "apellidoPaterno";
                    label3.Text = "apellidoMaterno";
                    label4.Text = "idCobranza";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;

             
                    break;


                case "RelojLentes":
                    label1.Visible = true;
                    label1.Text = "piezasExistencia";
                    textBox1.Visible = true;

                    break;

                case "Samsung":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "piezasEntregaran";
                    label2.Text = "totalPedido";
                    label3.Text = "idCelulares";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;

                    break;

                case "Seguro":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "apellidoPaterno";
                    label3.Text = "apellidoMaterno";
                    label4.Text = "tipoSeguro";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;


                    break;

                case "Sistemas":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "apellidoPaterno";
                    label3.Text = "apellidoMaterno";
                    label4.Text = "idElectronica";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;

                    break;

                case "SpringAir":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "piezasEntregaran";
                    label2.Text = "totalPedido";
                    label3.Text = "idHogarMuebles";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;

                    break;

                case "Sucursal":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                    label11.Visible = true;
                    label12.Visible = true;
                    label13.Visible = true;
                    label14.Visible = true;
                    label15.Visible = true;
                    label16.Visible = true;
                    label17.Visible = true;
                    label18.Visible = true;
                    label19.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "telefono";
                    label3.Text = "direccion";
                    label4.Text = "idSeguro";
                    label5.Text = "idGerente";
                    label6.Text = "idMujeres";
                    label7.Text = "idElectronica";
                    label8.Text = "idJugueteria";
                    label9.Text = "idHogarMuebles";
                    label10.Text = "idHomres";
                    label11.Text = "idZapatos";
                    label12.Text = "idConsolaVideoJuego";
                    label13.Text = "idCelulares";
                    label14.Text = "idMotosAutomotriz";
                    label15.Text = "idLineaBlanca";
                    label16.Text = "idBebesNiños";
                    label17.Text = "idRelojLentes";
                    label18.Text = "idDeportes";
                    label19.Text = "idTrabajoCasa";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    textBox7.Visible = true;
                    textBox8.Visible = true;
                    textBox9.Visible = true;
                    textBox10.Visible = true;
                    textBox11.Visible = true;
                    textBox12.Visible = true;
                    textBox13.Visible = true;
                    textBox14.Visible = true;
                    textBox15.Visible = true;
                    textBox16.Visible = true;
                    textBox17.Visible = true;
                    textBox18.Visible = true;
                    textBox19.Visible = true;

                    break;

                case "Tarjeta":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "apellidoPaterno";
                    label3.Text = "apellidoMaterno";
                    label4.Text = "direccion";
                    label5.Text = "telefono";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;

                    break;

                    case "TrabajoCasa":
                    label1.Visible = true;
                    label1.Text = "piezasExistencia";
                    textBox1.Visible = true;

                    break;

                case "Vendedor":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "apellidoPaterno";
                    label3.Text = "apellidoMaterno";
                    label4.Text = "idRecursosHumanos";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;

                    break;

                case "Wilson":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "piezasEntregaran";
                    label2.Text = "totalPedido";
                    label3.Text = "idDeportes";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;

                    break;

                case "Zapatos":
                    label1.Visible = true;
                    label1.Text = "piezasExistencia";
                    textBox1.Visible = true;

                    break;

                case "SucursalOferta":
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idSucursal";
                    label2.Text = "idOferta";
                    textBox1.Visible = true;
                    textBox2.Visible = true;

                    break;

                case "SucursalDineroElectronico":
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idSucursal";
                    label2.Text = "idDineroElectronico";
                    textBox1.Visible = true;
                    textBox2.Visible = true;

                    break;

                case "SucursalContador":
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idSucursal";
                    label2.Text = "idContador";
                    textBox1.Visible = true;
                    textBox2.Visible = true;

                    break;

                case "SucursalDecoradora":
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idSucursal";
                    label2.Text = "idDecoradora";
                    textBox1.Visible = true;
                    textBox2.Visible = true;

                    break;

                case "SucursalCliente":
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idSucursal";
                    label2.Text = "idCliente";
                    textBox1.Visible = true;
                    textBox2.Visible = true;

                    break;

                case "SucursalBanco":
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idSucursal";
                    label2.Text = "idBanco";
                    textBox1.Visible = true;
                    textBox2.Visible = true;

                    break;

                case "ClienteVendedor":
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idCliente";
                    label2.Text = "idVendedor";
                    textBox1.Visible = true;
                    textBox2.Visible = true;

                    break;

                case "VendedorAuxiliarPiso":
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idVendedor";
                    label2.Text = "idAuxiliarPiso";
                    textBox1.Visible = true;
                    textBox2.Visible = true;

                    break;

                case "VendedorGarantia":
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idVendedor";
                    label2.Text = "idGarantia";
                    textBox1.Visible = true;
                    textBox2.Visible = true;

                    break;

                case "GarantiaMantenimiento":
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idGarantia";
                    label2.Text = "idMantenimiento";
                    textBox1.Visible = true;
                    textBox2.Visible = true;

                    break;

                case "ContadoCajero":
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idContado";
                    label2.Text = "idCajero";
                    textBox1.Visible = true;
                    textBox2.Visible = true;

                    break;

                case "CreditoCajero":
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idCredito";
                    label2.Text = "idCajero";
                    textBox1.Visible = true;
                    textBox2.Visible = true;

                    break;

                case "CajeroEncargadoBodega":
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "idCajero";
                    label2.Text = "idEncargadoBodega";
                    textBox1.Visible = true;
                    textBox2.Visible = true;

                    break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Apple":
                    consulta = "insert into Apple (piezasEntregaran, totalPedido, idElectronica) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "AuxiliarPiso":
                    consulta = "insert into AuxiliarPiso (nombre, apellidoPaterno, apellidoMaterno) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "BabyLulu":
                    consulta = "insert into BabyLulu (piezasEntregaran, totalPedido, idBebesNiños) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "Banco":
                    consulta = "insert into Banco (nombre, apellidoPaterno, apellidoMaterno, plazosPagar, tipoFinanciamiento) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "Barbie":
                    consulta = "insert into Barbie (piezasEntregaran, totalPedido, idJugueteria) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "BebesNiños":
                    consulta = "insert into BebesNiños (piezasExistencia) values('" + textBox1.Text +  "');";
                    Conexion.insertar(consulta);
                    break;

                case "Cajero":
                    consulta = "insert into Cajero (nombre, apellidoPaterno, apellidoMaterno, total) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "Celulares":
                    consulta = "insert into Celulares (piezasExistencia) values('" + textBox1.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "Cliente":
                    consulta = "insert into Cliente (nombre, apellidoPaterno, apellidoMaterno, direccion, telefono, idContado, idCredito, idTarjeta) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox8.Text +  "');";
                    Conexion.insertar(consulta);
                    break;

                case "Cobranza":
                    consulta = "insert into Cobranza (totalCobrar) values('" + textBox1.Text  + "');";
                    Conexion.insertar(consulta);
                    break;

                case "ConsolaVideojuego":
                    consulta = "insert into ConsolaVideojuego (piezasExistencia) values('" + textBox1.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "Contado":
                    consulta = "insert into Contado (fechaCompra, total) values('" + textBox1.Text + "','" + textBox2.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "Contador":
                    consulta = "insert into Contador (nombre, apellidoPaterno, apellidoMaterno) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text +  "');";
                    Conexion.insertar(consulta);
                    break;

                case "Credito":
                    consulta = "insert into Credito (tipoCredito, total, fechaInicio, fechaPagar) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "Decoradora":
                    consulta = "insert into Decoradora (nombre, apellidoPaterno, apellidoMaterno) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "Deportes":
                    consulta = "insert into ConsolaVideojuego (piezasExistencia) values('" + textBox1.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "DineroElectronico":
                    consulta = "insert into DineroElectronico (dineroAcumulado) values('" + textBox1.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "Electronica":
                    consulta = "insert into Electronica (piezasExistencia) values('" + textBox1.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "EncargadoBodega":
                    consulta = "insert into EncargadoBodega (piezasDisponibles, idEncargadoEntrega) values('" + textBox1.Text + "','" + textBox2.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "EncargadoEntrega":
                    consulta = "insert into EncargadoEntrega (nombre, apellidoPaterno, apellidoMaterno) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "Garantia":
                    consulta = "insert into Garantia (fechaCompra, fechaTermino) values('" + textBox1.Text + "','" + textBox2.Text +  "');";
                    Conexion.insertar(consulta);
                    break;

                case "Gerente":
                    consulta = "insert into Gerente (nombre, apellidoPaterno, apellidoMaterno) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "HogarMuebles":
                    consulta = "insert into HogarMuebles (piezasExistencia) values('" + textBox1.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "Hombres":
                    consulta = "insert into Hombres (piezasExistencia) values('" + textBox1.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "Italika":
                    consulta = "insert into Italika (piezasEntregaran, totalPedido, idMotosAutomotriz) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "JenniferLopez":
                    consulta = "insert into JenniferLopez (piezasEntregaran, totalPedido, idMujeres) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "Jugueteria":
                    consulta = "insert into Jugueteria (piezasExistencia) values('" + textBox1.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "Levis":
                    consulta = "insert into Levis (piezasEntregaran, totalPedido, idHombres) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "LineaBlanca":
                    consulta = "insert into LineaBlanca (piezasExistencia) values('" + textBox1.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "Mabe":
                    consulta = "insert into Mabe (piezasEntregaran, totalPedido, idLineaBlanca) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "Mantenimiento":
                    consulta = "insert into Mantenimiento (piezasCambiar) values('" + textBox1.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "MobiBoston":
                    consulta = "insert into MobiBoston (piezasEntregaran, totalPedido, idTrabajoCasa) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "Mujeres":
                    consulta = "insert into Mujeres (piezasExistencia) values('" + textBox1.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "Nike":
                    consulta = "insert into Nike (piezasEntregaran, totalPedido, idZapatos) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "Nintendo":
                    consulta = "insert into Nintendo (piezasEntregaran, totalPedido, idConsolasVideojuego) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "');";
                    Conexion.insertar(consulta);
                    break;


                case "Oferta":
                    consulta = "insert into Oferta (tipoOferta) values('" + textBox1.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "RayBan":
                    consulta = "insert into RayBan (piezasEntregaran, totalPedido, idRelojLentes) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "RecursosHumanos":
                    consulta = "insert into RecursosHumanos (nombre, apellidoPaterno, apellidoMaterno, idCobranza) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text +"');";
                    Conexion.insertar(consulta);
                    break;

                case "RelojLentes":
                    consulta = "insert into RelojLentes (piezasExistencia) values('" + textBox1.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "Samsung":
                    consulta = "insert into Samsung (piezasEntregaran, totalPedido, idCelulares) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "');";
                    Conexion.insertar(consulta);
                    break;


                case "Seguro":
                    consulta = "insert into Seguro (nombre, apellidoPaterno, apellidoMaterno, tipoSeguro) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "Sistemas":
                    consulta = "insert into Sistemas (nombre, apellidoPaterno, apellidoMaterno, idSistemas) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "SpringAir":
                    consulta = "insert into SpringAir (nombre, apellidoPaterno, apellidoMaterno, idHogarMuebles) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "Sucursal":
                    consulta = "insert into Sucursal (nombre, telefono, direccion, idSeguro, idGerente, idMujeres, idElectronica, idJugueteria, idHogarMuebles, idHombres, idZapatos, idConsolasVideojuego, idCelulares, idMotosAutomotriz, idLineaBlanca, idBebesNiños, idRelojLentes, idDeportes, idTrabajoCasa) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "','" + textBox15.Text + "','" + textBox16.Text + "','" + textBox17.Text + "','" + textBox18.Text + "','" + textBox19.Text +"');";
                    Conexion.insertar(consulta);
                    break;

                case "Tarjeta":
                    consulta = "insert into Tarjeta (nombre, apellidoPaterno, apellidoMaterno, direccion, telefono) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "TrabajoCasa":
                    consulta = "insert into TrabajoCasa (piezasExistencia) values('" + textBox1.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "Vendedor":
                    consulta = "insert into Vendedor (nombre, apellidoPaterno, apellidoMaterno, direccion, idRecursosHumanos) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "');";
                    Conexion.insertar(consulta);
                    break;


                case "Wilson":
                    consulta = "insert into Wilson (piezasEntregaran, totalPedido, idDeportes) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "Zapatos":
                    consulta = "insert into Zapatos (piezasExistencia) values('" + textBox1.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "SucursalOferta":
                    consulta = "insert into SucursalOferta (idSucursal, idOferta) values('" + textBox1.Text + "','" + textBox2.Text +  "');";
                    Conexion.insertar(consulta);
                    break;

                case "SucursalDineroElectronico":
                    consulta = "insert into SucursalDineroElectronico (idSucursal, idDineroElectronico) values('" + textBox1.Text + "','" + textBox2.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "SucursalContador":
                    consulta = "insert into SucursalContador (idSucursal, idContador) values('" + textBox1.Text + "','" + textBox2.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "SucursalDecoradora":
                    consulta = "insert into SucursalDecoradora (idSucursal, idDecoradora) values('" + textBox1.Text + "','" + textBox2.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "SucursalCliente":
                    consulta = "insert into SucursalCliente (idSucursal, idCliente) values('" + textBox1.Text + "','" + textBox2.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "SucursalBanco":
                    consulta = "insert into SucursalOferta (idSucursal, idBanco) values('" + textBox1.Text + "','" + textBox2.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "ClienteVendedor":
                    consulta = "insert into ClienteVendedor (idCliente, idVendedor) values('" + textBox1.Text + "','" + textBox2.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "VendedorAuxiliarPiso":
                    consulta = "insert into VendedorAuxiliarPiso (idVendedor, idAuxiliarPiso) values('" + textBox1.Text + "','" + textBox2.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "VendedorGarantia":
                    consulta = "insert into VendedorGarantia (idVendedor, idGarantia) values('" + textBox1.Text + "','" + textBox2.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "GarantiaMantenimiento":
                    consulta = "insert into GarantiaMantenimiento (idGarantia, idMantenimiento) values('" + textBox1.Text + "','" + textBox2.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "ContadoCajero":
                    consulta = "insert into ContadoCajero (idContado, idCajero) values('" + textBox1.Text + "','" + textBox2.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "CreditoCajero":
                    consulta = "insert into CreditoCajero (idCredito, idCajero) values('" + textBox1.Text + "','" + textBox2.Text + "');";
                    Conexion.insertar(consulta);
                    break;

                case "CajeroEncargadoBodega":
                    consulta = "insert into CajeroEncargadoBodega (idCajero, idEncargadoBodega) values('" + textBox1.Text + "','" + textBox2.Text + "');";
                    Conexion.insertar(consulta);
                    break;
            }
            actualizar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count == 0)
            {
                MessageBox.Show("Selecciona una tabla");
                return;
            }
            Ocultar.ocultar(this);
            int numero = 0;
            string id = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[numero].Value.ToString();
            string nombre = dataGridView1.Columns[0].HeaderText.ToString();
            string consulta = "delete from " + comboBox1.Text + " where " + nombre + "=" + id;
            Conexion.eliminar(consulta);

            actualizar();
        }
        private void actualizar ()
        {
            button2.Visible = false;
            button5.Visible = false;
            label21.Visible = false;
            comboBox2.Visible = false;
            textBox21.Visible = false;
            Ocultar.ocultar(this);
            consulta = "select * from " + comboBox1.Text;
            Conexion.tablas(consulta, ds, comboBox1, dataGridView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count == 0)
            {
                MessageBox.Show("Selecciona una tabla");
                return;
            }
            button2.Visible = false;
            button5.Visible = true;
            label21.Visible = false;
            comboBox2.Visible = false;
            textBox21.Visible = false;
            string a = dataGridView1.ColumnCount.ToString();
            DataGridViewRow row = dataGridView1.CurrentRow;
            string dato1 = "";
            string dato2 = "";
            string dato3 = "";
            string dato4 = "";
            string dato5 = "";
            string dato6 = "";
            string dato7 = "";
            string dato8 = "";
            string dato9 = "";
            string dato10 = "";
            string dato11 = "";
            string dato12 = "";
            string dato13 = "";
            string dato14 = "";
            string dato15 = "";
            string dato16 = "";
            string dato17 = "";
            string dato18 = "";
            string dato19 = "";
            string dato20 = "";
            if (a == "2")
            {
                dato1 = row.Cells[1].Value.ToString();
                    
            }

            else if (a == "3")
            {
                dato1 = row.Cells[1].Value.ToString();
                dato2 = row.Cells[2].Value.ToString();

            }

            else if (a == "4")
            {
                dato1 = row.Cells[1].Value.ToString();
                dato2 = row.Cells[2].Value.ToString();
                dato3 = row.Cells[3].Value.ToString();
            }

            else if (a == "5")
            {
                dato1 = row.Cells[1].Value.ToString();
                dato2 = row.Cells[2].Value.ToString();
                dato3 = row.Cells[3].Value.ToString();
                dato4 = row.Cells[4].Value.ToString();
            }

            else if (a == "6")
            {
                dato1 = row.Cells[1].Value.ToString();
                dato2 = row.Cells[2].Value.ToString();
                dato3 = row.Cells[3].Value.ToString();
                dato4 = row.Cells[4].Value.ToString();
                dato5 = row.Cells[5].Value.ToString();
            }

            else if (a == "7")
            {
                dato1 = row.Cells[1].Value.ToString();
                dato2 = row.Cells[2].Value.ToString();
                dato3 = row.Cells[3].Value.ToString();
                dato4 = row.Cells[4].Value.ToString();
                dato5 = row.Cells[5].Value.ToString();
                dato6 = row.Cells[6].Value.ToString();
            }

            else if (a == "8")
            {
                dato1 = row.Cells[1].Value.ToString();
                dato2 = row.Cells[2].Value.ToString();
                dato3 = row.Cells[3].Value.ToString();
                dato4 = row.Cells[4].Value.ToString();
                dato5 = row.Cells[5].Value.ToString();
                dato6 = row.Cells[6].Value.ToString();
                dato7 = row.Cells[7].Value.ToString();
            }

            else if (a == "9")
            {
                dato1 = row.Cells[1].Value.ToString();
                dato2 = row.Cells[2].Value.ToString();
                dato3 = row.Cells[3].Value.ToString();
                dato4 = row.Cells[4].Value.ToString();
                dato5 = row.Cells[5].Value.ToString();
                dato6 = row.Cells[6].Value.ToString();
                dato7 = row.Cells[7].Value.ToString();
                dato8 = row.Cells[8].Value.ToString();          

            }

            else if (a == "10")
            {
                dato1 = row.Cells[1].Value.ToString();
                dato2 = row.Cells[2].Value.ToString();
                dato3 = row.Cells[3].Value.ToString();
                dato4 = row.Cells[4].Value.ToString();
                dato5 = row.Cells[5].Value.ToString();
                dato6 = row.Cells[6].Value.ToString();
                dato7 = row.Cells[7].Value.ToString();
                dato8 = row.Cells[8].Value.ToString();
                dato9 = row.Cells[9].Value.ToString();

            }

            else if (a == "11")
            {
                dato1 = row.Cells[1].Value.ToString();
                dato2 = row.Cells[2].Value.ToString();
                dato3 = row.Cells[3].Value.ToString();
                dato4 = row.Cells[4].Value.ToString();
                dato5 = row.Cells[5].Value.ToString();
                dato6 = row.Cells[6].Value.ToString();
                dato7 = row.Cells[7].Value.ToString();
                dato8 = row.Cells[8].Value.ToString();
                dato9 = row.Cells[9].Value.ToString();
                dato10 = row.Cells[10].Value.ToString();

            }

            else if (a == "12")
            {
                dato1 = row.Cells[1].Value.ToString();
                dato2 = row.Cells[2].Value.ToString();
                dato3 = row.Cells[3].Value.ToString();
                dato4 = row.Cells[4].Value.ToString();
                dato5 = row.Cells[5].Value.ToString();
                dato6 = row.Cells[6].Value.ToString();
                dato7 = row.Cells[7].Value.ToString();
                dato8 = row.Cells[8].Value.ToString();
                dato9 = row.Cells[9].Value.ToString();
                dato10 = row.Cells[10].Value.ToString();
                dato11 = row.Cells[11].Value.ToString();

            }

            else if (a == "13")
            {
                dato1 = row.Cells[1].Value.ToString();
                dato2 = row.Cells[2].Value.ToString();
                dato3 = row.Cells[3].Value.ToString();
                dato4 = row.Cells[4].Value.ToString();
                dato5 = row.Cells[5].Value.ToString();
                dato6 = row.Cells[6].Value.ToString();
                dato7 = row.Cells[7].Value.ToString();
                dato8 = row.Cells[8].Value.ToString();
                dato9 = row.Cells[9].Value.ToString();
                dato10 = row.Cells[10].Value.ToString();
                dato11 = row.Cells[11].Value.ToString();
                dato12 = row.Cells[12].Value.ToString(); 

            }

            else if (a == "14")
            {
                dato1 = row.Cells[1].Value.ToString();
                dato2 = row.Cells[2].Value.ToString();
                dato3 = row.Cells[3].Value.ToString();
                dato4 = row.Cells[4].Value.ToString();
                dato5 = row.Cells[5].Value.ToString();
                dato6 = row.Cells[6].Value.ToString();
                dato7 = row.Cells[7].Value.ToString();
                dato8 = row.Cells[8].Value.ToString();
                dato9 = row.Cells[9].Value.ToString();
                dato10 = row.Cells[10].Value.ToString();
                dato11 = row.Cells[11].Value.ToString();
                dato12 = row.Cells[12].Value.ToString();
                dato13 = row.Cells[13].Value.ToString();

            }

            else if (a == "15")
            {
                dato1 = row.Cells[1].Value.ToString();
                dato2 = row.Cells[2].Value.ToString();
                dato3 = row.Cells[3].Value.ToString();
                dato4 = row.Cells[4].Value.ToString();
                dato5 = row.Cells[5].Value.ToString();
                dato6 = row.Cells[6].Value.ToString();
                dato7 = row.Cells[7].Value.ToString();
                dato8 = row.Cells[8].Value.ToString();
                dato9 = row.Cells[9].Value.ToString();
                dato10 = row.Cells[10].Value.ToString();
                dato11 = row.Cells[11].Value.ToString();
                dato12 = row.Cells[12].Value.ToString();
                dato13 = row.Cells[13].Value.ToString();
                dato14 = row.Cells[14].Value.ToString();

            }

            else if (a == "16")
            {
                dato1 = row.Cells[1].Value.ToString();
                dato2 = row.Cells[2].Value.ToString();
                dato3 = row.Cells[3].Value.ToString();
                dato4 = row.Cells[4].Value.ToString();
                dato5 = row.Cells[5].Value.ToString();
                dato6 = row.Cells[6].Value.ToString();
                dato7 = row.Cells[7].Value.ToString();
                dato8 = row.Cells[8].Value.ToString();
                dato9 = row.Cells[9].Value.ToString();
                dato10 = row.Cells[10].Value.ToString();
                dato11 = row.Cells[11].Value.ToString();
                dato12 = row.Cells[12].Value.ToString();
                dato13 = row.Cells[13].Value.ToString();
                dato14 = row.Cells[14].Value.ToString();
                dato15 = row.Cells[15].Value.ToString();

            }

            else if (a == "17")
            {
                dato1 = row.Cells[1].Value.ToString();
                dato2 = row.Cells[2].Value.ToString();
                dato3 = row.Cells[3].Value.ToString();
                dato4 = row.Cells[4].Value.ToString();
                dato5 = row.Cells[5].Value.ToString();
                dato6 = row.Cells[6].Value.ToString();
                dato7 = row.Cells[7].Value.ToString();
                dato8 = row.Cells[8].Value.ToString();
                dato9 = row.Cells[9].Value.ToString();
                dato10 = row.Cells[10].Value.ToString();
                dato11 = row.Cells[11].Value.ToString();
                dato12 = row.Cells[12].Value.ToString();
                dato13 = row.Cells[13].Value.ToString();
                dato14 = row.Cells[14].Value.ToString();
                dato15 = row.Cells[15].Value.ToString();
                dato16 = row.Cells[16].Value.ToString();

            }

            else if (a == "18")
            {
                dato1 = row.Cells[1].Value.ToString();
                dato2 = row.Cells[2].Value.ToString();
                dato3 = row.Cells[3].Value.ToString();
                dato4 = row.Cells[4].Value.ToString();
                dato5 = row.Cells[5].Value.ToString();
                dato6 = row.Cells[6].Value.ToString();
                dato7 = row.Cells[7].Value.ToString();
                dato8 = row.Cells[8].Value.ToString();
                dato9 = row.Cells[9].Value.ToString();
                dato10 = row.Cells[10].Value.ToString();
                dato11 = row.Cells[11].Value.ToString();
                dato12 = row.Cells[12].Value.ToString();
                dato13 = row.Cells[13].Value.ToString();
                dato14 = row.Cells[14].Value.ToString();
                dato15 = row.Cells[15].Value.ToString();
                dato16 = row.Cells[16].Value.ToString();
                dato17 = row.Cells[17].Value.ToString();

            }

            else if (a == "19")
            {
                dato1 = row.Cells[1].Value.ToString();
                dato2 = row.Cells[2].Value.ToString();
                dato3 = row.Cells[3].Value.ToString();
                dato4 = row.Cells[4].Value.ToString();
                dato5 = row.Cells[5].Value.ToString();
                dato6 = row.Cells[6].Value.ToString();
                dato7 = row.Cells[7].Value.ToString();
                dato8 = row.Cells[8].Value.ToString();
                dato9 = row.Cells[9].Value.ToString();
                dato10 = row.Cells[10].Value.ToString();
                dato11 = row.Cells[11].Value.ToString();
                dato12 = row.Cells[12].Value.ToString();
                dato13 = row.Cells[13].Value.ToString();
                dato14 = row.Cells[14].Value.ToString();
                dato15 = row.Cells[15].Value.ToString();
                dato16 = row.Cells[16].Value.ToString();
                dato17 = row.Cells[17].Value.ToString();
                dato18 = row.Cells[18].Value.ToString();

            }


            else if (a == "20")
            {
                dato1 = row.Cells[1].Value.ToString();
                dato2 = row.Cells[2].Value.ToString();
                dato3 = row.Cells[3].Value.ToString();
                dato4 = row.Cells[4].Value.ToString();
                dato5 = row.Cells[5].Value.ToString();
                dato6 = row.Cells[6].Value.ToString();
                dato7 = row.Cells[7].Value.ToString();
                dato8 = row.Cells[8].Value.ToString();
                dato9 = row.Cells[9].Value.ToString();
                dato10 = row.Cells[10].Value.ToString();
                dato11 = row.Cells[11].Value.ToString();
                dato12 = row.Cells[12].Value.ToString();
                dato13 = row.Cells[13].Value.ToString();
                dato14 = row.Cells[14].Value.ToString();
                dato15 = row.Cells[15].Value.ToString();
                dato16 = row.Cells[16].Value.ToString();
                dato17 = row.Cells[17].Value.ToString();
                dato18 = row.Cells[18].Value.ToString();
                dato19 = row.Cells[19].Value.ToString();


            }

            else if (a == "21")
            {
                dato1 = row.Cells[1].Value.ToString();
                dato2 = row.Cells[2].Value.ToString();
                dato3 = row.Cells[3].Value.ToString();
                dato4 = row.Cells[4].Value.ToString();
                dato5 = row.Cells[5].Value.ToString();
                dato6 = row.Cells[6].Value.ToString();
                dato7 = row.Cells[7].Value.ToString();
                dato8 = row.Cells[8].Value.ToString();
                dato9 = row.Cells[9].Value.ToString();
                dato10 = row.Cells[10].Value.ToString();
                dato11 = row.Cells[11].Value.ToString();
                dato12 = row.Cells[12].Value.ToString();
                dato13 = row.Cells[13].Value.ToString();
                dato14 = row.Cells[14].Value.ToString();
                dato15 = row.Cells[15].Value.ToString();
                dato16 = row.Cells[16].Value.ToString();
                dato17 = row.Cells[17].Value.ToString();
                dato18 = row.Cells[18].Value.ToString();
                dato19 = row.Cells[19].Value.ToString();
                dato20 = row.Cells[20].Value.ToString();

            }

            switch (comboBox1.Text)
            {
                case "Apple":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "piezasEntregaran";
                    label2.Text = "totalPedido";
                    label3.Text = "idElectronica";
                    label4.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox1.Focus();
                    break;

                case "AuxiliarPiso":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label3.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "apellidoPaterno";
                    label3.Text = "apellidoMaterno";
                    label4.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox1.Focus();
                    break;


                case "BabyLulu":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "piezasEntregaran";
                    label2.Text = "totalPedido";
                    label3.Text = "idBebesNiños";
                    label4.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox1.Focus();
                    break;

                case "Banco":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "apellidoPaterno";
                    label3.Text = "apellidoMaterno";
                    label4.Text = "plazosPagar";
                    label5.Text = "tipoFinanciamiento";
                    label6.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox5.Text = dato5;
                    textBox6.Text = dato6;
                    textBox1.Focus();
                    break;

                case "Barbie":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "piezasEntregaran";
                    label2.Text = "totalPedido";
                    label3.Text = "idJugueteria";
                    label4.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox1.Focus();
                    break;

                case "BebesNiños":
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "piezasExistencia";
                    label2.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox1.Focus();
                    break;

                case "Cajero":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "apellidoPaterno";
                    label3.Text = "apellidoMaterno";
                    label4.Text = "total";
                    label5.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox5.Text = dato5;
                    textBox1.Focus();
                    break;

                case "Celulares":
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "piezasExistencia";
                    label2.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox1.Focus();
                    break;

                case "Cliente":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "apellidoPaterno";
                    label3.Text = "apellidoMaterno";
                    label4.Text = "direccion";
                    label5.Text = "telefono";
                    label6.Text = "idContado";
                    label7.Text = "idCredito";
                    label8.Text = "idTarjeta";
                    label9.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    textBox7.Visible = true;
                    textBox8.Visible = true;
                    textBox9.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox5.Text = dato5;
                    textBox6.Text = dato6;
                    textBox7.Text = dato7;
                    textBox8.Text = dato8;
                    textBox9.Text = dato9;
                    textBox1.Focus();
                    break;

                case "Cobranza":
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "totalCobrar";
                    label2.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox1.Focus();
                    break;

                case "ConsolasVideojuego":
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "piezasExistencia";
                    label2.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox1.Focus();
                    break;

                case "Contado":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "fechaCompra";
                    label2.Text = "total";
                    label3.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox1.Focus();
                    break;

                case "Contador":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "apellidoPaterno";
                    label3.Text = "apellidoMaterno";
                    label4.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox1.Focus();
                    break;

                case "Credito":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label1.Text = "tipoCredito";
                    label2.Text = "total";
                    label3.Text = "fechaInicio";
                    label4.Text = "fechaPagar";
                    label5.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox5.Text = dato5;
                    textBox1.Focus();
                    break;

                case "Decoradora":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "apellidoPaterno";
                    label3.Text = "apellidoMaterno";
                    label4.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox1.Focus();
                    break;

                case "Deportes":
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "piezasExistencia";
                    label2.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox1.Focus();
                    break;

                case "DineroElectronico":
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "dineroAcumulado";
                    label2.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox1.Focus();
                    break;

                case "Electronica":
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "piezasExistencia";
                    label2.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox1.Focus();
                    break;

                case "EncargadosBodega":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "piezasDisponibles";
                    label2.Text = "idEncargadoEntrega";
                    label3.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato2;
                    textBox1.Focus();
                    break;

                case "EncargadoEntrega":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "apellidoPaterno";
                    label3.Text = "apellidoMaterno";
                    label4.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox1.Focus();
                    break;

                case "Garantia":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "fechaCompra";
                    label2.Text = "fechaTermino";
                    label3.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox1.Focus();
                    break;

                case "Gerente":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "apellidoPaterno";
                    label3.Text = "apellidoMaterno";
                    label4.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox1.Focus();
                    break;

                case "HogarMuebles":
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "piezasExistencia";
                    label2.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox1.Focus();
                    break;

                case "Hombres":
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "piezasExistencia";
                    label2.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox1.Focus();
                    break;

                case "Italika":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "piezasEntregaran";
                    label2.Text = "totalPedido";
                    label3.Text = "idMotosAutomotriz";
                    label4.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox1.Focus();
                    break;

                case "JenniferLopez":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "piezasEntregaran";
                    label2.Text = "totalPedido";
                    label3.Text = "idMujeres";
                    label4.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox1.Focus();
                    break;


                case "Jugueteria":
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "piezasExistencia";
                    label2.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox1.Focus();
                   break;

                case "Levis":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "piezasEntregaran";
                    label2.Text = "totalPedido";
                    label3.Text = "idHombres";
                    label4.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox1.Focus();
                    break;

                case "LineaBlanca":
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "piezasExistencia";
                    label2.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox1.Focus();
                    break;

                case "Mabe":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "piezasEntregaran";
                    label2.Text = "totalPedido";
                    label3.Text = "idLineaBlanca";
                    label4.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox1.Focus();
                    break;

                case "Mantenimiento":
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "piezasCambiar";
                    label2.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox1.Focus();
                    break;

                case "MobiBoston":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "piezasEntregaran";
                    label2.Text = "totalPedido";
                    label3.Text = "idTrabajoCasa";
                    label4.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox1.Focus();
                    break;

                case "Mujeres":
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "piezasExistencia";
                    label2.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox1.Focus();
                    break;

                case "Nike":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "piezasEntregaran";
                    label2.Text = "totalPedido";
                    label3.Text = "idZapatos";
                    label4.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox1.Focus();
                    break;

                case "Nintendo":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "piezasEntregaran";
                    label2.Text = "totalPedido";
                    label3.Text = "idConsolasVideojuego";
                    label4.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox1.Focus();
                    break;

                case "Oferta":
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "tipoOferta";
                    label2.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox1.Focus();
                    break;

                case "RayBan":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "piezasEntregaran";
                    label2.Text = "totalPedido";
                    label3.Text = "idRelojLentes";
                    label4.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox1.Focus();
                    break;

                case "RecursosHumanos":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "apellidoPaterno";
                    label3.Text = "apellidoMaterno";
                    label4.Text = "idCobranza";
                    label5.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox5.Text = dato5;
                    textBox1.Focus();
                    break;

                case "RelojLentes":
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "piezasExistencia";
                    label2.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox1.Focus();
                    break;

                case "Samsung":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "piezasEntregaran";
                    label2.Text = "totalPedido";
                    label3.Text = "idCelulares";
                    label4.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox1.Focus();
                    break;

                case "Seguro":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "apellidoPaterno";
                    label3.Text = "apellidoMaterno";
                    label4.Text = "idElectronica";
                    label5.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox5.Text = dato5;
                    textBox1.Focus();
                    break;

                case "Spring air":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "piezasEntregaran";
                    label2.Text = "totalPedido";
                    label3.Text = "idHogarMuebles";
                    label4.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox1.Focus();
                    break;

                case "Sucursal":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                    label11.Visible = true;
                    label12.Visible = true;
                    label13.Visible = true;
                    label14.Visible = true;
                    label15.Visible = true;
                    label16.Visible = true;
                    label17.Visible = true;
                    label18.Visible = true;
                    label19.Visible = true;
                    label20.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "telefono";
                    label3.Text = "direccion";
                    label4.Text = "idSeguro";
                    label5.Text = "idGerente";
                    label6.Text = "idMujeres";
                    label7.Text = "idElectronica";
                    label8.Text = "idJugueteria";
                    label9.Text = "idHogarMuebles";
                    label10.Text = "idHombres";
                    label11.Text = "idZapatos";
                    label12.Text = "idConsolasVideojuego";
                    label13.Text = "idCelulares";
                    label14.Text = "idMotosAutomotriz";
                    label15.Text = "idLineaBlanca";
                    label16.Text = "idBebesNiños";
                    label17.Text = "idRelojLentes";
                    label18.Text = "idDeportes";
                    label19.Text = "idTrabajoCasa";
                    label20.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    textBox7.Visible = true;
                    textBox8.Visible = true;
                    textBox9.Visible = true;
                    textBox10.Visible = true;
                    textBox11.Visible = true;
                    textBox12.Visible = true;
                    textBox13.Visible = true;
                    textBox14.Visible = true;
                    textBox15.Visible = true;
                    textBox16.Visible = true;
                    textBox17.Visible = true;
                    textBox18.Visible = true;
                    textBox19.Visible = true;
                    textBox20.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox5.Text = dato5;
                    textBox6.Text = dato6;
                    textBox7.Text = dato7;
                    textBox8.Text = dato8;
                    textBox9.Text = dato9;
                    textBox10.Text = dato10;
                    textBox11.Text = dato11;
                    textBox12.Text = dato12;
                    textBox13.Text = dato13;
                    textBox14.Text = dato14;
                    textBox15.Text = dato15;
                    textBox16.Text = dato16;
                    textBox17.Text = dato17;
                    textBox18.Text = dato18;
                    textBox19.Text = dato19;
                    textBox20.Text = dato20;
                    textBox1.Focus();
                    break;

                case "Tarjeta":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label4.Visible = true;
                    label6.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "apellidoPaterno";
                    label3.Text = "apellidoMaterno";
                    label4.Text = "direccion";
                    label5.Text = "direccion";
                    label6.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox5.Text = dato5;
                    textBox6.Text = dato6;
                    textBox1.Focus();
                    break;


                case "TrabajoCasa":
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "piezasExistencia";
                    label2.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox1.Focus();
                    break;

                case "Vendedor":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label1.Text = "nombre";
                    label2.Text = "apellidoPaterno";
                    label3.Text = "apellidoMaterno";
                    label4.Text = "idRecursosHumanos";
                    label5.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox5.Text = dato5;
                    textBox1.Focus();
                    break;

                case "Wilson":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "piezasEntregaran";
                    label2.Text = "totalPedido";
                    label3.Text = "idDeportes";
                    label4.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox4.Text = dato4;
                    textBox1.Focus();
                    break;


                case "Zapatos":
                    label1.Visible = true;
                    label2.Visible = true;
                    label1.Text = "piezasExistencia";
                    label2.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox1.Focus();
                    break;

                case "SucursalOferta":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idSucursal";
                    label2.Text = "idOferta";
                    label3.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox1.Focus();
                    break;

                case "SucursalDineroElectronico":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idSucursal";
                    label2.Text = "idDineroElectronico";
                    label3.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox1.Focus();
                    break;

                case "SucursalContador":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idSucursal";
                    label2.Text = "idContador";
                    label3.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox1.Focus();
                    break;

                case "SucursalDecoradora":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idSucursal";
                    label2.Text = "idDecoradora";
                    label3.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox1.Focus();
                    break;

                case "SucursalCliente":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idSucursal";
                    label2.Text = "idCliente";
                    label3.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox1.Focus();
                    break;

                case "SucursalBanco":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idSucursal";
                    label2.Text = "idBanco";
                    label3.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox1.Focus();
                    break;

                case "ClienteVendedor":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idCliente";
                    label2.Text = "idVendedor";
                    label3.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox1.Focus();
                    break;

                case "VendedorAuxiliarPiso":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idVendedor";
                    label2.Text = "idAxuiliarPiso";
                    label3.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox1.Focus();
                    break;

                case "VendedorGarantia":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idVendedor";
                    label2.Text = "idGarantia";
                    label3.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox1.Focus();
                    break;

                case "GarantiaMantenimiento":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idGarantia";
                    label2.Text = "idMantenimiento";
                    label3.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox1.Focus();
                    break;

                case "ContadoCajero":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idContado";
                    label2.Text = "idCajero";
                    label3.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox1.Focus();
                    break;

                case "CreditoCajero":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idCredito";
                    label2.Text = "idCajero";
                    label3.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox1.Focus();
                    break;

                case "CajeroEncargadoBodega":
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label1.Text = "idCajero";
                    label2.Text = "idEncargadoBodega";
                    label3.Text = "estatus";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox1.Text = dato1;
                    textBox2.Text = dato2;
                    textBox3.Text = dato3;
                    textBox1.Focus();
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            string nombre = dataGridView1.Columns[0].HeaderText.ToString();

            switch (comboBox1.Text)
            {
                case "Apple":
                    consulta = "update Apple set piezasEntregaran = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Apple set totalPedido = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Apple set idElectronica = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Apple set estatus = '" + textBox4.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "AuxiliarPiso":
                    consulta = "update AuxiliarPiso set nombre = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update AuxiliarPiso set apellidoPaterno = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update AuxiliarPiso set apellidoMaterno = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update AuxiliarPiso set estatus = '" + textBox4.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "BebeLulu":
                    consulta = "update BebeLulu set piezasEntregaran = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update BebeLulu set totalPedido = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update BebeLulu set idBebesNiños = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update BebeLulu set estatus = '" + textBox4.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "Banco":
                    consulta = "update Banco set nombre = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Banco set apellidoPaterno = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Banco set apellidoMaterno = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Banco set plazosPagar = '" + textBox4.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Banco set tipoFinanciamiento = '" + textBox5.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Banco set estatus = '" + textBox6.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "Barbie":
                    consulta = "update Barbie set piezasEntregaran = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Barbie set totalPedido = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Barbie set idJugueteria = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Barbie set estatus = '" + textBox4.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "BebesNiños":
                    consulta = "update BebesNiños set piezasExistencia = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update BebesNiños set estatus = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;


                case "Cajero":
                    consulta = "update Cajero set nombre = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Cajero set apellidoPaterno = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Cajero set apellidoMaterno = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Cajero set total = '" + textBox4.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Cajero set estatus = '" + textBox5.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "Celulares":
                    consulta = "update Celulares set piezasExistencia = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Celulares set estatus = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "Cliente":
                    consulta = "update Cliente set nombre = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Cliente set apellidoPaterno = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Cliente set apellidoMaterno = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Cliente set direccion = '" + textBox4.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Cliente set telefono = '" + textBox5.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Cliente set idContado = '" + textBox6.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Cliente set idCredito = '" + textBox7.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Cliente set idTarjeta = '" + textBox8.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Cliente set estatus = '" + textBox9.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "Cobanza":
                    consulta = "update Cobranza set totalCobrar = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Cobranza set estatus = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "ConsolasVideojuego":
                    consulta = "update ConsolasVideojuego set piezasExistencia = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update ConsolasVideojuego set estatus = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "Contado":
                    consulta = "update Contado set fechaCompra = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Contado set total = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Contado set estatus = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "Contador":
                    consulta = "update Contador set nombre = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Contador set apellidoPaterno = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Contador set apellidoMaterno = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Contador set estatus = '" + textBox4.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "Credito":
                    consulta = "update Credito set tipoCredito = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Credito set total = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Credito set fechaInicio = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Credito set fechaPagar = '" + textBox4.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Credito set estatus = '" + textBox5.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;


                case "Decoradora":
                    consulta = "update Decoradora set nombre = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Decoradora set apellidoPaterno = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Decoradora set apellidoMaterno = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Decoradora set estatus = '" + textBox4.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;


                case "Deportes":
                    consulta = "update Deportes set piezasExistencia = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Deportes set estatus = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "DineroElectronico":
                    consulta = "update DineroElectronico set dineroAcumulado = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update DineroElectronico set estatus = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;


                case "Electronica":
                    consulta = "update Electronica set piezasExistencia = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Electronica set estatus = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "EncargadoBodega":
                    consulta = "update EncargadoBodega set piezasDisponibles = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update EncargadoBodega set idEncargadoEntrega = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update EncargadoBodega set estatus = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;


                case "EncargadoEntrega":
                    consulta = "update EncargadoEntrega set nombre = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update EncargadoEntrega set apellidoPaterno = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update EncargadoEntrega set apellidoMaterno = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update EncargadoEntrega set estatus = '" + textBox4.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "Garantia":
                    consulta = "update Garantia set fechaCompra = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Garantia set fechaTermino = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Garantia set estatus = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "Gerente":
                    consulta = "update Gerente set nombre = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Gerente set apellidoPaterno = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Gerente set apellidoMaterno = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Gerente set estatus = '" + textBox4.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "HogarMuebles":
                    consulta = "update HogarMuebles set piezasExistencia = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update HogarMuebles set estatus = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "Hombres":
                    consulta = "update Hombres set piezasExistencia = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Hombres set estatus = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "Italika":
                    consulta = "update Italika set piezasEntregaran = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Italika set totalPedido = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Italika set idMotosAutomotriz = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Italika set estatus = '" + textBox4.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "JenniferLopez":
                    consulta = "update JenniferLopez set piezasEntregaran = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update JenniferLopez set totalPedido = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update JenniferLopez set idMujeres = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update JenniferLopez set estatus = '" + textBox4.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "Jugueteria":
                    consulta = "update Jugueteria set piezasExistencia = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Jugueteria set estatus = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "Levis":
                    consulta = "update Levis set piezasEntregaran = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Levis set totalPedido = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Levis set idHombres = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Levis set estatus = '" + textBox4.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "LineaBlanca":
                    consulta = "update LineaBlanca set piezasExistencia = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update LineaBlanca set estatus = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "Mabe":
                    consulta = "update Mabe set piezasEntregaran = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Mabe set totalPedido = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Mabe set idLineaBlanca = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Mabe set estatus = '" + textBox4.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "Mantenimiento":
                    consulta = "update Mantenimiento set piezasCambiar = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Mantenimiento set estatus = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "MobiBoston":
                    consulta = "update MobiBoston set piezasEntregaran = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update MobiBoston set totalPedido = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update MobiBoston set idTrabajoCasa = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update MobiBoston set estatus = '" + textBox4.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "Mujeres":
                    consulta = "update Mujeres set piezasExistencia = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Mujeres set estatus = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;


                case "Nike":
                    consulta = "update Nike set piezasEntregaran = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Nike set totalPedido = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Nike set idZapatos = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Nike set estatus = '" + textBox4.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;


                case "Nintendo":
                    consulta = "update Nintendo set piezasEntregaran = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Nintendo set totalPedido = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Nintendo set idConsolasVideojuego = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Nintendo set estatus = '" + textBox4.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;


                case "Oferta":
                    consulta = "update Oferta set tipoOferta = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Oferta set estatus = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "RayBan":
                    consulta = "update RayBan set piezasEntregaran = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update RayBan set totalPedido = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update RayBan set idRelojLentes = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update RayBan set estatus = '" + textBox4.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "RecursosHumanos":
                    consulta = "update RecusosHumanos set nombre = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update RecursosHumanos set apellidoPaterno = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update RecursosHumanos set apellidoMaterno = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update RecursosHumanos set idCobranza = '" + textBox4.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update RecursosHumanos set estatus = '" + textBox5.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;


                case "RelojLentes":
                    consulta = "update RelojLentes set piezasExistencia = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update RelojLentes set estatus = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;


                case "Samsung":
                    consulta = "update Samsung set piezasEntregaran = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Samsung set totalPedido = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Samsung set idCelulares = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Samsung set estatus = '" + textBox4.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "Seguro":
                    consulta = "update Seguro set nombre = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Seguro set apellidoPaterno = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Seguro set apellidoMaterno = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Seguro set tipoSeguro = '" + textBox4.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Seguro set estatus = '" + textBox5.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "Sistemas":
                    consulta = "update Sistemas set nombre = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Sistemas set apellidoPaterno = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Sistemas set apellidoMaterno = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Sistemas set idElectronica = '" + textBox4.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Sistemas set estatus = '" + textBox5.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "SpringAir":
                    consulta = "update SpringAir set piezasEntregaran = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update SpringAir set totalPedido = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update SpringAir set idHogarMuebles = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update SpringAir set estatus = '" + textBox4.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "Sucursal":
                    consulta = "update Sucursal set nombre = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Sucursal set telefono = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Sucursal set direccion = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Sucursal set idSeguro = '" + textBox4.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Sucursal set idGerente = '" + textBox5.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Sucursal set idMujeres = '" + textBox6.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Sucursal set idElectronica = '" + textBox7.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Sucursal set idJugueteria = '" + textBox8.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Sucursal set idHogarMuebles = '" + textBox9.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Sucursal set idHombres = '" + textBox10.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Sucursal set idZapatos = '" + textBox11.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Sucursal set idConsolasVideojuego = '" + textBox12.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Sucursal set idCelulares = '" + textBox13.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Sucursal set idMotosAutomotriz = '" + textBox14.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Sucursal set idLineaBlanca = '" + textBox15.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Sucursal set idBebesNiños = '" + textBox16.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Sucursal set idRelojLentes = '" + textBox17.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Sucursal set idDeportes = '" + textBox18.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Sucursal set idTrabajoCasa = '" + textBox19.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Sucursal set estatus = '" + textBox20.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "Tarjeta":
                    consulta = "update Tarjeta set nombre = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Tarjeta set apellidoPaterno = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Tarjeta set apellidoMaterno = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Tarjeta set direccion = '" + textBox4.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Tarjeta set telefono = '" + textBox5.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Tarjeta set estatus = '" + textBox6.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "TrabajoCasa":
                    consulta = "update TrabajoCasa set piezasExistencia = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update TrabajoCasa set estatus = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "Vendedor":
                    consulta = "update Vendedor set nombre = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Vendedor set apellidoPaterno = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Vendedor set apellidoMaterno = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Vendedor set idRecursosHumanos = '" + textBox4.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Vendedor set estatus = '" + textBox5.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "Wilson":
                    consulta = "update Wilson set piezasEntregaran = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Wilson set totalPedido = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Wilson set idDeportes = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Wilson set estatus = '" + textBox4.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "Zapatos":
                    consulta = "update Zapatos set piezasExistencia = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update Zapatos set estatus = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;


                case "SucursalOferta":
                    consulta = "update SucursalOferta set idSucursal = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update SucursalOferta set idOferta = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update SucursalOferta set estatus = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "SucursalDineroElectronico":
                    consulta = "update SucursalDineroElectronico set idSucursal = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update SucursalDineroElectronico set idDineroElectronico = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update SucursalOferta set estatus = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "SucursalContador":
                    consulta = "update SucursalContador set idSucursal = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update SucursalContador set idContador = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update SucursalContador set estatus = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "SucursalDecoradora":
                    consulta = "update SucursalDecoradora set idSucursal = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update SucursalDecoradora set idDecoradora = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update SucursalDecoradora set estatus = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "SucursalCliente":
                    consulta = "update SucursalCliente set idSucursal = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update SucursalCliente set idCliente = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update SucursalCliente set estatus = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "SucursalBanco":
                    consulta = "update SucursalBanco set idSucursal = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update SucursalBanco set idBanco = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update SucursalBanco set estatus = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "ClienteVendedor":
                    consulta = "update ClienteVendedor set idCliente = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update ClienteVendedor set idVendedor = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update ClienteVendedor set estatus = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "VendedorAuxiliarPiso":
                    consulta = "update VendedorAuxiliarPiso set idVendedor = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update VendedorAuxiliarPiso set idAuxiliarPiso = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update VendedorAuxiliarPiso set estatus = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "VendedorGarantia":
                    consulta = "update VendedorGarantia set idVendedor = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update VendedorGarantia set idGarantia = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update VendedorGarantia set estatus = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "GarantiaMantenimiento":
                    consulta = "update GarantiaMantenimiento set idGarantia = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update GarantiaMantenimiento set idMantenimiento = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update GarantiaMantenimiento set estatus = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "ContadoCajero":
                    consulta = "update ContadoCajero set idContado = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update ContadoCajero set idCajero = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update ContadoCajero set estatus = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "CreditoCajero":
                    consulta = "update CreditoCajero set idCredito = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update CreditoCajero set idCajero = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update CreditoCajero set estatus = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

                case "CajeroEncargadoBodega":
                    consulta = "update CajeroEncargadoBodega set idCajero = '" + textBox1.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update CajeroEncargadoBodega set idEncargadoBodega = '" + textBox2.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    consulta = "update CajeroEncargadoBodega set estatus = '" + textBox3.Text + "' where " + nombre + "=" + id;
                    Conexion.modificar(consulta);
                    break;

            }

            actualizar();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ocultar.ocultar(this);
            comboBox2.Visible = true;
            comboBox2.Items.Clear();
            button2.Visible = false;
            button5.Visible = false;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                string nombre = dataGridView1.Columns[i].HeaderText.ToString();
                comboBox2.Items.Add(nombre);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label21.Visible = true;
            textBox21.Visible = true;
            label21.Text = comboBox2.Text;
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_KeyUp(object sender, KeyEventArgs e)
        {
            consulta = "select * from " + comboBox1.Text + " where " + comboBox2.Text + " like('" + textBox21.Text + "%')";
            Conexion.tablas(consulta, ds, comboBox1, dataGridView1);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿SEGURO QUE DESEA CAMBIAR DE MANEJADOR?", "MANEJANDORES", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                button5.Visible = false;
                button2.Visible = false;
                comboBox2.Visible = false;
                Ocultar.ocultar(this);
                Conexion.Manejadores(comboBox3, comboBox1, dataGridView1);

            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }
    }
}

