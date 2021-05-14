namespace Football.Service.Models.Response
{
    public class BaseResponse
    {
        public int Code { get; set; } = (int)ApiErrorCodes.Success;
        public string Message { get; set; }
    }

    public class BaseResponse<T> : BaseResponse
        where T : class
    {
        public T Data { get; set; }
    }
}
