<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="NotificacionCip.aspx.vb" Inherits="NotificacionCip" %>

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
              Notificación Cip: Simulación Datos
          </h2>

      </div>
  </div>
  <div class="bootstrap pspagoefectivo">
      <div class='pe_pago'>
     <div class='pe_payment'>
    <form name="formulario" method="post" action="tools/notificacion.aspx">
        Parámetros:
        <br /><br />

        Data:
        <input type="text" id="data" name="data" value="" />
        <br /><br />
        <input type="submit" value="Enviar parámetro" />
        <br /><br />
    </form>
    </div>
    </div>
    </div>
</asp:Content>