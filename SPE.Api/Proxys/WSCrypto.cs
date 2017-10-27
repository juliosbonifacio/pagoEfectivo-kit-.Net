﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18408
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by wsdl, Version=4.0.30319.1.
// 
namespace SPE.Api.Proxys {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WSCryptoSoap", Namespace="http://tempuri.org/")]
    public partial class WSCrypto : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback EncryptTextOperationCompleted;
        
        private System.Threading.SendOrPostCallback DecryptTextOperationCompleted;
        
        private System.Threading.SendOrPostCallback SignerOperationCompleted;
        
        /// <remarks/>
        public WSCrypto() {
            this.Url = System.Configuration.ConfigurationManager.AppSettings["PE_SERVER"] + System.Configuration.ConfigurationManager.AppSettings["PE_WSCRYPTA"];
        }
        
        /// <remarks/>
        public event EncryptTextCompletedEventHandler EncryptTextCompleted;
        
        /// <remarks/>
        public event DecryptTextCompletedEventHandler DecryptTextCompleted;
        
        /// <remarks/>
        public event SignerCompletedEventHandler SignerCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/EncryptText", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string EncryptText(string plainText, [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")] byte[] publicKey) {
            object[] results = this.Invoke("EncryptText", new object[] {
                        plainText,
                        publicKey});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginEncryptText(string plainText, byte[] publicKey, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("EncryptText", new object[] {
                        plainText,
                        publicKey}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndEncryptText(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void EncryptTextAsync(string plainText, byte[] publicKey) {
            this.EncryptTextAsync(plainText, publicKey, null);
        }
        
        /// <remarks/>
        public void EncryptTextAsync(string plainText, byte[] publicKey, object userState) {
            if ((this.EncryptTextOperationCompleted == null)) {
                this.EncryptTextOperationCompleted = new System.Threading.SendOrPostCallback(this.OnEncryptTextOperationCompleted);
            }
            this.InvokeAsync("EncryptText", new object[] {
                        plainText,
                        publicKey}, this.EncryptTextOperationCompleted, userState);
        }
        
        private void OnEncryptTextOperationCompleted(object arg) {
            if ((this.EncryptTextCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.EncryptTextCompleted(this, new EncryptTextCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DecryptText", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DecryptText(string encryptText, [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")] byte[] privateKey) {
            object[] results = this.Invoke("DecryptText", new object[] {
                        encryptText,
                        privateKey});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginDecryptText(string encryptText, byte[] privateKey, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("DecryptText", new object[] {
                        encryptText,
                        privateKey}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndDecryptText(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void DecryptTextAsync(string encryptText, byte[] privateKey) {
            this.DecryptTextAsync(encryptText, privateKey, null);
        }
        
        /// <remarks/>
        public void DecryptTextAsync(string encryptText, byte[] privateKey, object userState) {
            if ((this.DecryptTextOperationCompleted == null)) {
                this.DecryptTextOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDecryptTextOperationCompleted);
            }
            this.InvokeAsync("DecryptText", new object[] {
                        encryptText,
                        privateKey}, this.DecryptTextOperationCompleted, userState);
        }
        
        private void OnDecryptTextOperationCompleted(object arg) {
            if ((this.DecryptTextCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DecryptTextCompleted(this, new DecryptTextCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Signer", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string Signer(string plainText, [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")] byte[] privateKey) {
            object[] results = this.Invoke("Signer", new object[] {
                        plainText,
                        privateKey});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginSigner(string plainText, byte[] privateKey, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Signer", new object[] {
                        plainText,
                        privateKey}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndSigner(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SignerAsync(string plainText, byte[] privateKey) {
            this.SignerAsync(plainText, privateKey, null);
        }
        
        /// <remarks/>
        public void SignerAsync(string plainText, byte[] privateKey, object userState) {
            if ((this.SignerOperationCompleted == null)) {
                this.SignerOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSignerOperationCompleted);
            }
            this.InvokeAsync("Signer", new object[] {
                        plainText,
                        privateKey}, this.SignerOperationCompleted, userState);
        }
        
        private void OnSignerOperationCompleted(object arg) {
            if ((this.SignerCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SignerCompleted(this, new SignerCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void EncryptTextCompletedEventHandler(object sender, EncryptTextCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class EncryptTextCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal EncryptTextCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void DecryptTextCompletedEventHandler(object sender, DecryptTextCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DecryptTextCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DecryptTextCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void SignerCompletedEventHandler(object sender, SignerCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SignerCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SignerCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}
