﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tests.ServicePartie {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="JoueurClient", Namespace="http://schemas.datacontract.org/2004/07/Wazabi.Client")]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PartieClient", Namespace="http://schemas.datacontract.org/2004/07/Wazabi.Client")]
    [System.SerializableAttribute()]
    public partial class PartieClient : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EtatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Tests.ServicePartie.JoueurPartieClient JoueurCourantField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Tests.ServicePartie.JoueurPartieClient[] JoueursField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SensField;
        
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
        public int Etat {
            get {
                return this.EtatField;
            }
            set {
                if ((this.EtatField.Equals(value) != true)) {
                    this.EtatField = value;
                    this.RaisePropertyChanged("Etat");
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
        public Tests.ServicePartie.JoueurPartieClient JoueurCourant {
            get {
                return this.JoueurCourantField;
            }
            set {
                if ((object.ReferenceEquals(this.JoueurCourantField, value) != true)) {
                    this.JoueurCourantField = value;
                    this.RaisePropertyChanged("JoueurCourant");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Tests.ServicePartie.JoueurPartieClient[] Joueurs {
            get {
                return this.JoueursField;
            }
            set {
                if ((object.ReferenceEquals(this.JoueursField, value) != true)) {
                    this.JoueursField = value;
                    this.RaisePropertyChanged("Joueurs");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom {
            get {
                return this.NomField;
            }
            set {
                if ((object.ReferenceEquals(this.NomField, value) != true)) {
                    this.NomField = value;
                    this.RaisePropertyChanged("Nom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Sens {
            get {
                return this.SensField;
            }
            set {
                if ((this.SensField.Equals(value) != true)) {
                    this.SensField = value;
                    this.RaisePropertyChanged("Sens");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="JoueurPartieClient", Namespace="http://schemas.datacontract.org/2004/07/Wazabi.Client")]
    [System.SerializableAttribute()]
    public partial class JoueurPartieClient : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Tests.ServicePartie.CarteClient[] MesCartesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Tests.ServicePartie.DeClient[] MesDesField;
        
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
        public Tests.ServicePartie.CarteClient[] MesCartes {
            get {
                return this.MesCartesField;
            }
            set {
                if ((object.ReferenceEquals(this.MesCartesField, value) != true)) {
                    this.MesCartesField = value;
                    this.RaisePropertyChanged("MesCartes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Tests.ServicePartie.DeClient[] MesDes {
            get {
                return this.MesDesField;
            }
            set {
                if ((object.ReferenceEquals(this.MesDesField, value) != true)) {
                    this.MesDesField = value;
                    this.RaisePropertyChanged("MesDes");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CarteClient", Namespace="http://schemas.datacontract.org/2004/07/Wazabi.Client")]
    [System.SerializableAttribute()]
    public partial class CarteClient : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EffetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageField;
        
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
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Effet {
            get {
                return this.EffetField;
            }
            set {
                if ((object.ReferenceEquals(this.EffetField, value) != true)) {
                    this.EffetField = value;
                    this.RaisePropertyChanged("Effet");
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
        public string Image {
            get {
                return this.ImageField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageField, value) != true)) {
                    this.ImageField = value;
                    this.RaisePropertyChanged("Image");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DeClient", Namespace="http://schemas.datacontract.org/2004/07/Wazabi.Client")]
    [System.SerializableAttribute()]
    public partial class DeClient : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ValueField;
        
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
        public string Image {
            get {
                return this.ImageField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageField, value) != true)) {
                    this.ImageField = value;
                    this.RaisePropertyChanged("Image");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value {
            get {
                return this.ValueField;
            }
            set {
                if ((object.ReferenceEquals(this.ValueField, value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicePartie.IGestionPartie")]
    public interface IGestionPartie {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionPartie/CreerPartie", ReplyAction="http://tempuri.org/IGestionPartie/CreerPartieResponse")]
        bool CreerPartie(Tests.ServicePartie.JoueurClient joueur, string nom);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionPartie/CreerPartie", ReplyAction="http://tempuri.org/IGestionPartie/CreerPartieResponse")]
        System.Threading.Tasks.Task<bool> CreerPartieAsync(Tests.ServicePartie.JoueurClient joueur, string nom);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionPartie/LancerPartie", ReplyAction="http://tempuri.org/IGestionPartie/LancerPartieResponse")]
        bool LancerPartie();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionPartie/LancerPartie", ReplyAction="http://tempuri.org/IGestionPartie/LancerPartieResponse")]
        System.Threading.Tasks.Task<bool> LancerPartieAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionPartie/Init", ReplyAction="http://tempuri.org/IGestionPartie/InitResponse")]
        void Init();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionPartie/Init", ReplyAction="http://tempuri.org/IGestionPartie/InitResponse")]
        System.Threading.Tasks.Task InitAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionPartie/RejoindrePartie", ReplyAction="http://tempuri.org/IGestionPartie/RejoindrePartieResponse")]
        bool RejoindrePartie(Tests.ServicePartie.JoueurClient joueur);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionPartie/RejoindrePartie", ReplyAction="http://tempuri.org/IGestionPartie/RejoindrePartieResponse")]
        System.Threading.Tasks.Task<bool> RejoindrePartieAsync(Tests.ServicePartie.JoueurClient joueur);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionPartie/PartieCourante", ReplyAction="http://tempuri.org/IGestionPartie/PartieCouranteResponse")]
        Tests.ServicePartie.PartieClient PartieCourante();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionPartie/PartieCourante", ReplyAction="http://tempuri.org/IGestionPartie/PartieCouranteResponse")]
        System.Threading.Tasks.Task<Tests.ServicePartie.PartieClient> PartieCouranteAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionPartie/QuitterPartie", ReplyAction="http://tempuri.org/IGestionPartie/QuitterPartieResponse")]
        void QuitterPartie(Tests.ServicePartie.JoueurClient joueur);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionPartie/QuitterPartie", ReplyAction="http://tempuri.org/IGestionPartie/QuitterPartieResponse")]
        System.Threading.Tasks.Task QuitterPartieAsync(Tests.ServicePartie.JoueurClient joueur);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionPartie/GetParties", ReplyAction="http://tempuri.org/IGestionPartie/GetPartiesResponse")]
        Tests.ServicePartie.PartieClient[] GetParties();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionPartie/GetParties", ReplyAction="http://tempuri.org/IGestionPartie/GetPartiesResponse")]
        System.Threading.Tasks.Task<Tests.ServicePartie.PartieClient[]> GetPartiesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionPartie/GetJoueurPartie", ReplyAction="http://tempuri.org/IGestionPartie/GetJoueurPartieResponse")]
        Tests.ServicePartie.JoueurPartieClient[] GetJoueurPartie(int idPartie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionPartie/GetJoueurPartie", ReplyAction="http://tempuri.org/IGestionPartie/GetJoueurPartieResponse")]
        System.Threading.Tasks.Task<Tests.ServicePartie.JoueurPartieClient[]> GetJoueurPartieAsync(int idPartie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionPartie/ClearBD", ReplyAction="http://tempuri.org/IGestionPartie/ClearBDResponse")]
        void ClearBD();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestionPartie/ClearBD", ReplyAction="http://tempuri.org/IGestionPartie/ClearBDResponse")]
        System.Threading.Tasks.Task ClearBDAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGestionPartieChannel : Tests.ServicePartie.IGestionPartie, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GestionPartieClient : System.ServiceModel.ClientBase<Tests.ServicePartie.IGestionPartie>, Tests.ServicePartie.IGestionPartie {
        
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
        
        public bool CreerPartie(Tests.ServicePartie.JoueurClient joueur, string nom) {
            return base.Channel.CreerPartie(joueur, nom);
        }
        
        public System.Threading.Tasks.Task<bool> CreerPartieAsync(Tests.ServicePartie.JoueurClient joueur, string nom) {
            return base.Channel.CreerPartieAsync(joueur, nom);
        }
        
        public bool LancerPartie() {
            return base.Channel.LancerPartie();
        }
        
        public System.Threading.Tasks.Task<bool> LancerPartieAsync() {
            return base.Channel.LancerPartieAsync();
        }
        
        public void Init() {
            base.Channel.Init();
        }
        
        public System.Threading.Tasks.Task InitAsync() {
            return base.Channel.InitAsync();
        }
        
        public bool RejoindrePartie(Tests.ServicePartie.JoueurClient joueur) {
            return base.Channel.RejoindrePartie(joueur);
        }
        
        public System.Threading.Tasks.Task<bool> RejoindrePartieAsync(Tests.ServicePartie.JoueurClient joueur) {
            return base.Channel.RejoindrePartieAsync(joueur);
        }
        
        public Tests.ServicePartie.PartieClient PartieCourante() {
            return base.Channel.PartieCourante();
        }
        
        public System.Threading.Tasks.Task<Tests.ServicePartie.PartieClient> PartieCouranteAsync() {
            return base.Channel.PartieCouranteAsync();
        }
        
        public void QuitterPartie(Tests.ServicePartie.JoueurClient joueur) {
            base.Channel.QuitterPartie(joueur);
        }
        
        public System.Threading.Tasks.Task QuitterPartieAsync(Tests.ServicePartie.JoueurClient joueur) {
            return base.Channel.QuitterPartieAsync(joueur);
        }
        
        public Tests.ServicePartie.PartieClient[] GetParties() {
            return base.Channel.GetParties();
        }
        
        public System.Threading.Tasks.Task<Tests.ServicePartie.PartieClient[]> GetPartiesAsync() {
            return base.Channel.GetPartiesAsync();
        }
        
        public Tests.ServicePartie.JoueurPartieClient[] GetJoueurPartie(int idPartie) {
            return base.Channel.GetJoueurPartie(idPartie);
        }
        
        public System.Threading.Tasks.Task<Tests.ServicePartie.JoueurPartieClient[]> GetJoueurPartieAsync(int idPartie) {
            return base.Channel.GetJoueurPartieAsync(idPartie);
        }
        
        public void ClearBD() {
            base.Channel.ClearBD();
        }
        
        public System.Threading.Tasks.Task ClearBDAsync() {
            return base.Channel.ClearBDAsync();
        }
    }
}