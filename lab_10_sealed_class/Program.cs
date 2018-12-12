using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_10_sealed_class
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Mercedes
    {

    }
    class SClass : Mercedes
    {

    }
    class SLS :SClass
    {

    }
    // Don't change any further
    sealed class SLSSport : SLS
    {

    }
}
