﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlackJackClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IGame")]
    public interface IGame {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGame/Connect", ReplyAction="http://tempuri.org/IGame/ConnectResponse")]
        int Connect(string playerName, int playerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGame/Connect", ReplyAction="http://tempuri.org/IGame/ConnectResponse")]
        System.Threading.Tasks.Task<int> ConnectAsync(string playerName, int playerId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGameChannel : BlackJackClient.ServiceReference1.IGame, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GameClient : System.ServiceModel.ClientBase<BlackJackClient.ServiceReference1.IGame>, BlackJackClient.ServiceReference1.IGame {
        
        public GameClient() {
        }
        
        public GameClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GameClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GameClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GameClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Connect(string playerName, int playerId) {
            return base.Channel.Connect(playerName, playerId);
        }
        
        public System.Threading.Tasks.Task<int> ConnectAsync(string playerName, int playerId) {
            return base.Channel.ConnectAsync(playerName, playerId);
        }
    }
}