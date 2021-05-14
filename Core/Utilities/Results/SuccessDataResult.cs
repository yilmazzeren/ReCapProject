using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data,string message):base(data,true,message)
        {
            //ister data ve mesaj ver
        }

        public SuccessDataResult(T data):base(data,true)
        {
            //ister sadece data ver
        }

        public SuccessDataResult(string message):base(default,true,message)
        {
            //ister sadece mesaj ver
        }

        public SuccessDataResult():base(default,true)
        {
                //ister hiç bir şey verme
        }
    }
}
