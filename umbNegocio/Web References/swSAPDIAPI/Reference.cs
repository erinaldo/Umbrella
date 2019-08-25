﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace umbNegocio.swSAPDIAPI {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ServiceSoap", Namespace="ITA.Diapi.WS")]
    public partial class Service : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback metWSInsertarJournalVouchersOperationCompleted;
        
        private System.Threading.SendOrPostCallback metWSEstructuraJournalVouchersOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Service() {
            this.Url = global::umbNegocio.Properties.Settings.Default.umbNegocio_swSAPDIAPI_Service;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event metWSInsertarJournalVouchersCompletedEventHandler metWSInsertarJournalVouchersCompleted;
        
        /// <remarks/>
        public event metWSEstructuraJournalVouchersCompletedEventHandler metWSEstructuraJournalVouchersCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("ITA.Diapi.WS/metWSInsertarJournalVouchers", RequestNamespace="ITA.Diapi.WS", ResponseNamespace="ITA.Diapi.WS", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string metWSInsertarJournalVouchers(string varCadena) {
            object[] results = this.Invoke("metWSInsertarJournalVouchers", new object[] {
                        varCadena});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void metWSInsertarJournalVouchersAsync(string varCadena) {
            this.metWSInsertarJournalVouchersAsync(varCadena, null);
        }
        
        /// <remarks/>
        public void metWSInsertarJournalVouchersAsync(string varCadena, object userState) {
            if ((this.metWSInsertarJournalVouchersOperationCompleted == null)) {
                this.metWSInsertarJournalVouchersOperationCompleted = new System.Threading.SendOrPostCallback(this.OnmetWSInsertarJournalVouchersOperationCompleted);
            }
            this.InvokeAsync("metWSInsertarJournalVouchers", new object[] {
                        varCadena}, this.metWSInsertarJournalVouchersOperationCompleted, userState);
        }
        
        private void OnmetWSInsertarJournalVouchersOperationCompleted(object arg) {
            if ((this.metWSInsertarJournalVouchersCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.metWSInsertarJournalVouchersCompleted(this, new metWSInsertarJournalVouchersCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("ITA.Diapi.WS/metWSEstructuraJournalVouchers", RequestNamespace="ITA.Diapi.WS", ResponseNamespace="ITA.Diapi.WS", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public clsJournalVouchers metWSEstructuraJournalVouchers() {
            object[] results = this.Invoke("metWSEstructuraJournalVouchers", new object[0]);
            return ((clsJournalVouchers)(results[0]));
        }
        
        /// <remarks/>
        public void metWSEstructuraJournalVouchersAsync() {
            this.metWSEstructuraJournalVouchersAsync(null);
        }
        
        /// <remarks/>
        public void metWSEstructuraJournalVouchersAsync(object userState) {
            if ((this.metWSEstructuraJournalVouchersOperationCompleted == null)) {
                this.metWSEstructuraJournalVouchersOperationCompleted = new System.Threading.SendOrPostCallback(this.OnmetWSEstructuraJournalVouchersOperationCompleted);
            }
            this.InvokeAsync("metWSEstructuraJournalVouchers", new object[0], this.metWSEstructuraJournalVouchersOperationCompleted, userState);
        }
        
        private void OnmetWSEstructuraJournalVouchersOperationCompleted(object arg) {
            if ((this.metWSEstructuraJournalVouchersCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.metWSEstructuraJournalVouchersCompleted(this, new metWSEstructuraJournalVouchersCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="ITA.Diapi.WS")]
    public partial class clsJournalVouchers {
        
        private string referenceDateField;
        
        private string dueDateField;
        
        private string taxDateField;
        
        private string memoField;
        
        private string referenceField;
        
        private string reference2Field;
        
        private string reference3Field;
        
        private string codUsuarioField;
        
        private string fechaField;
        
        private string ipField;
        
        private string documentoField;
        
        private string numeroField;
        
        private clsJournalVouchersDet[] journalVouchersDetField;
        
        /// <remarks/>
        public string ReferenceDate {
            get {
                return this.referenceDateField;
            }
            set {
                this.referenceDateField = value;
            }
        }
        
        /// <remarks/>
        public string DueDate {
            get {
                return this.dueDateField;
            }
            set {
                this.dueDateField = value;
            }
        }
        
        /// <remarks/>
        public string TaxDate {
            get {
                return this.taxDateField;
            }
            set {
                this.taxDateField = value;
            }
        }
        
        /// <remarks/>
        public string Memo {
            get {
                return this.memoField;
            }
            set {
                this.memoField = value;
            }
        }
        
        /// <remarks/>
        public string Reference {
            get {
                return this.referenceField;
            }
            set {
                this.referenceField = value;
            }
        }
        
        /// <remarks/>
        public string Reference2 {
            get {
                return this.reference2Field;
            }
            set {
                this.reference2Field = value;
            }
        }
        
        /// <remarks/>
        public string Reference3 {
            get {
                return this.reference3Field;
            }
            set {
                this.reference3Field = value;
            }
        }
        
        /// <remarks/>
        public string CodUsuario {
            get {
                return this.codUsuarioField;
            }
            set {
                this.codUsuarioField = value;
            }
        }
        
        /// <remarks/>
        public string Fecha {
            get {
                return this.fechaField;
            }
            set {
                this.fechaField = value;
            }
        }
        
        /// <remarks/>
        public string Ip {
            get {
                return this.ipField;
            }
            set {
                this.ipField = value;
            }
        }
        
        /// <remarks/>
        public string Documento {
            get {
                return this.documentoField;
            }
            set {
                this.documentoField = value;
            }
        }
        
        /// <remarks/>
        public string Numero {
            get {
                return this.numeroField;
            }
            set {
                this.numeroField = value;
            }
        }
        
        /// <remarks/>
        public clsJournalVouchersDet[] JournalVouchersDet {
            get {
                return this.journalVouchersDetField;
            }
            set {
                this.journalVouchersDetField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="ITA.Diapi.WS")]
    public partial class clsJournalVouchersDet {
        
        private string accountCodeField;
        
        private string debitField;
        
        private string creditField;
        
        private string lineMemoField;
        
        private string reference1Field;
        
        private string reference2Field;
        
        private string referenceDateField;
        
        private string dueDateField;
        
        private string taxDateField;
        
        private string costingCodeField;
        
        private string costingCode2Field;
        
        private string costingCode3Field;
        
        /// <remarks/>
        public string AccountCode {
            get {
                return this.accountCodeField;
            }
            set {
                this.accountCodeField = value;
            }
        }
        
        /// <remarks/>
        public string Debit {
            get {
                return this.debitField;
            }
            set {
                this.debitField = value;
            }
        }
        
        /// <remarks/>
        public string Credit {
            get {
                return this.creditField;
            }
            set {
                this.creditField = value;
            }
        }
        
        /// <remarks/>
        public string LineMemo {
            get {
                return this.lineMemoField;
            }
            set {
                this.lineMemoField = value;
            }
        }
        
        /// <remarks/>
        public string Reference1 {
            get {
                return this.reference1Field;
            }
            set {
                this.reference1Field = value;
            }
        }
        
        /// <remarks/>
        public string Reference2 {
            get {
                return this.reference2Field;
            }
            set {
                this.reference2Field = value;
            }
        }
        
        /// <remarks/>
        public string ReferenceDate {
            get {
                return this.referenceDateField;
            }
            set {
                this.referenceDateField = value;
            }
        }
        
        /// <remarks/>
        public string DueDate {
            get {
                return this.dueDateField;
            }
            set {
                this.dueDateField = value;
            }
        }
        
        /// <remarks/>
        public string TaxDate {
            get {
                return this.taxDateField;
            }
            set {
                this.taxDateField = value;
            }
        }
        
        /// <remarks/>
        public string CostingCode {
            get {
                return this.costingCodeField;
            }
            set {
                this.costingCodeField = value;
            }
        }
        
        /// <remarks/>
        public string CostingCode2 {
            get {
                return this.costingCode2Field;
            }
            set {
                this.costingCode2Field = value;
            }
        }
        
        /// <remarks/>
        public string CostingCode3 {
            get {
                return this.costingCode3Field;
            }
            set {
                this.costingCode3Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void metWSInsertarJournalVouchersCompletedEventHandler(object sender, metWSInsertarJournalVouchersCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class metWSInsertarJournalVouchersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal metWSInsertarJournalVouchersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void metWSEstructuraJournalVouchersCompletedEventHandler(object sender, metWSEstructuraJournalVouchersCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class metWSEstructuraJournalVouchersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal metWSEstructuraJournalVouchersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public clsJournalVouchers Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((clsJournalVouchers)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591