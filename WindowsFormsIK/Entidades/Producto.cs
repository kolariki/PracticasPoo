using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsIK.Entidades
{
    public class Producto
    {
        
    public string Nombre {get; set;}    
    public string Descripcion {get; set;}
    public string PrecioCosto {get; set;}
    public double Margen {get;set; }
    public double IVA {get;set;}
    public decimal PrecioBruto{get;}
    public decimal PrecioVenta{ get; set;}
    public string Proveedor {get; set; }
    public string Categoria{get;set; }
    public string SubCategoria{get;set; }

    //PrecioBruto = PrecioCosto+ Margen;
    //PrecioVenta = PrecioBruto + IVA;
     //Convert.ToDecimal(1 + this.IVA);

    }
}
