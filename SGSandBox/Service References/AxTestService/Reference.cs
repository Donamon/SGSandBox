﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SGSandBox.AxTestService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AxTestService.AxTestServiceSoap")]
    public interface AxTestServiceSoap {
        
        // CODEGEN: Generating message contract since element name GetItemPriceResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetItemPrice", ReplyAction="*")]
        SGSandBox.AxTestService.GetItemPriceResponse GetItemPrice(SGSandBox.AxTestService.GetItemPriceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetItemPrice", ReplyAction="*")]
        System.Threading.Tasks.Task<SGSandBox.AxTestService.GetItemPriceResponse> GetItemPriceAsync(SGSandBox.AxTestService.GetItemPriceRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetItemPriceRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetItemPrice", Namespace="http://tempuri.org/", Order=0)]
        public SGSandBox.AxTestService.GetItemPriceRequestBody Body;
        
        public GetItemPriceRequest() {
        }
        
        public GetItemPriceRequest(SGSandBox.AxTestService.GetItemPriceRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetItemPriceRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int itemId;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int customerId;
        
        public GetItemPriceRequestBody() {
        }
        
        public GetItemPriceRequestBody(int itemId, int customerId) {
            this.itemId = itemId;
            this.customerId = customerId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetItemPriceResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetItemPriceResponse", Namespace="http://tempuri.org/", Order=0)]
        public SGSandBox.AxTestService.GetItemPriceResponseBody Body;
        
        public GetItemPriceResponse() {
        }
        
        public GetItemPriceResponse(SGSandBox.AxTestService.GetItemPriceResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetItemPriceResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetItemPriceResult;
        
        public GetItemPriceResponseBody() {
        }
        
        public GetItemPriceResponseBody(string GetItemPriceResult) {
            this.GetItemPriceResult = GetItemPriceResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AxTestServiceSoapChannel : SGSandBox.AxTestService.AxTestServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AxTestServiceSoapClient : System.ServiceModel.ClientBase<SGSandBox.AxTestService.AxTestServiceSoap>, SGSandBox.AxTestService.AxTestServiceSoap {
        
        public AxTestServiceSoapClient() {
        }
        
        public AxTestServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AxTestServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AxTestServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AxTestServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SGSandBox.AxTestService.GetItemPriceResponse SGSandBox.AxTestService.AxTestServiceSoap.GetItemPrice(SGSandBox.AxTestService.GetItemPriceRequest request) {
            return base.Channel.GetItemPrice(request);
        }
        
        public string GetItemPrice(int itemId, int customerId) {
            SGSandBox.AxTestService.GetItemPriceRequest inValue = new SGSandBox.AxTestService.GetItemPriceRequest();
            inValue.Body = new SGSandBox.AxTestService.GetItemPriceRequestBody();
            inValue.Body.itemId = itemId;
            inValue.Body.customerId = customerId;
            SGSandBox.AxTestService.GetItemPriceResponse retVal = ((SGSandBox.AxTestService.AxTestServiceSoap)(this)).GetItemPrice(inValue);
            return retVal.Body.GetItemPriceResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SGSandBox.AxTestService.GetItemPriceResponse> SGSandBox.AxTestService.AxTestServiceSoap.GetItemPriceAsync(SGSandBox.AxTestService.GetItemPriceRequest request) {
            return base.Channel.GetItemPriceAsync(request);
        }
        
        public System.Threading.Tasks.Task<SGSandBox.AxTestService.GetItemPriceResponse> GetItemPriceAsync(int itemId, int customerId) {
            SGSandBox.AxTestService.GetItemPriceRequest inValue = new SGSandBox.AxTestService.GetItemPriceRequest();
            inValue.Body = new SGSandBox.AxTestService.GetItemPriceRequestBody();
            inValue.Body.itemId = itemId;
            inValue.Body.customerId = customerId;
            return ((SGSandBox.AxTestService.AxTestServiceSoap)(this)).GetItemPriceAsync(inValue);
        }
    }
}