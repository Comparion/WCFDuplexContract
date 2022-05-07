﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DuplexCalcProgram.DuplexCalcServiceRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DuplexCalcServiceRef.IDuplexCalc", CallbackContract=typeof(DuplexCalcProgram.DuplexCalcServiceRef.IDuplexCalcCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IDuplexCalc {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IDuplexCalc/Wyczysc")]
        void Wyczysc();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IDuplexCalc/Wyczysc")]
        System.Threading.Tasks.Task WyczyscAsync();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IDuplexCalc/DodajDo")]
        void DodajDo(double n);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IDuplexCalc/DodajDo")]
        System.Threading.Tasks.Task DodajDoAsync(double n);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IDuplexCalc/OdejmijOd")]
        void OdejmijOd(double n);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IDuplexCalc/OdejmijOd")]
        System.Threading.Tasks.Task OdejmijOdAsync(double n);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IDuplexCalc/PomnozPrzez")]
        void PomnozPrzez(double n);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IDuplexCalc/PomnozPrzez")]
        System.Threading.Tasks.Task PomnozPrzezAsync(double n);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IDuplexCalc/PodzielPrzez")]
        void PodzielPrzez(double n);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IDuplexCalc/PodzielPrzez")]
        System.Threading.Tasks.Task PodzielPrzezAsync(double n);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IDuplexCalc/LicznikStart")]
        void LicznikStart();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IDuplexCalc/LicznikStart")]
        System.Threading.Tasks.Task LicznikStartAsync();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IDuplexCalc/LicznikStop")]
        void LicznikStop();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IDuplexCalc/LicznikStop")]
        System.Threading.Tasks.Task LicznikStopAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDuplexCalcCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IDuplexCalc/Wynik")]
        void Wynik(double result);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IDuplexCalc/Rownanie")]
        void Rownanie(string eqn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDuplexCalc/LicznikStan", ReplyAction="http://tempuri.org/IDuplexCalc/LicznikStanResponse")]
        void LicznikStan(int licznik);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDuplexCalcChannel : DuplexCalcProgram.DuplexCalcServiceRef.IDuplexCalc, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DuplexCalcClient : System.ServiceModel.DuplexClientBase<DuplexCalcProgram.DuplexCalcServiceRef.IDuplexCalc>, DuplexCalcProgram.DuplexCalcServiceRef.IDuplexCalc {
        
        public DuplexCalcClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public DuplexCalcClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public DuplexCalcClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public DuplexCalcClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public DuplexCalcClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void Wyczysc() {
            base.Channel.Wyczysc();
        }
        
        public System.Threading.Tasks.Task WyczyscAsync() {
            return base.Channel.WyczyscAsync();
        }
        
        public void DodajDo(double n) {
            base.Channel.DodajDo(n);
        }
        
        public System.Threading.Tasks.Task DodajDoAsync(double n) {
            return base.Channel.DodajDoAsync(n);
        }
        
        public void OdejmijOd(double n) {
            base.Channel.OdejmijOd(n);
        }
        
        public System.Threading.Tasks.Task OdejmijOdAsync(double n) {
            return base.Channel.OdejmijOdAsync(n);
        }
        
        public void PomnozPrzez(double n) {
            base.Channel.PomnozPrzez(n);
        }
        
        public System.Threading.Tasks.Task PomnozPrzezAsync(double n) {
            return base.Channel.PomnozPrzezAsync(n);
        }
        
        public void PodzielPrzez(double n) {
            base.Channel.PodzielPrzez(n);
        }
        
        public System.Threading.Tasks.Task PodzielPrzezAsync(double n) {
            return base.Channel.PodzielPrzezAsync(n);
        }
        
        public void LicznikStart() {
            base.Channel.LicznikStart();
        }
        
        public System.Threading.Tasks.Task LicznikStartAsync() {
            return base.Channel.LicznikStartAsync();
        }
        
        public void LicznikStop() {
            base.Channel.LicznikStop();
        }
        
        public System.Threading.Tasks.Task LicznikStopAsync() {
            return base.Channel.LicznikStopAsync();
        }
    }
}
