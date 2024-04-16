namespace GitAssignment.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public bool IsSuccess { get; set; }
    }
}
