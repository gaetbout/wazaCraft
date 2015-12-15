﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebUI.ServiceReferencePartie {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="JoueurClient", Namespace="http://schemas.datacontract.org/2004/07/Wazabi2")]
    [System.SerializableAttribute()]
    public partial class JoueurClient : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ConfirmPasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MdpField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PseudoField;
        
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
        public string ConfirmPassword {
            get {
                return this.ConfirmPasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.ConfirmPasswordField, value) != true)) {
                    this.ConfirmPasswordField = value;
                    this.RaisePropertyChanged("ConfirmPassword");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mdp {
            get {
                return this.MdpField;
            }
            set {
                if ((object.ReferenceEquals(this.MdpField, value) != true)) {
                    this.MdpField = value;
                    this.RaisePropertyChanged("Mdp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Pseudo {
            get {
                return this.PseudoField;
            }
            set {
                if ((object.ReferenceEquals(this.PseudoField, value) != true)) {
                    this.PseudoField = value;
                    this.RaisePropertyChanged("Pseudo");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferencePartie.IGestionPartie")]
    public interface IGestionPartie {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionPartie/CreerPartie", ReplyAction="http://tempuri.org/IGestionPartie/CreerPartieResponse")]
        void CreerPartie(WebUI.ServiceReferencePartie.JoueurClient joueur, string nom);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionPartie/CreerPartie", ReplyAction="http://tempuri.org/IGestionPartie/CreerPartieResponse")]
        System.Threading.Tasks.Task CreerPartieAsync(WebUI.ServiceReferencePartie.JoueurClient joueur, string nom);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionPartie/LancerPartie", ReplyAction="http://tempuri.org/IGestionPartie/LancerPartieResponse")]
        bool LancerPartie();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionPartie/LancerPartie", ReplyAction="http://tempuri.org/IGestionPartie/LancerPartieResponse")]
        System.Threading.Tasks.Task<bool> LancerPartieAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGestionPartieChannel : WebUI.ServiceReferencePartie.IGestionPartie, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GestionPartieClient : System.ServiceModel.ClientBase<WebUI.ServiceReferencePartie.IGestionPartie>, WebUI.ServiceReferencePartie.IGestionPartie {
        
        public GestionPartieClient() {
        }
        
        public GestionPartieClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GestionPartieClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GestionPartieClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GestionPartieClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void CreerPartie(WebUI.ServiceReferencePartie.JoueurClient joueur, string nom) {
            base.Channel.CreerPartie(joueur, nom);
        }
        
        public System.Threading.Tasks.Task CreerPartieAsync(WebUI.ServiceReferencePartie.JoueurClient joueur, string nom) {
            return base.Channel.CreerPartieAsync(joueur, nom);
        }
        
        public bool LancerPartie() {
            return base.Channel.LancerPartie();
        }
        
        public System.Threading.Tasks.Task<bool> LancerPartieAsync() {
            return base.Channel.LancerPartieAsync();
        }
    }
}
