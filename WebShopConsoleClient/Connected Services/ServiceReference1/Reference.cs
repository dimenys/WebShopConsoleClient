﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebShopConsoleClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Felhasznalo", Namespace="http://schemas.datacontract.org/2004/07/Server.Models")]
    [System.SerializableAttribute()]
    public partial class Felhasznalo : WebShopConsoleClient.ServiceReference1.Record {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AktivField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HASHField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte JogField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LoginNevField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NevField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProfilKepField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SALTField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Aktiv {
            get {
                return this.AktivField;
            }
            set {
                if ((this.AktivField.Equals(value) != true)) {
                    this.AktivField = value;
                    this.RaisePropertyChanged("Aktiv");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HASH {
            get {
                return this.HASHField;
            }
            set {
                if ((object.ReferenceEquals(this.HASHField, value) != true)) {
                    this.HASHField = value;
                    this.RaisePropertyChanged("HASH");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte Jog {
            get {
                return this.JogField;
            }
            set {
                if ((this.JogField.Equals(value) != true)) {
                    this.JogField = value;
                    this.RaisePropertyChanged("Jog");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LoginNev {
            get {
                return this.LoginNevField;
            }
            set {
                if ((object.ReferenceEquals(this.LoginNevField, value) != true)) {
                    this.LoginNevField = value;
                    this.RaisePropertyChanged("LoginNev");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nev {
            get {
                return this.NevField;
            }
            set {
                if ((object.ReferenceEquals(this.NevField, value) != true)) {
                    this.NevField = value;
                    this.RaisePropertyChanged("Nev");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProfilKep {
            get {
                return this.ProfilKepField;
            }
            set {
                if ((object.ReferenceEquals(this.ProfilKepField, value) != true)) {
                    this.ProfilKepField = value;
                    this.RaisePropertyChanged("ProfilKep");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SALT {
            get {
                return this.SALTField;
            }
            set {
                if ((object.ReferenceEquals(this.SALTField, value) != true)) {
                    this.SALTField = value;
                    this.RaisePropertyChanged("SALT");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Record", Namespace="http://schemas.datacontract.org/2004/07/Server.Models")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WebShopConsoleClient.ServiceReference1.Felhasznalo))]
    public partial class Record : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> IdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFelhasznalokService/FelhasznaloLista_CS", ReplyAction="http://tempuri.org/IFelhasznalokService/FelhasznaloLista_CSResponse")]
        WebShopConsoleClient.ServiceReference1.Felhasznalo[] FelhasznaloLista_CS();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFelhasznalokService/FelhasznaloLista_CS", ReplyAction="http://tempuri.org/IFelhasznalokService/FelhasznaloLista_CSResponse")]
        System.Threading.Tasks.Task<WebShopConsoleClient.ServiceReference1.Felhasznalo[]> FelhasznaloLista_CSAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFelhasznalokService/FelhasznaloLista_Web", ReplyAction="http://tempuri.org/IFelhasznalokService/FelhasznaloLista_WebResponse")]
        WebShopConsoleClient.ServiceReference1.Felhasznalo[] FelhasznaloLista_Web();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFelhasznalokService/FelhasznaloLista_Web", ReplyAction="http://tempuri.org/IFelhasznalokService/FelhasznaloLista_WebResponse")]
        System.Threading.Tasks.Task<WebShopConsoleClient.ServiceReference1.Felhasznalo[]> FelhasznaloLista_WebAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFelhasznalokService/FelhasznaloHozzaAd_CS", ReplyAction="http://tempuri.org/IFelhasznalokService/FelhasznaloHozzaAd_CSResponse")]
        string FelhasznaloHozzaAd_CS(WebShopConsoleClient.ServiceReference1.Felhasznalo felhasznalo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFelhasznalokService/FelhasznaloHozzaAd_CS", ReplyAction="http://tempuri.org/IFelhasznalokService/FelhasznaloHozzaAd_CSResponse")]
        System.Threading.Tasks.Task<string> FelhasznaloHozzaAd_CSAsync(WebShopConsoleClient.ServiceReference1.Felhasznalo felhasznalo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFelhasznalokService/FelhasznaloHozzaAd_Web", ReplyAction="http://tempuri.org/IFelhasznalokService/FelhasznaloHozzaAd_WebResponse")]
        string FelhasznaloHozzaAd_Web(WebShopConsoleClient.ServiceReference1.Felhasznalo felhasznalo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFelhasznalokService/FelhasznaloHozzaAd_Web", ReplyAction="http://tempuri.org/IFelhasznalokService/FelhasznaloHozzaAd_WebResponse")]
        System.Threading.Tasks.Task<string> FelhasznaloHozzaAd_WebAsync(WebShopConsoleClient.ServiceReference1.Felhasznalo felhasznalo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFelhasznalokService/FelhasznaloModosit_CS", ReplyAction="http://tempuri.org/IFelhasznalokService/FelhasznaloModosit_CSResponse")]
        string FelhasznaloModosit_CS(WebShopConsoleClient.ServiceReference1.Felhasznalo felhasznalo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFelhasznalokService/FelhasznaloModosit_CS", ReplyAction="http://tempuri.org/IFelhasznalokService/FelhasznaloModosit_CSResponse")]
        System.Threading.Tasks.Task<string> FelhasznaloModosit_CSAsync(WebShopConsoleClient.ServiceReference1.Felhasznalo felhasznalo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFelhasznalokService/FelhasznaloModosit_Web", ReplyAction="http://tempuri.org/IFelhasznalokService/FelhasznaloModosit_WebResponse")]
        string FelhasznaloModosit_Web(WebShopConsoleClient.ServiceReference1.Felhasznalo felhasznalo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFelhasznalokService/FelhasznaloModosit_Web", ReplyAction="http://tempuri.org/IFelhasznalokService/FelhasznaloModosit_WebResponse")]
        System.Threading.Tasks.Task<string> FelhasznaloModosit_WebAsync(WebShopConsoleClient.ServiceReference1.Felhasznalo felhasznalo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFelhasznalokService/FelhasznaloTorol_CS", ReplyAction="http://tempuri.org/IFelhasznalokService/FelhasznaloTorol_CSResponse")]
        string FelhasznaloTorol_CS(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFelhasznalokService/FelhasznaloTorol_CS", ReplyAction="http://tempuri.org/IFelhasznalokService/FelhasznaloTorol_CSResponse")]
        System.Threading.Tasks.Task<string> FelhasznaloTorol_CSAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFelhasznalokService/FelhasznaloTorol_Web", ReplyAction="http://tempuri.org/IFelhasznalokService/FelhasznaloTorol_WebResponse")]
        string FelhasznaloTorol_Web(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFelhasznalokService/FelhasznaloTorol_Web", ReplyAction="http://tempuri.org/IFelhasznalokService/FelhasznaloTorol_WebResponse")]
        System.Threading.Tasks.Task<string> FelhasznaloTorol_WebAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebShopConsoleClient.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebShopConsoleClient.ServiceReference1.IService1>, WebShopConsoleClient.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebShopConsoleClient.ServiceReference1.Felhasznalo[] FelhasznaloLista_CS() {
            return base.Channel.FelhasznaloLista_CS();
        }
        
        public System.Threading.Tasks.Task<WebShopConsoleClient.ServiceReference1.Felhasznalo[]> FelhasznaloLista_CSAsync() {
            return base.Channel.FelhasznaloLista_CSAsync();
        }
        
        public WebShopConsoleClient.ServiceReference1.Felhasznalo[] FelhasznaloLista_Web() {
            return base.Channel.FelhasznaloLista_Web();
        }
        
        public System.Threading.Tasks.Task<WebShopConsoleClient.ServiceReference1.Felhasznalo[]> FelhasznaloLista_WebAsync() {
            return base.Channel.FelhasznaloLista_WebAsync();
        }
        
        public string FelhasznaloHozzaAd_CS(WebShopConsoleClient.ServiceReference1.Felhasznalo felhasznalo) {
            return base.Channel.FelhasznaloHozzaAd_CS(felhasznalo);
        }
        
        public System.Threading.Tasks.Task<string> FelhasznaloHozzaAd_CSAsync(WebShopConsoleClient.ServiceReference1.Felhasznalo felhasznalo) {
            return base.Channel.FelhasznaloHozzaAd_CSAsync(felhasznalo);
        }
        
        public string FelhasznaloHozzaAd_Web(WebShopConsoleClient.ServiceReference1.Felhasznalo felhasznalo) {
            return base.Channel.FelhasznaloHozzaAd_Web(felhasznalo);
        }
        
        public System.Threading.Tasks.Task<string> FelhasznaloHozzaAd_WebAsync(WebShopConsoleClient.ServiceReference1.Felhasznalo felhasznalo) {
            return base.Channel.FelhasznaloHozzaAd_WebAsync(felhasznalo);
        }
        
        public string FelhasznaloModosit_CS(WebShopConsoleClient.ServiceReference1.Felhasznalo felhasznalo) {
            return base.Channel.FelhasznaloModosit_CS(felhasznalo);
        }
        
        public System.Threading.Tasks.Task<string> FelhasznaloModosit_CSAsync(WebShopConsoleClient.ServiceReference1.Felhasznalo felhasznalo) {
            return base.Channel.FelhasznaloModosit_CSAsync(felhasznalo);
        }
        
        public string FelhasznaloModosit_Web(WebShopConsoleClient.ServiceReference1.Felhasznalo felhasznalo) {
            return base.Channel.FelhasznaloModosit_Web(felhasznalo);
        }
        
        public System.Threading.Tasks.Task<string> FelhasznaloModosit_WebAsync(WebShopConsoleClient.ServiceReference1.Felhasznalo felhasznalo) {
            return base.Channel.FelhasznaloModosit_WebAsync(felhasznalo);
        }
        
        public string FelhasznaloTorol_CS(int id) {
            return base.Channel.FelhasznaloTorol_CS(id);
        }
        
        public System.Threading.Tasks.Task<string> FelhasznaloTorol_CSAsync(int id) {
            return base.Channel.FelhasznaloTorol_CSAsync(id);
        }
        
        public string FelhasznaloTorol_Web(int id) {
            return base.Channel.FelhasznaloTorol_Web(id);
        }
        
        public System.Threading.Tasks.Task<string> FelhasznaloTorol_WebAsync(int id) {
            return base.Channel.FelhasznaloTorol_WebAsync(id);
        }
    }
}
