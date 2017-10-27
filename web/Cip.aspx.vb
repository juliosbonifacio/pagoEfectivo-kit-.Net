Imports SPE.Api
Imports System.IO
Imports System.Xml
Imports SPE.Api.Proxys
Imports System.Globalization
Imports SPE.Api.App_Code.be

Partial Class Cip
    Inherits System.Web.UI.Page

    '*
    '* Genera el código CIP del pedido de compra en Pago Efectivo
    '* Parámetros: Tipo de Moneda (1 soles - 2 dolares)
    '* Parámetros: Monto total de la compra
    '* Parámetros: Número de Orden
    '* Parámetros: Fecha de expiración
    '* Parámetros: Nombre Cliente
    '* Parámetros: Apellidos Cliente
    '* Parámetros: Email Cliente
    '*
    Sub Page_Load(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '*****************************************DATOS DE PRUEBA*******************************************************************'
            Dim paymentRequest As New BEGenRequest
            paymentRequest.IdMoneda = ConfigurationManager.AppSettings("PE_MONEDA")
            paymentRequest.Total = Convert.ToDecimal(Request.Form("t-total")).ToString("F2", CultureInfo.InvariantCulture)
            paymentRequest.MetodosPago = ConfigurationManager.AppSettings("PE_MEDIO_PAGO")
            paymentRequest.CodServicio = ConfigurationManager.AppSettings("PE_MERCHAND_ID")
            paymentRequest.Codtransaccion = GenerarRandom()
            paymentRequest.ConceptoPago = ConfigurationManager.AppSettings("PE_COMERCIO_CONCEPTO_PAGO") + ": Orden " + paymentRequest.Codtransaccion 'Debe ser menos de 20 dígitos.
            paymentRequest.EmailComercio = ConfigurationManager.AppSettings("PE_EMAIL_PORTAL")
            paymentRequest.FechaAExpirar = DateAdd(DateInterval.Hour, Convert.ToInt32(ConfigurationManager.AppSettings("PE_TIEMPO_EXPIRACION")), Date.Now)
            paymentRequest.UsuarioNombre = "prueba"
            paymentRequest.UsuarioApellidos = "demo pagoefectivo"
            paymentRequest.UsuarioEmail = "pepruebas@gmail.com"
            '*****************************************DATOS DE PRUEBA*******************************************************************'

            '*****************************************GENERAR CIP DE PAGOEFECTIVO******************************************************'
            Dim paymentResponse As New be_paymentResponse
            paymentResponse = PagoEfectivo.GenerarCIP(paymentRequest)
            '*****************************************ENVIAR VENTA A PAGOEFECTIVO******************************************************'

            '*****************************************MOSTRAR EL CIP DE PAGOEFECTIVO SEGÚN MODALIDAD DE INTEGRACIÓN***********************'
            If paymentResponse.Estado = "1" And paymentResponse.Token IsNot Nothing Then
                If ConfigurationManager.AppSettings("PE_MOD_INTEGRACION") = "1" Then
                    iframe_cip.Attributes("src") = ConfigurationManager.AppSettings("PE_SERVER") + ConfigurationManager.AppSettings("PE_WSGENPAGOIFRAME") + "?Token=" + paymentResponse.Token
                Else
                    Response.Redirect(ConfigurationManager.AppSettings("PE_SERVER") + ConfigurationManager.AppSettings("PE_WSGENPAGO") + "?Token=" + paymentResponse.Token)
                End If
            ElseIf paymentResponse.Estado = "1" Then
                mensaje.Text = paymentResponse.Mensaje
            Else
                mensaje.Text = "Hubo problemas al realizar la transacción"
            End If

        Catch ex As Exception
            mensaje.Text = ex.ToString()
            iframe_cip.Visible = False
        End Try

    End Sub

    Private Function GenerarRandom() As String
        Dim value As Integer
        Dim randNumber As New Random(DateTime.Now.Millisecond)
        value = randNumber.Next(0, 99999999)
        Return value.ToString("D8")
    End Function
End Class
