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
            Success = true;
        }
        public BaseResponse(string message)
        {
            Success = true;
            StatusCode = 200;
            Message = message;
        }

        public BaseResponse(string message, bool success, int statusCode)
        {
            Success = success;
            StatusCode = statusCode;
            Message = message;
        }
        public BaseResponse(string message, bool success, int statusCode, T data)
        {
            StatusCode = statusCode;
            Success = success;
            Message = message;
            Data = data;
        }
        public BaseResponse(string message, bool success, int statusCode, List<T> dataList)
        {
            StatusCode = statusCode;
            Success = success;
            Message = message;
            DataList = dataList;
        }

        public bool Success { get; set; }
        public int StatusCode {  get; set; }
        public string Message { get; set; } = string.Empty;
        public T? Data { get; set; }
        public List<T> DataList { get; set; }
        public List<string>? ValidationErrors { get; set; }
    }
}
