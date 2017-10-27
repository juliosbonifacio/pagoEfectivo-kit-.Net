
Partial Class GenerarCip
    Inherits System.Web.UI.Page

    Sub Page_Load(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fancy.HRef = System.Configuration.ConfigurationManager.AppSettings("PE_SERVER").ToString() + System.Configuration.ConfigurationManager.AppSettings("PE_URL_POPUP").ToString()
    End Sub

End Class
