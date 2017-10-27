Imports System.Xml
Imports SPE.Api
Imports SPE.Api.App_Code.be

Partial Class notificacion
    Inherits System.Web.UI.Page

    '*
    '* Recibe la respuesta de actualización de estado de CIP del pedido de compra en Pago Efectivo
    '* Parámetros: data (Trama encriptada)
    '*
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load



        If Not Page.IsPostBack Then

            Dim postvariable As String
            If Request.HttpMethod() = "POST" Then
                postvariable = Request.Params("data")
            Else
                txtMensaje.Text = "Debe indicar el parámetro data"
                Exit Sub
            End If

            Dim notificacionResponse = PagoEfectivo.DesencriptarData(postvariable)
            If notificacionResponse IsNot Nothing Then
                Select Case notificacionResponse.Estado
                    Case be_notificacion.Extornado
                        '//El banco extorno la transaccion - debe regresar a pendiente de pago
                        '//ExtornarTransaccion()	
                        txtMensaje.Text = "Extornado"
                    Case be_notificacion.Pagado
                        '//Se realizo el pago de la transacción
                        '//PagarTransaccion()       
                        txtMensaje.Text = "Pagado"
                    Case be_notificacion.Vencido
                        '//Expiró la transacción despues de generada como CIP
                        '//ExpirarTransaccion()
                        txtMensaje.Text = "Vencido"
                End Select
            Else
                Throw New Exception("Error al desencriptar la trama")
            End If

        End If
      

    End Sub

End Class