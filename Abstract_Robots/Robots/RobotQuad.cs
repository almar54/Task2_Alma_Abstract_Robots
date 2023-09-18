using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class RobotQuad : RobotSpy
    {
        public RobotQuad() : base("Roboquad", DateTime.Now, 100)
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
            SetBatteryStatus(GetBatteryStatus() - 3);
        }
    }

}
