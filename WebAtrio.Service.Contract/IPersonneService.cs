using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WebAtrio.Dao.Entity;

namespace WebAtrio.Service.Contract
{
    [ServiceContract]
    public interface IPersonneService
    {
        [OperationContract]
        void SaveOrUpdate(Personne personne);
    }
}
