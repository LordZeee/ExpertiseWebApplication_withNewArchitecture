using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OA.Services.Interfaces
{
    public interface IHelperAPI
    {
        HttpClient Initial();
    }
}
