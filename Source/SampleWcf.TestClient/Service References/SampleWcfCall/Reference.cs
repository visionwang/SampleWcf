﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.237
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SampleWcf.TestClient.SampleWcfCall {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FileDescriptor", Namespace="http://schemas.datacontract.org/2004/07/SampleWcf.Web")]
    [System.SerializableAttribute()]
    public partial struct FileDescriptor : System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] ContentsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Contents {
            get {
                return this.ContentsField;
            }
            set {
                if ((object.ReferenceEquals(this.ContentsField, value) != true)) {
                    this.ContentsField = value;
                    this.RaisePropertyChanged("Contents");
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
        
        void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SampleWcfCall.IFileTracker")]
    public interface IFileTracker {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileTracker/Track", ReplyAction="http://tempuri.org/IFileTracker/TrackResponse")]
        void Track(SampleWcf.TestClient.SampleWcfCall.FileDescriptor[] files);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFileTrackerChannel : SampleWcf.TestClient.SampleWcfCall.IFileTracker, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FileTrackerClient : System.ServiceModel.ClientBase<SampleWcf.TestClient.SampleWcfCall.IFileTracker>, SampleWcf.TestClient.SampleWcfCall.IFileTracker {
        
        public FileTrackerClient() {
        }
        
        public FileTrackerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FileTrackerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileTrackerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileTrackerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Track(SampleWcf.TestClient.SampleWcfCall.FileDescriptor[] files) {
            base.Channel.Track(files);
        }
    }
}