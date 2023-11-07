using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySec
{
    class CreateBuiler : Builder
    {
        Computer computer = new Computer();
        public override void BuildPartCPU()
        {
            computer.Add("CPU01");
        }

        public override void BuildPartMainBoard()
        {
            computer.Add("主板1");
        }

        public override Computer GetComputer()
        {
            return computer;
        }
    }
}
