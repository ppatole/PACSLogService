﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestApp.RecordLogRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RecordLogRef.IRecordLog")]
    public interface IRecordLog {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRecordLog/LogThis", ReplyAction="http://tempuri.org/IRecordLog/LogThisResponse")]
        void LogThis(string XMLValue);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRecordLog/LogThis", ReplyAction="http://tempuri.org/IRecordLog/LogThisResponse")]
        System.Threading.Tasks.Task LogThisAsync(string XMLValue);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRecordLogChannel : TestApp.RecordLogRef.IRecordLog, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RecordLogClient : System.ServiceModel.ClientBase<TestApp.RecordLogRef.IRecordLog>, TestApp.RecordLogRef.IRecordLog {
        
        public RecordLogClient() {
        }
        
        public RecordLogClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RecordLogClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RecordLogClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RecordLogClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void LogThis(string XMLValue) {
            base.Channel.LogThis(XMLValue);
        }
        
        public System.Threading.Tasks.Task LogThisAsync(string XMLValue) {
            return base.Channel.LogThisAsync(XMLValue);
        }
    }
}
