﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 14.0.23107.0
// 
namespace SunApp.AddEmployee {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://agroassistant.azurewebsites.net/Services/", ConfigurationName="AddEmployee.add_employeeSoap")]
    public interface add_employeeSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://agroassistant.azurewebsites.net/Services/AddEmployee", ReplyAction="*")]
        System.Threading.Tasks.Task<SunApp.AddEmployee.AddEmployeeResponse> AddEmployeeAsync(SunApp.AddEmployee.AddEmployeeRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddEmployeeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddEmployee", Namespace="http://agroassistant.azurewebsites.net/Services/", Order=0)]
        public SunApp.AddEmployee.AddEmployeeRequestBody Body;
        
        public AddEmployeeRequest() {
        }
        
        public AddEmployeeRequest(SunApp.AddEmployee.AddEmployeeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://agroassistant.azurewebsites.net/Services/")]
    public partial class AddEmployeeRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int xIdFarm;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string xName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string xLastName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string xNickName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string xEmail;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string xPhone;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string xAddress;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string xBirthday;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=8)]
        public bool xTemp;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=9)]
        public int xDaysAtWork;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=10)]
        public string xFistHiringDate;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=11)]
        public string xLastHiringDate;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=12)]
        public string xLastResignationDate;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=13)]
        public string xBrazilCPF;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=14)]
        public string xBrazilRG;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=15)]
        public string xPassport;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=16)]
        public string xBrazilCarteiraDeTrabalho;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=17)]
        public string xBrazilCNPJ;
        
        public AddEmployeeRequestBody() {
        }
        
        public AddEmployeeRequestBody(
                    int xIdFarm, 
                    string xName, 
                    string xLastName, 
                    string xNickName, 
                    string xEmail, 
                    string xPhone, 
                    string xAddress, 
                    string xBirthday, 
                    bool xTemp, 
                    int xDaysAtWork, 
                    string xFistHiringDate, 
                    string xLastHiringDate, 
                    string xLastResignationDate, 
                    string xBrazilCPF, 
                    string xBrazilRG, 
                    string xPassport, 
                    string xBrazilCarteiraDeTrabalho, 
                    string xBrazilCNPJ) {
            this.xIdFarm = xIdFarm;
            this.xName = xName;
            this.xLastName = xLastName;
            this.xNickName = xNickName;
            this.xEmail = xEmail;
            this.xPhone = xPhone;
            this.xAddress = xAddress;
            this.xBirthday = xBirthday;
            this.xTemp = xTemp;
            this.xDaysAtWork = xDaysAtWork;
            this.xFistHiringDate = xFistHiringDate;
            this.xLastHiringDate = xLastHiringDate;
            this.xLastResignationDate = xLastResignationDate;
            this.xBrazilCPF = xBrazilCPF;
            this.xBrazilRG = xBrazilRG;
            this.xPassport = xPassport;
            this.xBrazilCarteiraDeTrabalho = xBrazilCarteiraDeTrabalho;
            this.xBrazilCNPJ = xBrazilCNPJ;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddEmployeeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddEmployeeResponse", Namespace="http://agroassistant.azurewebsites.net/Services/", Order=0)]
        public SunApp.AddEmployee.AddEmployeeResponseBody Body;
        
        public AddEmployeeResponse() {
        }
        
        public AddEmployeeResponse(SunApp.AddEmployee.AddEmployeeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class AddEmployeeResponseBody {
        
        public AddEmployeeResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface add_employeeSoapChannel : SunApp.AddEmployee.add_employeeSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class add_employeeSoapClient : System.ServiceModel.ClientBase<SunApp.AddEmployee.add_employeeSoap>, SunApp.AddEmployee.add_employeeSoap {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public add_employeeSoapClient() : 
                base(add_employeeSoapClient.GetDefaultBinding(), add_employeeSoapClient.GetDefaultEndpointAddress()) {
            this.Endpoint.Name = EndpointConfiguration.add_employeeSoap.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public add_employeeSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(add_employeeSoapClient.GetBindingForEndpoint(endpointConfiguration), add_employeeSoapClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public add_employeeSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(add_employeeSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public add_employeeSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(add_employeeSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public add_employeeSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SunApp.AddEmployee.AddEmployeeResponse> SunApp.AddEmployee.add_employeeSoap.AddEmployeeAsync(SunApp.AddEmployee.AddEmployeeRequest request) {
            return base.Channel.AddEmployeeAsync(request);
        }
        
        public System.Threading.Tasks.Task<SunApp.AddEmployee.AddEmployeeResponse> AddEmployeeAsync(
                    int xIdFarm, 
                    string xName, 
                    string xLastName, 
                    string xNickName, 
                    string xEmail, 
                    string xPhone, 
                    string xAddress, 
                    string xBirthday, 
                    bool xTemp, 
                    int xDaysAtWork, 
                    string xFistHiringDate, 
                    string xLastHiringDate, 
                    string xLastResignationDate, 
                    string xBrazilCPF, 
                    string xBrazilRG, 
                    string xPassport, 
                    string xBrazilCarteiraDeTrabalho, 
                    string xBrazilCNPJ) {
            SunApp.AddEmployee.AddEmployeeRequest inValue = new SunApp.AddEmployee.AddEmployeeRequest();
            inValue.Body = new SunApp.AddEmployee.AddEmployeeRequestBody();
            inValue.Body.xIdFarm = xIdFarm;
            inValue.Body.xName = xName;
            inValue.Body.xLastName = xLastName;
            inValue.Body.xNickName = xNickName;
            inValue.Body.xEmail = xEmail;
            inValue.Body.xPhone = xPhone;
            inValue.Body.xAddress = xAddress;
            inValue.Body.xBirthday = xBirthday;
            inValue.Body.xTemp = xTemp;
            inValue.Body.xDaysAtWork = xDaysAtWork;
            inValue.Body.xFistHiringDate = xFistHiringDate;
            inValue.Body.xLastHiringDate = xLastHiringDate;
            inValue.Body.xLastResignationDate = xLastResignationDate;
            inValue.Body.xBrazilCPF = xBrazilCPF;
            inValue.Body.xBrazilRG = xBrazilRG;
            inValue.Body.xPassport = xPassport;
            inValue.Body.xBrazilCarteiraDeTrabalho = xBrazilCarteiraDeTrabalho;
            inValue.Body.xBrazilCNPJ = xBrazilCNPJ;
            return ((SunApp.AddEmployee.add_employeeSoap)(this)).AddEmployeeAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.add_employeeSoap)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.add_employeeSoap)) {
                return new System.ServiceModel.EndpointAddress("http://agroassistant.azurewebsites.net/Services/add-employee.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return add_employeeSoapClient.GetBindingForEndpoint(EndpointConfiguration.add_employeeSoap);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return add_employeeSoapClient.GetEndpointAddress(EndpointConfiguration.add_employeeSoap);
        }
        
        public enum EndpointConfiguration {
            
            add_employeeSoap,
        }
    }
}
