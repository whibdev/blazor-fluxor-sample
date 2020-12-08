namespace Flux.Wasm.Dto
{
    public class UserDto
    {
        public string NameFirst { get; set; }
        public string NameLast { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool IsStepComplete { get; set; } = false;
    }
    
}
