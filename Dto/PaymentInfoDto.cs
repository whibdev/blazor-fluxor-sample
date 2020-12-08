namespace Flux.Wasm.Dto
{
    public class PaymentInfoDto
    {
        public string NameOnCard { get; set; }
        public string CardNumber { get; set; }
        public string ExpMonth { get; set; }
        public string ExpYear { get; set; }
        public string Cvv { get; set; }
        public bool IsStepComplete { get; set; } = false;
    }
}
