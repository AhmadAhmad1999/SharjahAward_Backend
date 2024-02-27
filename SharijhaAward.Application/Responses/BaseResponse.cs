using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Responses
{
    public class BaseResponse<T>
    {
        public BaseResponse()
        {
            success = true;
        }
        public BaseResponse(string message)
        {
            success = true;
            statusCode = 200;
            this.message = message;
        }

        public BaseResponse(string message, bool success, int statusCode)
        {
            this.success = success;
            this.statusCode = statusCode;
            this.message = message;
        }
        public BaseResponse(string message, bool success, int statusCode, T data)
        {
            this.statusCode = statusCode;
            this.success = success;
            this.message = message;
            this.data = data;
        }
 

        public bool success { get; set; }
        public int statusCode {  get; set; }
        public string message { get; set; } = string.Empty;
        public T? data { get; set; }
        public List<string>? validationErrors { get; set; }
    }
}
