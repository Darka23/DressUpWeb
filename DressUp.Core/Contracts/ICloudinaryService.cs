using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DressUp.Core.Contracts
{
    public interface ICloudinaryService
    {
        public string Image(IFormFile file, string folder);
    }
}
