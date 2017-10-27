Imports System.Configuration.ConfigurationManager
Imports SPE.Api

Partial Class EliminarCip
    Inherits System.Web.UI.Page

    '*
    '* Cancela el pedido de compra en Pago Efectivo
    '* Parámetros: txtCIP.Text (Código de CIP)
    '*
    Protected Sub btnEliminarCIP_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEliminarCIP.Click

        Dim request As New SPE.Api.Proxys.BEWSElimCIPRequestMod1
        request.CIP = txtCIP.Text

        Dim response As New SPE.Api.Proxys.BEWSElimCIPResponseMod1
        response = PagoEfectivo.EliminarCIP(request)

        If (response IsNot Nothing) Then
            txtEstado.Text = response.Estado
            txtMensaje.Text = response.Mensaje
        End If

    End Sub

End Class
