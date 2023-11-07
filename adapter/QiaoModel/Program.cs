using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QiaoModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20217124 黄英杰 桥接模式");
            RemoteControl remoteControl = new ConcreatRemote();
            remoteControl.T1 = new ChangHong();
            remoteControl.On();
            remoteControl.Off();
            remoteControl.SetChannel();
            Console.ReadLine();
        }
    }
    abstract class TV {
        public abstract void On();
        public abstract void Off();
        public abstract void SetChannel();
    }
    class ChangHong : TV
    {
        public override void Off()
        {
            Console.WriteLine("关闭长虹电视");
        }

        public override void On()
        {
            Console.WriteLine("开启长虹电视");
        }

        public override void SetChannel()
        {
            Console.WriteLine("切换频道长虹电视");
        }
    }
    class SanXing : TV
    {
        public override void Off()
        {
            Console.WriteLine("关闭三星电视");
        }

        public override void On()
        {
            Console.WriteLine("开启三星电视");
        }

        public override void SetChannel()
        {
            Console.WriteLine("切换频道三星电视");
        }
    }
    class RemoteControl{
        private TV T;
        private TV mtv;
       
        internal TV T1 { get => T; set => T = value; }

        public virtual void On()
        {
            T.On();
        }
        public virtual void Off()
        {
            T.Off();
        }
        public virtual void SetChannel()
        {
            T.SetChannel();
        }

    }
   class ConcreatRemote : RemoteControl
    {
        public override void SetChannel()
        {
            Console.WriteLine();
            base.SetChannel();
        }

    }
}
