using LimpShared.ResultTypeEnum;

namespace LimpShared.Authentification
{
    public class TokenRelatedOperationResult
    {
        public OperationResultType ResultType { get; set; }
        public FailureType? FailureType { get; set; }
        public JWTPair? JWTPairPayload { get; set; }
        public string? Username { get; set; }
        public string? Message { get; set; }
    }
}
