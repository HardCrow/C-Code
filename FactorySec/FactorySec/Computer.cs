using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySec
{
    class Computer
    {
        //声明时必须new  list

        private List<String> parts = new List<String>();
        public void Add(String partStr)
        {
            parts.Add(partStr);
        }
        public void Show()
        {
            Console.WriteLine("开始组装");
            foreach (var item in parts)
            {
                Console.WriteLine("组件{0}完成安装", item);

            }
            Console.WriteLine("电脑组装完成");

        }
    }
}
