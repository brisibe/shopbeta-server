using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace shopbeta.Core.Interfaces
{
    public interface IStorageService
    {

        Task<string> Upload(IFormFile file);
    }
}
