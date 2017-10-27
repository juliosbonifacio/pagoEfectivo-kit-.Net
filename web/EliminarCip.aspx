<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EliminarCip.aspx.vb" Inherits="EliminarCip" %>

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
              Eliminar Cip
          </h2>

      </div>
  </div>
  <div class="bootstrap pspagoefectivo">
    <div class='pe_pago'>
     <div class='pe_payment'>
    <form id="form1" runat="server">        
        Num CIP:<br /> <asp:TextBox ID="txtCIP" runat="server" Width="250"></asp:TextBox>
                <br /><br />
                <asp:Button ID="btnEliminarCIP" runat="server" Text="Eliminar CIP" />
        <div>
            <br /><br /><br />
            <table>
                <tr>
                    <td>Resultados:</td>
                    <td></td>
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
        </div>
    </form>
    </div>
    </div>
    </div>
</asp:Content>