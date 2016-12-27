using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie8
{
    class NaszWyjatekException:Exception
    {
        public const string ErrMessage = "ALE BLAD";

        public NaszWyjatekException(string Message):base(Message)
        {
        }
        public NaszWyjatekException(string Message,Exception innerException):base(Message,innerException)
        {

        }
    }

}
