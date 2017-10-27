<%@ Page Language="VB" AutoEventWireup="false" MasterPageFile="~/MasterPage.master" CodeFile="GenerarCip.aspx.vb" Inherits="GenerarCip" EnableViewStateMac="False"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <link href="lib_pagoefectivo/js/fancybox/jquery.fancybox.css" rel="stylesheet" type="text/css" />
    <script src="lib_pagoefectivo/js/fancybox/jquery.fancybox.js" type="text/javascript"></script>
    <script src="lib_pagoefectivo/js/swfobject/swfobject.js" type="text/javascript"></script>
    <script src="lib_pagoefectivo/js/JScript.js" type="text/javascript"></script>
      <div class="bootstrap pspagoefectivo">
      <div class="page-head">
          <ul class="breadcrumb page-breadcrumb">
              <li class="breadcrumb-current">
                  <i class="icon-AdminParentModules"></i>
              </li>
          </ul>
          <h2 class="page-title">
              Generar Cip
          </h2>

      </div>
  </div>
  <div class="bootstrap pspagoefectivo">
<br /><br /><br />
<div class="pe_pago">
    <form id="frmPago" runat="server" action="Cip.aspx"  method="post">
        <div class="pe_detail">
            <h3>
                Detalle de compra
                <a class="pe_inline_mdl cboxElement" href="#mira-tus-avisos"></a>
            </h3>
            <div class="pe_content">
                <ul>
                    <li>Detalle del producto</li>
                    <li>comentarios adicionales</li>
                </ul>
                 <p class="pe_total">Total: <span>S/. <span id="pe_s-total">22.00</span></span></p>
                <input type="hidden" name="t-total" id="pe_t-total" value="22" />
                <p class="pe_obs">El precio incluye IGV. La compra, en la fecha indicada, est&aacute; sujeta al pago antes de la fecha de cierre.</p>
            </div>
        </div>
        <div class="pe_payment">
            <h3>M&eacute;todo de pago</h3>
            <div class="pe_option_pago">
                    <div class="pe_title">
                        <span class="pe_inline"><strong>Pagar sin Tarjeta de Cr&eacute;dito</strong></span>
                        <a class="pe_pregunta fancybox" title="¿C&oacute;mo funciona PagoEfectivo?" href="#pagoef1"></a> <br/><br/>
                    </div>
                    <input type="radio" style="float:left;"  value="2" name="metodopago" checked="checked" id="form-validation-field-1" />
                    <div style="float: left; width: 100px;"><img src="lib_pagoefectivo/images/logo_pagoefectivo_112x52.jpg"  width="90" height="38" alt="Pago Efectivo"/></div>
                    <div style="float:left;text-align: justify;width: 400px;">
                        Banca por Internet, Agentes y Agencias INTERBANK, BANBIF, BCP, BBVA y SCOTIABANK. WESTERN UNION (Pago de Servicios), KASNET y FULLCARGA. <br />
                            <span style="font-size:10px;">
                			    <a class="iframe" id="fancy" title="¿C&oacute;mo funciona PagoEfectivo?"  style="color:#006999; text-decoration:none;" href="" runat="server">¿C&oacute;mo funciona PagoEfectivo?</a>
                            </span>
                        </div>
                    <div class="clear"></div> <br />
                    <div class="pe_total">
                        <input type="submit" id="Send" value="Pagar" class="pe_continuar_btn1" name="Send" />
                     </div>
            </div>
       </div>
    </form>
    </div>
</div>
</asp:Content>

