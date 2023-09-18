using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class RobotWheels : RobotSpy
    {
        public RobotWheels() : base("Spyke", DateTime.Now, 100) { } 

        public override void MoveForward()
        {
            this.TurnWheels(1, 1);
        }
        public override void TurnRight()
        {
            this.TurnWheels(-1, 0);
        }
        //השלימו את הפעולות החסרות מתוך המצגת או על הבנתכם

        private void TurnWheels(int rightDir, int leftDir)
        {
            SetBatteryStatus(GetBatteryStatus() - 4.5); 
        }

        public void WaveHands()
        {
            SetBatteryStatus(GetBatteryStatus() - 2);
        }

        public override void MoveBackward()
        {
            this.TurnWheels(1, 1);
        }

        public override void TurnLeft()
        {
            this.TurnWheels(0, -1);
        }
    }
}
