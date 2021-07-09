using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05.ExemploInterface
{

    [Serializable]
    public class MensagemInvalidaException : Exception
    {
        public MensagemInvalidaException() { }
        public MensagemInvalidaException(string message) : base(message) { }
        public MensagemInvalidaException(string message, Exception inner) : base(message, inner) { }
        protected MensagemInvalidaException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
