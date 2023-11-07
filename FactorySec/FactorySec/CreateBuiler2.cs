using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySec
{
    class CreateBuiler2 : Builder
    {
        Computer computer = new Computer();
        public override void BuildPartCPU()
        {
            computer.Add("CPU02");
        }

        public override void BuildPartMainBoard()
        {
            computer.Add("主板2");
        }

        public override Computer GetComputer()
        {
            return computer;
        }
    }
}
