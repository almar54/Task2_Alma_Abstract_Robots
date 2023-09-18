using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class OperationalWorker : Worker
    {
        protected int hourPayment;
        protected int workHours;

        public OperationalWorker(int hourPay, int workHours, string name, string id, DateTime bDate, string pass)
            : base(name, id, bDate, pass)
        {
            this.hourPayment = hourPay;
            this.workHours = workHours;
        }

        public override int CalcSalary()
        {
            return (this.workHours * this.hourPayment);
        }
        

    }
}
