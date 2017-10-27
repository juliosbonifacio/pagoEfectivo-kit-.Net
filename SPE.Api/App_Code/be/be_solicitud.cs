using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPE.Api.App_Code.be
{
    public class BEGenRequest
    {
        private string moneda = "";
        public string IdMoneda
        {
            get { return moneda; }
            set { moneda = value; }
        }

        private string monto = "";
        public string Total
        {
            get { return monto; }
            set { monto = value; }
        }

        private string medio_pago = "";
        public string MetodosPago
        {
            get { return medio_pago; }
            set { medio_pago = value; }
        }

        private string concepto_pago = "";
        public string ConceptoPago
        {
            get { return concepto_pago; }
            set { concepto_pago = value; }
        }

        private string cod_servicio = "";
        public string CodServicio
        {
            get { return cod_servicio; }
            set { cod_servicio = value; }
        }

        private string numero_orden = "";
        public string Codtransaccion
        {
            get { return numero_orden; }
            set { numero_orden = value; }
        }

        private string email_comercio = "";
        public string EmailComercio
        {
            get { return email_comercio; }
            set { email_comercio = value; }
        }

        private string fecha_expirar = "";
        public string FechaAExpirar
        {
            get { return fecha_expirar; }
            set { fecha_expirar = value; }
        }

        private string data_adicional = "";
        public string DataAdicional
        {
            get { return data_adicional; }
            set { data_adicional = value; }
        }

        private string usuario_id = "";
        public string UsuarioId
        {
            get { return usuario_id; }
            set { usuario_id = value; }
        }

        private string usuario_nombre = "";
        public string UsuarioNombre
        {
            get { return usuario_nombre; }
            set { usuario_nombre = value; }
        }

        private string usuario_apellidos = "";
        public string UsuarioApellidos
        {
            get { return usuario_apellidos; }
            set { usuario_apellidos = value; }
        }

        private string usuario_localidad = "";
        public string UsuarioLocalidad
        {
            get { return usuario_localidad; }
            set { usuario_localidad = value; }
        }

        private string usuario_provincia = "";
        public string UsuarioProvincia
        {
            get { return usuario_provincia; }
            set { usuario_provincia = value; }
        }

        private string usuario_pais = "";
        public string UsuarioPais
        {
            get { return usuario_pais; }
            set { usuario_pais = value; }
        }

        private string usuario_alias = "";
        public string UsuarioAlias
        {
            get { return usuario_alias; }
            set { usuario_alias = value; }
        }

        private string usuario_tipodocumento = "";
        public string UsuarioTipoDoc
        {
            get { return usuario_tipodocumento; }
            set { usuario_tipodocumento = value; }
        }

        private string usuario_numerodocumento = "";
        public string UsuarioNumeroDoc
        {
            get { return usuario_numerodocumento; }
            set { usuario_numerodocumento = value; }
        }

        private string usuario_email = "";
        public string UsuarioEmail
        {
            get { return usuario_email; }
            set { usuario_email = value; }
        }

        private Detalles _detalles = new Detalles();
        public Detalles Detalles
        {
            get { return _detalles; }
            set { _detalles = value; }
        }


    }

    public class Detalles
    {

        private Detalle _detalle = new Detalle();
        public Detalle Detalle
        {
            get { return _detalle; }
            set { _detalle = value; }
        }
    }

    public class Detalle
    {

        private string _cod_origen;
        public string Cod_Origen
        {
            get { return _cod_origen; }
            set { _cod_origen = value; }
        }

        private string _tipo_origen;
        public string TipoOrigen
        {
            get { return _tipo_origen; }
            set { _tipo_origen = value; }
        }

        private string _concepto_pago;
        public string ConceptoPago
        {
            get { return _concepto_pago; }
            set { _concepto_pago = value; }
        }

        private string _importe;
        public string Importe
        {
            get { return _importe; }
            set { _importe = value; }
        }
    }
}
