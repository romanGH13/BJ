using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BlackJackServiceWCF
{
    [ServiceContract(InstanceContextMode = InstanceContextMode.Single)]
    public interface IGame
    {
        [OperationContract]
        int Connect(string playerName, int playerId);

        //[OperationContract]
        //Card GiveCard();
    }


}
