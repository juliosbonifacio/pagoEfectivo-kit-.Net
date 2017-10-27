Imports SPE.Api

Partial Class ConsultarCip
    Inherits System.Web.UI.Page

    '*
    '* Obtiene los datos del pedido de compra en Pago Efectivo
    '* Parámetros: txtCIPs.Text (Códigos de CIP, separados por ",")
    '*
    Protected Sub btnEjecutar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEjecutar.Click

        Dim request As New SPE.Api.Proxys.BEWSConsultarCIPRequestMod1
        Dim response As New SPE.Api.Proxys.BEWSConsultarCIPResponseMod1

        request.CIPS = txtCIPs.Text.Trim.Split(",")(0).ToString()

        response = PagoEfectivo.ConsultarCIP(request)

        If response IsNot Nothing Then
            If response.Estado <> "-1" Then
                txtResultado.Text = response.XML
            Else
                txtResultado.Text = ""
            End If
        Else
            txtEstado.Text = "-1"
            txtMensaje.Text = "Error en la solicitud"
        End If
        txtEstado.Text = response.Estado
        txtMensaje.Text = response.Mensaje
    End Sub

End Class
