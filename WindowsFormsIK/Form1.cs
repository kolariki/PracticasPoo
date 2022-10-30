using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsIK.Entidades3;

namespace WindowsFormsIK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerObjetos_Click(object sender, EventArgs e)
        {


            //AUTOR


            Autor autor1 = new Autor();
            Autor autor2 = new Autor();

            autor1.Nombre = "Julian";
            autor1.Apellido = "Perez";
            autor1.FechaNacimiento = new DateTime(07 / 11 / 1995);
            autor1.Domicilio = "Buenos Aires 500";
            autor1.Ciudad = "Mendoza";
            autor1.País = "Argentina";


            autor2.Nombre = "Veronica";
            autor2.Apellido = "Segunda";
            autor2.FechaNacimiento = new DateTime(10 / 01 / 1990);
            autor2.Domicilio = "Azcuenaga 588";
            autor2.Ciudad = "Buenos Aires";
            autor2.País = "Argentina";



            //EMPLEADO

            Empleado empleado1 = new Empleado();
            Empleado empleado2 = new Empleado();

            empleado1.Nombre = "Julian";
            empleado1.Apellido = "Perez";
            empleado1.Titulo = "Abogado";
            empleado1.FechaIngreso = new DateTime(07 / 11 / 2001);
            
            
            empleado2.Nombre = "Veronica";
            empleado2.Apellido = "Segunda";
            empleado2.Titulo = "Arquitecto";
            empleado2.FechaIngreso = new DateTime(07 / 11 / 2007);



            //VENTA
    
            Venta venta1 = new Venta();
            Venta venta2 = new Venta();

            venta1.Tienda = "Primera";
            venta1.NumeroOrden = 001;
            venta1.Cantidad = 171;
            venta1.Fecha = new DateTime(07 / 11 / 2022);
            venta1.Titulo = "Cinicos";

            venta2.Tienda = "Segunda";
            venta2.NumeroOrden = 002;
            venta2.Cantidad = 500;
            venta2.Fecha = new DateTime(15 / 11 / 2022);
            venta2.Titulo = "Erase una vez";



            //PUBLICADOR

            Publicador publicador1 = new Publicador();
            Publicador publicador2 = new Publicador();

            publicador1.Nombre = "Beto";
            publicador1.Ciudad = "Valparaiso";
            publicador1.Domicilio = "Chile 100";
            publicador1.Contacto = "+5166589721";
            publicador1.Pais = "Chile";

            publicador2.Nombre = "Pipo";
            publicador2.Ciudad = "Mar del Plata";
            publicador2.Domicilio = "Cerca del mar";
            publicador2.Contacto = "+54388972521";
            publicador2.Pais = "Argentina";




            //TITULO

            Titulo tiulo1 = new Titulo();
            Titulo titulo2 = new Titulo();

            tiulo1.NombreAutor = "Nancy";
            tiulo1.TituloObra = "Escritores Contemporaneos";
            tiulo1.Categoria = "Suspenso";
            tiulo1.Precio = 5000;
            tiulo1.Notas = 8;

            titulo2.NombreAutor = "Pedro";
            titulo2.TituloObra = "Mar del Plata";
            titulo2.Categoria = "Historia";
            titulo2.Precio = 3000;
            titulo2.Notas = 9;

        }
    }
}
