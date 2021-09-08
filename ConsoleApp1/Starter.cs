using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Starter
    {
        private int _counter;

        public void Run()
        {
            for (int i = 0; i < 100; i++)
            {
                _counter = new Random().Next(1, 3);
                if(_counter==1)
                {
                   Actions.A1();
                }
                else if(_counter==2)
                {
                    Actions.A2();
                }
                else
                {
                    Actions.A3();
                }
            }
            Logger.WriteFile();
          }
    }
}
