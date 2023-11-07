using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySec
{
   abstract class Builder
    {
       
        abstract public void BuildPartCPU();
        abstract public void BuildPartMainBoard();
        abstract public Computer GetComputer();


    }
}
