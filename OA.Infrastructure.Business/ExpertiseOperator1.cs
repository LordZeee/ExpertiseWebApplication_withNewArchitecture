using OA.Domain.Core.Entitys;
using OA.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace OA.Infrastructure.Business
{
    public class ExpertiseOperator1 : IExpertise
    {
        public tbExpertizy CreateExpertise(IEnumerable<tbExpertizy> item)
        {
            int lastN1 = (int)item.OrderByDescending(x => x.N1).First().N1;

            tbExpertizy model = new tbExpertizy() { N1 = lastN1 + 1, N2 = 0, N3 = 0 };

            // generating tNumEZ
            model.mTitleDoc = $"Експертиза - №{model.tNumEZ}";
            model.lArchive = false;
            model.nStatusE = 1;
            return model;
        }
    }
}