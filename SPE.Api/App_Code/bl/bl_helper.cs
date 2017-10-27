using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using SPE.Api.App_Code.be;

namespace SPE.Api.App_Code.bl
{
    public class bl_helper
    {
        public string convertToXml(ref BEGenRequest paymentRequest)
        {
            paymentRequest.Detalles.Detalle.Cod_Origen = "CT";
            paymentRequest.Detalles.Detalle.TipoOrigen = "TO";
            paymentRequest.Detalles.Detalle.ConceptoPago = paymentRequest.ConceptoPago;
            paymentRequest.Detalles.Detalle.Importe = paymentRequest.Total;

            StringWriter stringWriter = new StringWriter();
            XmlSerializer x = new XmlSerializer(paymentRequest.GetType());
            
            x.Serialize(stringWriter, paymentRequest);
            stringWriter.Close();

            return stringWriter.ToString();
        }
    }
}
