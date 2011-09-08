﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EloquaTestClient.EloquaProgramService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Step", Namespace="https://secure.eloqua.com/API/1.2")]
    [System.SerializableAttribute()]
    public partial class Step : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="UnexpectedErrorFault", Namespace="https://secure.eloqua.com/API/1.2")]
    [System.SerializableAttribute()]
    public partial class UnexpectedErrorFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExternalActionStatus", Namespace="https://secure.eloqua.com/API/1.2")]
    public enum ExternalActionStatus : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        AwaitingAction = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        InProgress = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Complete = 3,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Member", Namespace="https://secure.eloqua.com/API/1.2")]
    [System.SerializableAttribute()]
    public partial class Member : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EntityIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private EloquaTestClient.EloquaProgramService.EntityType EntityTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private EloquaTestClient.EloquaProgramService.ExternalActionStatus StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StepIdField;
        
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
        public int EntityId {
            get {
                return this.EntityIdField;
            }
            set {
                if ((this.EntityIdField.Equals(value) != true)) {
                    this.EntityIdField = value;
                    this.RaisePropertyChanged("EntityId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public EloquaTestClient.EloquaProgramService.EntityType EntityType {
            get {
                return this.EntityTypeField;
            }
            set {
                if ((this.EntityTypeField.Equals(value) != true)) {
                    this.EntityTypeField = value;
                    this.RaisePropertyChanged("EntityType");
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
        public EloquaTestClient.EloquaProgramService.ExternalActionStatus Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StepId {
            get {
                return this.StepIdField;
            }
            set {
                if ((this.StepIdField.Equals(value) != true)) {
                    this.StepIdField = value;
                    this.RaisePropertyChanged("StepId");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityType", Namespace="https://secure.eloqua.com/API/1.2")]
    public enum EntityType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Contacts = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Companies = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Prospects = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DataCards = 4,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MailAddressStatus", Namespace="https://secure.eloqua.com/API/1.2")]
    public enum MailAddressStatus : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unverified = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Valid = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Invalid = 90,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ReturnToSender = 91,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InvalidArgumentFault", Namespace="https://secure.eloqua.com/API/1.2")]
    [System.SerializableAttribute()]
    public partial class InvalidArgumentFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="https://secure.eloqua.com/API/1.2", ConfigurationName="EloquaProgramService.ExternalActionService")]
    public interface ExternalActionService {
        
        [System.ServiceModel.OperationContractAttribute(Action="https://secure.eloqua.com/API/1.2/ExternalActionService/ListExternalActionStepsBy" +
            "Type", ReplyAction="https://secure.eloqua.com/API/1.2/ExternalActionService/ListExternalActionStepsBy" +
            "TypeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EloquaTestClient.EloquaProgramService.UnexpectedErrorFault), Action="https://secure.eloqua.com/API/1.2/ExternalActionService/ListExternalActionStepsBy" +
            "TypeUnexpectedErrorFaultFault", Name="UnexpectedErrorFault")]
        EloquaTestClient.EloquaProgramService.Step[] ListExternalActionStepsByType(string externalProvider);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://secure.eloqua.com/API/1.2/ExternalActionService/GetMemberCountInStepBySta" +
            "tus", ReplyAction="https://secure.eloqua.com/API/1.2/ExternalActionService/GetMemberCountInStepBySta" +
            "tusResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EloquaTestClient.EloquaProgramService.UnexpectedErrorFault), Action="https://secure.eloqua.com/API/1.2/ExternalActionService/GetMemberCountInStepBySta" +
            "tusUnexpectedErrorFaultFault", Name="UnexpectedErrorFault")]
        int GetMemberCountInStepByStatus(int stepId, EloquaTestClient.EloquaProgramService.ExternalActionStatus status);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://secure.eloqua.com/API/1.2/ExternalActionService/ListMembersInStepByStatus" +
            "", ReplyAction="https://secure.eloqua.com/API/1.2/ExternalActionService/ListMembersInStepByStatus" +
            "Response")]
        [System.ServiceModel.FaultContractAttribute(typeof(EloquaTestClient.EloquaProgramService.UnexpectedErrorFault), Action="https://secure.eloqua.com/API/1.2/ExternalActionService/ListMembersInStepByStatus" +
            "UnexpectedErrorFaultFault", Name="UnexpectedErrorFault")]
        EloquaTestClient.EloquaProgramService.Member[] ListMembersInStepByStatus(int stepId, EloquaTestClient.EloquaProgramService.ExternalActionStatus status, int pageNumber, int pageSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://secure.eloqua.com/API/1.2/ExternalActionService/SetMemberStatus", ReplyAction="https://secure.eloqua.com/API/1.2/ExternalActionService/SetMemberStatusResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EloquaTestClient.EloquaProgramService.UnexpectedErrorFault), Action="https://secure.eloqua.com/API/1.2/ExternalActionService/SetMemberStatusUnexpected" +
            "ErrorFaultFault", Name="UnexpectedErrorFault")]
        EloquaTestClient.EloquaProgramService.Member[] SetMemberStatus(EloquaTestClient.EloquaProgramService.Member[] members, EloquaTestClient.EloquaProgramService.ExternalActionStatus status);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://secure.eloqua.com/API/1.2/ExternalActionService/GetMailAddressStatus", ReplyAction="https://secure.eloqua.com/API/1.2/ExternalActionService/GetMailAddressStatusRespo" +
            "nse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EloquaTestClient.EloquaProgramService.InvalidArgumentFault), Action="https://secure.eloqua.com/API/1.2/ExternalActionService/GetMailAddressStatusInval" +
            "idArgumentFaultFault", Name="InvalidArgumentFault")]
        [System.ServiceModel.FaultContractAttribute(typeof(EloquaTestClient.EloquaProgramService.UnexpectedErrorFault), Action="https://secure.eloqua.com/API/1.2/ExternalActionService/GetMailAddressStatusUnexp" +
            "ectedErrorFaultFault", Name="UnexpectedErrorFault")]
        EloquaTestClient.EloquaProgramService.MailAddressStatus GetMailAddressStatus(EloquaTestClient.EloquaProgramService.EntityType entityType, int entityId);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://secure.eloqua.com/API/1.2/ExternalActionService/SetMailAddressStatus", ReplyAction="https://secure.eloqua.com/API/1.2/ExternalActionService/SetMailAddressStatusRespo" +
            "nse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EloquaTestClient.EloquaProgramService.UnexpectedErrorFault), Action="https://secure.eloqua.com/API/1.2/ExternalActionService/SetMailAddressStatusUnexp" +
            "ectedErrorFaultFault", Name="UnexpectedErrorFault")]
        [System.ServiceModel.FaultContractAttribute(typeof(EloquaTestClient.EloquaProgramService.InvalidArgumentFault), Action="https://secure.eloqua.com/API/1.2/ExternalActionService/SetMailAddressStatusInval" +
            "idArgumentFaultFault", Name="InvalidArgumentFault")]
        void SetMailAddressStatus(EloquaTestClient.EloquaProgramService.EntityType entityType, int entityId, EloquaTestClient.EloquaProgramService.MailAddressStatus status);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ExternalActionServiceChannel : EloquaTestClient.EloquaProgramService.ExternalActionService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ExternalActionServiceClient : System.ServiceModel.ClientBase<EloquaTestClient.EloquaProgramService.ExternalActionService>, EloquaTestClient.EloquaProgramService.ExternalActionService {
        
        public ExternalActionServiceClient() {
        }
        
        public ExternalActionServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ExternalActionServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExternalActionServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExternalActionServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public EloquaTestClient.EloquaProgramService.Step[] ListExternalActionStepsByType(string externalProvider) {
            return base.Channel.ListExternalActionStepsByType(externalProvider);
        }
        
        public int GetMemberCountInStepByStatus(int stepId, EloquaTestClient.EloquaProgramService.ExternalActionStatus status) {
            return base.Channel.GetMemberCountInStepByStatus(stepId, status);
        }
        
        public EloquaTestClient.EloquaProgramService.Member[] ListMembersInStepByStatus(int stepId, EloquaTestClient.EloquaProgramService.ExternalActionStatus status, int pageNumber, int pageSize) {
            return base.Channel.ListMembersInStepByStatus(stepId, status, pageNumber, pageSize);
        }
        
        public EloquaTestClient.EloquaProgramService.Member[] SetMemberStatus(EloquaTestClient.EloquaProgramService.Member[] members, EloquaTestClient.EloquaProgramService.ExternalActionStatus status) {
            return base.Channel.SetMemberStatus(members, status);
        }
        
        public EloquaTestClient.EloquaProgramService.MailAddressStatus GetMailAddressStatus(EloquaTestClient.EloquaProgramService.EntityType entityType, int entityId) {
            return base.Channel.GetMailAddressStatus(entityType, entityId);
        }
        
        public void SetMailAddressStatus(EloquaTestClient.EloquaProgramService.EntityType entityType, int entityId, EloquaTestClient.EloquaProgramService.MailAddressStatus status) {
            base.Channel.SetMailAddressStatus(entityType, entityId, status);
        }
    }
}
