using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BlackJackServiceWCF
{
    [ServiceContract (CallbackContract = typeof(IMyCallback))]
    public interface IGame
    {
        [OperationContract]
        int Connect(string playerName);

        [OperationContract]
        Card GiveCard(int playerId);

        [OperationContract]
        void Pass(int playerId);

        [OperationContract]
        void Ready(int playerId);

        [OperationContract]
        void Exit(int playerId);
    }

    public interface IMyCallback
    {
        [OperationContract]
        void ShowCard(Card card, int playerId);

        //[OperationContract]
        //void ShowCard();
    }


}
