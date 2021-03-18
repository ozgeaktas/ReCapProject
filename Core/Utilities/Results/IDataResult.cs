using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //T: hangi tipi döndereceğini söyler.
    public interface IDataResult<T>:IResult
    {
        T Data { get;  }
    }
}
