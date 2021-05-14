using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
       
        public Result(bool success, string message):this(success)
        {
            // bu constractor'ı çalıştıran elaman iki parametreli
            // contractor çalıştırabilir burda this diyerek istersen tek parametreli
            // olan constractor'a success'i gönderiyoruz. çalıştırabilirsin diyoruz.

            // get read only'dir ama constractor içerisinde set edilebilir
            Message = message;
        }
        public Result(bool success)
        {
            // Geriye bir mesaj göndermeyebilir 
            Success = success;

        }


        public bool Success { get; }

        public string Message { get; }
    }
}
