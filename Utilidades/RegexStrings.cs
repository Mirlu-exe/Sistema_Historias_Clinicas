using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{


    public sealed class RegexStrings
    {
        private RegexStrings()
        {

        }

        public const string REGEX_EMAIL =
            "^(?=.{1,64}@)[\\p{L}0-9_-]+(\\.[\\p{L}0-9_-]+)*@[^-][\\p{L}0-9-]+(\\.[\\p{L}0-9-]+)*(\\.[\\p{L}]{2,})$";


        public const string REGEX_ONLY_NUMBERS = "^[0-9-]+$";

    }
}
