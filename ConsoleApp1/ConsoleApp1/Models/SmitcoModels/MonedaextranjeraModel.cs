using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models.SmitcoModels
{
    public class MonedaextranjeraModel
    {
        public object Tipo { get; set; }
        public object Reclasificacion { get; set; }
        public object Comprobante { get; set; }
        public object Secuencia { get; set; }
        public object Fecha { get; set; }
        public object Identificacion { get; set; }
        public object Sucursal { get; set; }
        public object Descripcion { get; set; }
        public object Codigomoneda { get; set; }
        public object Descripmoneda { get; set; }
        public object ValorExtranjera { get; set; }
        public object Cambio { get; set; }
        public object Centrocosto { get; set; }
        public object SubCentroCosto { get; set; }
        public object Cuenta { get; set; }
        public object Nombre { get; set; }
        public object Debito { get; set; }
        public object Credito { get; set; }
        public object Saldo { get; set; }
    }

    public class MovimientoMonedaExtranjeraParametrosModel
    {
        public object Empresa { get; set; }
        public object Anio { get; set; }
        public object FechaInicial { get; set; }
        public object FechaFinal { get; set; }
        public object CuentaInicial { get; set; }
        public object CuentaFinal { get; set; }
        public object Comprobantes { get; set; }
        public object TipoComprobanteInicial { get; set; }
        public object ComprobanteInicial { get; set; }
        public object NumeroInicial { get; set; }
        public object TipoComprobanteFinal { get; set; }
        public object ComprobanteFinal { get; set; }
        public object NumeroFinal { get; set; }
        public object GenerarPor { get; set; }
        public object OrdenadoPor { get; set; }
        public object ImprimePrefijoDian { get; set; }
        public object IncluirCuentasNoMarcadasExtranjera { get; set; }
    }
    public class Root
    {
        public int Cuenta_ID { get; set; }
        public int UsaTerceros { get; set; }
        public int UsaCentroCosto { get; set; }
        public int TipoInventario { get; set; }
        public int TipoActivo { get; set; }
        public List<EstructuraCuentum> EstructuraCuenta { get; set; }
    }

    public class EstructuraCuentum
    {
        public string Cuenta { get; set; }
        public string Descripcion { get; set; }
        public List<Movimiento> Movimiento { get; set; }
    }

    public class Activo
    {
        public List<Inventario> Inventario { get; set; }
        public string DescripcionActivo { get; set; }
    }

    public class CentroCosto
    {
        public List<CentroSubCentroCosto> CentroSubCentroCosto { get; set; }
        public string CentroCosto_ { get; set; }
    }

    public class CentroSubCentroCosto
    {
        public List<SaldoCuentaTotal> SaldoCuentaTotal { get; set; }
        public int? SubCentro { get; set; }
    }



    public class Inventario
    {
        public List<CentroCosto> CentroCosto { get; set; }
        public string DescripcionInventario { get; set; }
    }

    public class Movimiento
    {
        public List<Activo> Activo { get; set; }
        public string DescripcionMovimiento { get; set; }
        public int? MonedaUsada { get; set; }
        public int? MonedaOrigen { get; set; }
        public int? CodigoMoneda { get; set; }
        public int? CodigoMonedaUsada { get; set; }
        public string DescripcionMoneda { get; set; }
        public string DescripcionMonedaUsada { get; set; }
        public string TipoDocumento { get; set; }
        public int? Comprobante { get; set; }
        public double? Numero { get; set; }
        public int? Secuencia { get; set; }
        public double? TasaCambioUsada { get; set; }
        public double? Identificacion { get; set; }
        public int? Sucursal { get; set; }
        public string DigitoVerificacion { get; set; }
        public string DescripcionTercero { get; set; }
        public DateTime? FechaDocumento { get; set; }
    }



    public class SaldoCuentaAnterior
    {
        public double SaldoAnterior { get; set; }
        public double? ValorDebito { get; set; }
        public double? ValorLocal { get; set; }
        public double? ValorExtranjera { get; set; }
        public double? ValorCredito { get; set; }
    }

    public class SaldoCuentaTotal
    {
        public double SaldoCuenta { get; set; }
        public List<SaldoCuentaAnterior> SaldoCuentaAnterior { get; set; }
    }




  

}
