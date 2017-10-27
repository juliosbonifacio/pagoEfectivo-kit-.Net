<%@ Page Language="VB" AutoEventWireup="false" MasterPageFile="~/MasterPage.master" CodeFile="Cip.aspx.vb" Inherits="Cip" EnableViewStateMac="False"%>

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
              Generar Cip: Respuesta Pago Efectivo
          </h2>

      </div>
  </div>
  <div class="bootstrap pspagoefectivo">
    <center>
        <asp:Label ID="mensaje" runat="server" Text=""></asp:Label>
        <iframe id="iframe_cip" src="" width="900"  height="1196" frameborder=0 style="border:1px solid #000000;" runat="server">
            Su navegador no soporta iframes
        </iframe>
    </center>
   </div>
</asp:Content>