using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class GeneralManager : Worker
    {
        protected int monthPayment;
        protected int activeRobots;

        public GeneralManager(int activeRob, string name, string id, DateTime bDate, string pass, double monthlySalary)
            :base (name,id,bDate,pass)
        {
            this.monthPayment = 20000;
            this.activeRobots = activeRob;
        }

        public override int CalcSalary()
        {
            if (this.activeRobots > 30)
            {
                return (this.monthPayment + (this.monthPayment * 15 / 100));
            }
            return this.monthPayment;
        }

       

    }
}
