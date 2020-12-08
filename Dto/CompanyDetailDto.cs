using System;

namespace Flux.Wasm.Dto
{
    public class CompanyDetailDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime IncDate { get; set; } = DateTime.Now.AddYears(-15);
        public bool IsStepComplete { get; set; } = false;
    }

    
}
