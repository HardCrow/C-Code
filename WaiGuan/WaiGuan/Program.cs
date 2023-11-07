using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaiGuan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20217124 黄英杰 外观模式");
            RegisterationFacade facade = new RegisterationFacade();
            facade.Register("张三","设计模式");
            Console.ReadKey();
        }
        class RegisterationFacade {

            private RegisterCouse registerCouse;
            private NotifyStudent notifyStudent;
            public RegisterationFacade(){
                registerCouse = new RegisterCouse();
                notifyStudent = new NotifyStudent();
                }
            public void Register(string studentName,string courseName)
            {
                if (registerCouse.CheckAvailable(courseName))
                {
                    notifyStudent.Notify(studentName);
                }
                else
                {

                }
            }
        }
        class RegisterCouse {
            public bool CheckAvailable(String courseName) {
                Console.WriteLine("正在验证{0}选课人数是否已经满了",courseName);
                return true;
            } 
        }
        class NotifyStudent {
            public void Notify(String studentname)
            {
                Console.WriteLine("正在向{0}发送结果",studentname);
            }
        }
    }
}
