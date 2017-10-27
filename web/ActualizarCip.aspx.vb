
Imports System.Configuration.ConfigurationManager
Imports SPE.Api

Partial Class ActualizarCip
    Inherits System.Web.UI.Page

    '*
    '* Actualiza la fecha de expiración del pedido de compra en Pago Efectivo
    '* Parámetros: txtCIP.Text (Código de CIP)
    '* Parámetros: txtFechaExpiracion.Text (Fecha de expiración "dd/MM/yyyy HH:mm:ss")
    '*
    Protected Sub btnActualizarCIP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarCIP.Click

        Dim request As New SPE.Api.Proxys.BEWSActualizaCIPRequestMod1
        request.CIP = txtCIP.Text
        request.FechaExpira = txtFechaExpiracion.Text

        Try
            Dim rsp As New SPE.Api.Proxys.BEWSActualizaCIPResponseMod1
            rsp = PagoEfectivo.ActualizarCIP(request)
            If (Response IsNot Nothing) Then
                txtEstado.Text = rsp.Estado
                txtMensaje.Text = rsp.Mensaje
            End If
        Catch ex As Exception
            txtMensaje.Text = ex.Message
        End Try

    End Sub

End Class
