using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Actions
    {
        public static Result A1()
        {
            Logger.Info();
            return new Result() {Status = true };
        }
        public static Result A2()
        {
            Logger.Warning();
            return new Result() { Status = true };
        }
        public static Result A3()
        {
            return new Result() { Status = false };
        }
    }
}
