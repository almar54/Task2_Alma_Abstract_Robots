using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class OperationManager : Worker
    {
        protected int hourPayment;
        protected int workHours;
        protected int completedTasks;

        public OperationManager(int hourPay, int workHours, int compTasks, string name, string id, DateTime bDate, string pass)
            : base(name, id, bDate, pass)
        {
            this.hourPayment = hourPay;
            this.workHours = workHours;
            this.completedTasks = compTasks;
        }

        public override int CalcSalary()
        {
            return ((this.workHours * this.hourPayment) + (this.hourPayment * 3 / 100));
        }

    }
}
