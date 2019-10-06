using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XGame.Domain.Arguments.Base
{
    public class ReponseBase
    {
        public ReponseBase()
        {
            Message = XGame.Domain.Resources.Message.X0_SUCESSO;
        }
        public string Message { get; set; }

    }
}
