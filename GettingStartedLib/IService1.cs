using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GettingStartedLib
{
   [ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples")]
   public interface ICalculator
    {
        [OperationContract]
        double add(double n1, double n2);
        [OperationContract]
        double multiply(double n1, double n2);
        [OperationContract]
        double divide(double n1, double n2);
        [OperationContract]
        double subtract(double n1, double n2);
    }
}
