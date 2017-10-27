using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SPE.Api.Proxys;
using System.Net;
using System.Configuration;
using SPE.Api.App_Code.be;
using SPE.Api.App_Code.bl;
using System.Xml;

namespace SPE.Api
{
    public class PagoEfectivo
    {
        public static string PublicKey  = ConfigurationManager.AppSettings["PE_SECURITY_PATH"] + ConfigurationManager.AppSettings["PE_PUBLICKEY"];
        public static string PrivateKey = ConfigurationManager.AppSettings["PE_SECURITY_PATH"] + ConfigurationManager.AppSettings["PE_PRIVATEKEY"];
        
        public static BEpaymentResponse GenerarCIP(BEGenRequest paymentRequest)
        {
            BEWSGenCIPRequestMod1 solicitud = new BEWSGenCIPRequestMod1();
            solicitud.CodServ = ConfigurationManager.AppSettings["PE_MERCHAND_ID"];
            bl_helper hlp = new bl_helper();
            solicitud.Xml = hlp.convertToXml(ref paymentRequest).Replace("BEGenRequest","SolPago");

            BEWSGenCIPResponseMod1 response = new BEWSGenCIPResponseMod1();
            using (var proxy = new WSCrypto())
            {
                proxy.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials;
                proxy.Proxy = WebProxy.GetDefaultProxy();
                proxy.Proxy.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials;
                solicitud.Xml = solicitud.Xml.Trim();
                solicitud.Firma = proxy.Signer(solicitud.Xml, ByteUtil.FileToByteArray(PrivateKey));
                solicitud.Xml = proxy.EncryptText(solicitud.Xml, ByteUtil.FileToByteArray(PublicKey));
                using (var proxyCIP = new Service())
                {
                    response = proxyCIP.GenerarCIPMod1(solicitud);
                    if (response != null)
                        if (!String.IsNullOrEmpty(response.Xml))
                            response.Xml = proxy.DecryptText(response.Xml, ByteUtil.FileToByteArray(PrivateKey));
                }
            }
            BEpaymentResponse paymentResponse = new BEpaymentResponse();
            XmlElement element = default(XmlElement);
            if ((response != null))
            {
                XmlDocument xml = new XmlDocument();
                xml.InnerXml = response.Xml;
                element = (XmlElement)xml.SelectSingleNode("ConfirSolPago");
                XmlElement elementchild = (XmlElement)element.SelectSingleNode("CIP");
                XmlElement elementchildCIP = (XmlElement)elementchild.SelectSingleNode("NumeroOrdenPago");
                XmlElement elementchildMerchandID = (XmlElement)elementchild.SelectSingleNode("MerchantID");
                XmlElement elementchildtoken = (XmlElement)element.SelectSingleNode("Token");

                paymentResponse.NumeroCip = elementchildCIP.InnerText;
                paymentResponse.IdComercio = elementchildMerchandID.InnerText;
                paymentResponse.Token = elementchildtoken.InnerText;
                paymentResponse.Estado = response.Estado;
                paymentResponse.Mensaje = response.Mensaje;
                paymentResponse.Xml = response.Xml;
            }
            else
            {
                return null;
            }
            return paymentResponse;
        }
        public static BEWSConsultarCIPResponseMod1 ConsultarCIP(BEWSConsultarCIPRequestMod1 request)
        {
            request.CodServ = ConfigurationManager.AppSettings["PE_MERCHAND_ID"];
            BEWSConsultarCIPResponseMod1 response = new BEWSConsultarCIPResponseMod1();
            try
            {
                using (var proxy = new WSCrypto())
                {
                    proxy.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials;
                    proxy.Proxy = WebProxy.GetDefaultProxy();
                    proxy.Proxy.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials;
                    request.CIPS = request.CIPS.Trim();
                    request.Firma = proxy.Signer(request.CIPS, ByteUtil.FileToByteArray(PrivateKey));
                    request.CIPS = proxy.EncryptText(request.CIPS, ByteUtil.FileToByteArray(PublicKey));
                    using (var proxyCIP = new Service())
                    {
                        response = proxyCIP.ConsultarCIPMod1(request);
                        if (response != null)
                            if (!String.IsNullOrEmpty(response.XML))
                                response.XML = proxy.DecryptText(response.XML, ByteUtil.FileToByteArray(PrivateKey));
                    }
                }
                return response;
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.Message;
                response.Estado = "-1";
                return response;
            }
        }
        public static BEWSElimCIPResponseMod1 EliminarCIP(BEWSElimCIPRequestMod1 request)
        {
            request.CodServ = ConfigurationManager.AppSettings["PE_MERCHAND_ID"];
            BEWSElimCIPResponseMod1 response = new BEWSElimCIPResponseMod1();
            using (var proxy = new WSCrypto())
            {
                proxy.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials;
                proxy.Proxy = WebProxy.GetDefaultProxy();
                proxy.Proxy.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials;
                request.CIP = request.CIP.Trim();
                request.Firma = proxy.Signer(request.CIP, ByteUtil.FileToByteArray(PrivateKey));
                request.CIP = proxy.EncryptText(request.CIP, ByteUtil.FileToByteArray(PublicKey));
                using (var proxyCIP = new Service())
                {
                    response = proxyCIP.EliminarCIPMod1(request);
                }
            }
            return response;
        }
        public static BEWSActualizaCIPResponseMod1 ActualizarCIP(BEWSActualizaCIPRequestMod1 request)
        {
            request.CodServ = ConfigurationManager.AppSettings["PE_MERCHAND_ID"];
            BEWSActualizaCIPResponseMod1 response = new BEWSActualizaCIPResponseMod1();
            using (var proxy = new WSCrypto())
            {
                proxy.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials;
                proxy.Proxy = WebProxy.GetDefaultProxy();
                proxy.Proxy.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials;
                request.CIP = request.CIP.Trim();
                request.Firma = proxy.Signer(request.CIP, ByteUtil.FileToByteArray(PrivateKey));
                request.CIP = proxy.EncryptText(request.CIP, ByteUtil.FileToByteArray(PublicKey));
                using (var proxyCIP = new Service())
                {
                    response = proxyCIP.ActualizarCIPMod1(request);
                    //if (response != null)
                    //    if (!String.IsNullOrEmpty(response.XML))
                    //        response.XML = proxy.DecryptText(response.XML, ByteUtil.FileToByteArray(PrivatePath));
                }
            }
            return response;
        }
        public static BEnotificacionResponse DesencriptarData(String TextoEncriptado)
        {
            String response;
            try
            {
                using (var proxy = new WSCrypto())
                {
                    proxy.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials;
                    proxy.Proxy = WebProxy.GetDefaultProxy();
                    proxy.Proxy.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials;
                    proxy.Url = System.Configuration.ConfigurationManager.AppSettings["PE_SERVER"] + System.Configuration.ConfigurationManager.AppSettings["PE_WSCRYPTA"];
                    response = proxy.DecryptText(TextoEncriptado, ByteUtil.FileToByteArray(PrivateKey));

                    BEnotificacionResponse notificacionResponse = new BEnotificacionResponse();
                    XmlElement element = default(XmlElement);
                    if ((response != null))
                    {
                        XmlDocument xml = new XmlDocument();
                        xml.InnerXml = response;
                        element = (XmlElement)xml.SelectSingleNode("ConfirSolPago");
                        XmlElement elementchildCIP = (XmlElement)element.SelectSingleNode("CodTrans");
                        XmlElement elementchildEstado = (XmlElement)element.SelectSingleNode("Estado");

                        XmlElement elementchild = (XmlElement)element.SelectSingleNode("CIP");
                        XmlElement elementchildMerchandID = (XmlElement)elementchild.SelectSingleNode("MerchantID");

                        notificacionResponse.NumeroCip = elementchildCIP.InnerText;
                        notificacionResponse.IdComercio = elementchildMerchandID.InnerText;
                        notificacionResponse.Estado = elementchildEstado.InnerText;
                        notificacionResponse.Xml = response;
                    }
                    else
                    {
                        return null;
                    }
                    return notificacionResponse;

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
