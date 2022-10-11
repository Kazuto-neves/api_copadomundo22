using System;
using System.Collections.Generic;

namespace Api_Adm.ModelViews
{
    public record HomeView
    {
        public string Informacao => "Bem vindo ao sistema";
        public List<dynamic> Endpoints => new List<dynamic>(){
            new { Documentacao = "/swagger" },
            new {
                Itens = new List<dynamic>(){ 
                    new { Path = "/administradores" },
                }
            }
        };
    }
}
