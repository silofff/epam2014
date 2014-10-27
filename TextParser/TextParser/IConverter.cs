using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextParser
{
    interface IConverter<out T, in TU>
    {
        T Convert(TU convertible);
    }
}
