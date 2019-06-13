﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LiftAndShiftMvcApp.Web.ServiceReferenceIIS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceIIS.IOrdersManagement")]
    public interface IOrdersManagement {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdersManagement/DoWork", ReplyAction="http://tempuri.org/IOrdersManagement/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdersManagement/DoWork", ReplyAction="http://tempuri.org/IOrdersManagement/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdersManagement/CreateOrder", ReplyAction="http://tempuri.org/IOrdersManagement/CreateOrderResponse")]
        string CreateOrder(LiftAndShiftApp.Models.Models.ProductModel[] products);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdersManagement/CreateOrder", ReplyAction="http://tempuri.org/IOrdersManagement/CreateOrderResponse")]
        System.Threading.Tasks.Task<string> CreateOrderAsync(LiftAndShiftApp.Models.Models.ProductModel[] products);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOrdersManagementChannel : LiftAndShiftMvcApp.Web.ServiceReferenceIIS.IOrdersManagement, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OrdersManagementClient : System.ServiceModel.ClientBase<LiftAndShiftMvcApp.Web.ServiceReferenceIIS.IOrdersManagement>, LiftAndShiftMvcApp.Web.ServiceReferenceIIS.IOrdersManagement {
        
        public OrdersManagementClient() {
        }
        
        public OrdersManagementClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OrdersManagementClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrdersManagementClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrdersManagementClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public string CreateOrder(LiftAndShiftApp.Models.Models.ProductModel[] products) {
            return base.Channel.CreateOrder(products);
        }
        
        public System.Threading.Tasks.Task<string> CreateOrderAsync(LiftAndShiftApp.Models.Models.ProductModel[] products) {
            return base.Channel.CreateOrderAsync(products);
        }
    }
}