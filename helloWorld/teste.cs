using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace helloWorld
{

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ProgId("hello.world")]
    public class teste
    {

        public teste() { }
        public string test()
        {
            return "Bruno Bixinha";
        }
        
    }
}
