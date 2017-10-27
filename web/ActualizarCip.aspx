<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="ActualizarCip.aspx.vb" Inherits="ActualizarCip" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<link href="tools/css/bootstrap.css" rel="stylesheet" type="text/css" />
<link href="tools/css/bootstrap-datetimepicker.min.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="tools/js/bootstrap.min.js"></script>
<script type="text/javascript" src="tools/js/bootstrap-datetimepicker.min.js"></script>
<script type="text/javascript" src="tools/js/bootstrap-datetimepicker.pt-BR.js"></script>
<script type="text/javascript">
    $(document).ready(function () {
        $('#datetimepicker').datetimepicker({
            format: 'dd/MM/yyyy hh:mm:ss',
            language: 'pt-BR'
        });
    });
                    </script>
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
              Actualizar Cip
          </h2>

      </div>
  </div>
  <div class="bootstrap pspagoefectivo">
      <div class='pe_pago'>
     <div class='pe_payment'>
         <form id="form1" runat="server">
            Num CIP:<br /><asp:TextBox ID="txtCIP" runat="server" Width="250px"></asp:TextBox> 
            <br />Fecha de Expiración:<div id="datetimepicker" class="input-append date">
                      <asp:TextBox ID="txtFechaExpiracion" runat="server" Width="250px"></asp:TextBox>
                      <span class="add-on">
                        <i data-time-icon="icon-time" data-date-icon="icon-calendar"></i>
                      </span>
                    </div>
            <br />
            <asp:Button ID="btnActualizarCIP" runat="server" Text="Actualizar CIP" />
           <div>                
                <br /><br />
                <table>
                <tr>
                    <td>Resultado:</td>
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


