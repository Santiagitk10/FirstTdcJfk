using Jfk.Tc.Decn.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.ServiceModel;

namespace Jfk.Tc.Decn.Soap
{
    [ServiceContract, XmlSerializerFormat]
    public interface ICreditCardSoapService
    {
        [OperationContract]
        Task<IEnumerable<CreditCard>> GetAll();

        [OperationContract]
        Task<CreditCard> GetById(int id);

        [OperationContract]
        Task<int> Add(CreditCard tdc);
        //Task<int> Add(ActionResult tdc);

        [OperationContract]
        string Res(int num1, int num2);
    }
}
