namespace UniversalLogic.Results
{
    public class OperationResult
    {
        private bool Success { get; set; }
        private string Message { get; set; }

        public OperationResult(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public override string ToString()
        {
            return "Success : " + Success + "\n" + "Message : " + Message;
        }
        
    }
}