<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="notificacion.aspx.vb" Inherits="notificacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="bootstrap pspagoefectivo">
      <div class="page-head">
          <ul class="breadcrumb page-breadcrumb">
              <li class="breadcrumb-current">
                  <i class="icon-AdminParentModules"></i>
              </li>
          </ul>
          <h2 class="page-title">
              Notificación Cip
          </h2>

      </div>
  </div>
  <div class="bootstrap pspagoefectivo">
      <div class='pe_pago'>
     <div class='pe_payment'>
    <form name="formulario" method="post" action="notificacion.aspx" runat="server">
        <table>
            <tr>
                <td>Resultado:</td>
                <td></td>
            </tr>
            <tr>
                <td>Mensaje:</td>
                <td>
                    <asp:TextBox ID="txtMensaje" runat="server" Width="800px"></asp:TextBox>
                </td>
                </tr>                         
        </table>
    </form>
    </div>
    </div>
    </div>
</asp:Content>