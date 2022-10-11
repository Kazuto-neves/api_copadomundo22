using System;
using System.Collections.Generic;

namespace api_copadomundo22.ModelViews

{
    public record AdmLoginView
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
