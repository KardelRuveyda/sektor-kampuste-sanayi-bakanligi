using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DotnetWorkshop.Core.DTOs
{
    public class GlobalResponseDto<T>
    {
        public T Data { get; set; }

        [JsonIgnore]
        public int StatusCode { get; set; }

        public List<string> Errors { get; set; }

        //Add için aşağıdaki uygun olabilir
        public static GlobalResponseDto<T> Success(int statusCode,T data)
        {
            return new GlobalResponseDto<T> { Data = data, StatusCode = statusCode };
        }
        //Update ve Remove için aşağıdaki örnek uygun olabilir. 

        public static GlobalResponseDto<T> Success(int statusCode)
        {
            return new GlobalResponseDto<T> { StatusCode = statusCode };
        }

        public static GlobalResponseDto<T> Fail(int statusCode,List<string> errors)
        {
            return new GlobalResponseDto<T> { StatusCode = statusCode, Errors = errors };
        }

        public static GlobalResponseDto<T> Fail(int statusCode, string error)
        {
            return new GlobalResponseDto<T> { StatusCode = statusCode, Errors = new List<string> { error } };
        }
    }
}
