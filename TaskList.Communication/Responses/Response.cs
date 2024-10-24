namespace TaskList.Communication.Responses
{
    public class Response
    {
        private string ErrorMessage { get; set; } = string.Empty;
        public Response(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }
        public string BadRequest(string errorMessage)
        {
            return ErrorMessage;
        }
        public string InternalServerError(string errorMessage)
        {
            return ErrorMessage;
        }

        public string MethodNotImplementation(string errorMessage)
        {
            return ErrorMessage;
        }
    }
}
