using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_Arquitetura
{
    public interface IFileHelper
    {
        string GetLocalFilePath(string filename);
    }
}
