﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServicoEstoque
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ItemEstoque", Namespace="http://schemas.datacontract.org/2004/07/ServicoEstoque")]
    public partial class ItemEstoque : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string CodigoField;
        
        private int QuantidadeField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Codigo
        {
            get
            {
                return this.CodigoField;
            }
            set
            {
                this.CodigoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Quantidade
        {
            get
            {
                return this.QuantidadeField;
            }
            set
            {
                this.QuantidadeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AutorizacaoFault", Namespace="http://schemas.datacontract.org/2004/07/ServicoEstoque")]
    public partial class AutorizacaoFault : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string MensagemField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mensagem
        {
            get
            {
                return this.MensagemField;
            }
            set
            {
                this.MensagemField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://caelum.com.br/estoquews/v1", ConfigurationName="IEstoqueWS")]
public interface IEstoqueWS
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://caelum.com.br/estoquews/v1/IEstoqueWS/GetQuantidade", ReplyAction="http://caelum.com.br/estoquews/v1/IEstoqueWS/GetQuantidadeResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(ServicoEstoque.AutorizacaoFault), Action="http://caelum.com.br/estoquews/v1/IEstoqueWS/GetQuantidadeAutorizacaoFaultFault", Name="AutorizacaoFault", Namespace="http://schemas.datacontract.org/2004/07/ServicoEstoque")]
    ServicoEstoque.ItemEstoque[] GetQuantidade(string[] codigos);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://caelum.com.br/estoquews/v1/IEstoqueWS/GetQuantidade", ReplyAction="http://caelum.com.br/estoquews/v1/IEstoqueWS/GetQuantidadeResponse")]
    System.Threading.Tasks.Task<ServicoEstoque.ItemEstoque[]> GetQuantidadeAsync(string[] codigos);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IEstoqueWSChannel : IEstoqueWS, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class EstoqueWSClient : System.ServiceModel.ClientBase<IEstoqueWS>, IEstoqueWS
{
    
    public EstoqueWSClient()
    {
    }
    
    public EstoqueWSClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public EstoqueWSClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public EstoqueWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public EstoqueWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public ServicoEstoque.ItemEstoque[] GetQuantidade(string[] codigos)
    {
        return base.Channel.GetQuantidade(codigos);
    }
    
    public System.Threading.Tasks.Task<ServicoEstoque.ItemEstoque[]> GetQuantidadeAsync(string[] codigos)
    {
        return base.Channel.GetQuantidadeAsync(codigos);
    }
}
