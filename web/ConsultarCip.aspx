<%@ Page Language="VB" AutoEventWireup="false" MasterPageFile="~/MasterPage.master" CodeFile="ConsultarCip.aspx.vb" Inherits="ConsultarCip" ValidateRequest="false" %>

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
              Consultar Cip
          </h2>

      </div>
  </div>
  <div class="bootstrap pspagoefectivo">
      <div class='pe_pago'>
     <div class='pe_payment'>
  <form id="form" runat="server">
        Num CIP:<br /> <asp:TextBox ID="txtCIPs" runat="server" Width="250"></asp:TextBox>
                <br /><br />
                <asp:Button ID="btnEjecutar" runat="server" Text="Consultar CIP" />
        
        <br /><br /><br />
        <table>
        <tr>
            <td>Resultado:</td>
        </tr>
        <tr>
            <td>Xml:</td>
            <td>
                <asp:TextBox ID="txtResultado" runat="server" TextMode="MultiLine" Height="276px" Width="800px"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>Estado:</td>
            <td>
                <asp:TextBox ID="txtEstado" runat="server" Width="800px"></asp:TextBox>
            </td>
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