using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HelloServiceWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHelloServiceWCF" in both code and config file together.
    [ServiceContract] //bu interface bir wcf servisidir
    public interface IHelloServiceWCF
    {
        [OperationContract]
        string GetMessage(string name); //bu metod client tarafında tüketilmeye hazırdır operationcontract ile tanımlı old. için


    }
}
