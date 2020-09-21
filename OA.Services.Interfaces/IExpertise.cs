using OA.Domain.Core.Entitys;
using System.Collections.Generic;

namespace OA.Services.Interfaces
{
    public interface IExpertise
    {
        tbExpertizy CreateExpertise(IEnumerable<tbExpertizy> tbExpertizy);
    }
}
