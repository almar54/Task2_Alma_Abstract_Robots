using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    //כתבו את המחלקה על פי המחלקות הקודמות
    //שימו לב שעליכם להתייחס גם לתעופה
    class RobotFly : RobotSpy
    {
        public RobotFly() : base("RobotFly", DateTime.Now, 100)
        { }
        public override void MoveBackward()
        {
            for (int i = 0; i < 4; i++)
                this.MoveLeg(i, -1);
        }

        public override void MoveForward()
        {
            for (int i = 0; i < 4; i++)
                this.MoveLeg(i, 1);
        }

        public override void TurnLeft()
        {
            for (int i = 0; i < 4; i++)
                this.MoveLeg(-1, i);
        }

        public override void TurnRight()
        {
            for (int i = 0; i < 4; i++)
                this.MoveLeg(1, i);
        }

        private void MoveLeg(int legId, int dir)
        {
            SetBatteryStatus(GetBatteryStatus() - 2);
        }
        private void MoveWing(int wingId, int dir)
        {
            SetBatteryStatus(GetBatteryStatus() - 1.5);
        }
        private void FlyUp()
        {
            this.MoveWing(0, 1);
        }
        private void FlyDown()
        {
            this.MoveWing(0, -1);
        }
    }
}
