using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public abstract class Worker
    {
        private string fullName;
        private string idNumber;
        private DateTime birthDate;
        private string password;


        public Worker(string name, string id, DateTime bDate, string pass)
        {
            this.fullName = name;
            this.idNumber = id;
            this.birthDate = bDate;
            this.password = pass;
        }
        public string FullName { get { return fullName; }  set { fullName = value; } }
        //משימה 2
        //get כתבו פעולות מאחזרות 
        public string GetFullName()
        {
            return this.fullName;
        }
        public string GetIdNumber()
        {
            return this.idNumber;
        }
        public DateTime GetBirthDate()
        {
            return this.birthDate;
        }
        public string GetPassword()
        {
            return this.password;
        }
        public void SetFullName(string name)
        {
            this.fullName = name;
        }
        public void SetBirthData(DateTime bDate)
        {
            this.birthDate = bDate;
        }
        public void SetPassword(string pass)
        {
            this.password = pass;
        }
        
        public abstract int CalcSalary();

        public override string ToString()
        {
            string str = "";
            if(birthDate.Equals(DateTime.Today))
                str=" - HappyBirthDay";
            return fullName + " ID." + idNumber + str;

        }
    }
}
