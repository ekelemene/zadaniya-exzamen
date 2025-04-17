using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac37._4
{
    class Human: ISpeakable, IThinkable
    {
        public void Think()
        {
            Console.WriteLine("Думает — А C# больше всего");
        }
         public void Speak1()
        {
            Console.WriteLine("Говорит кромко — Я люблю программирование!");
        }
        public void Speak2()
        {
            Console.WriteLine("Говорит нормально — А игры меньше всего");
        }
    }
}
