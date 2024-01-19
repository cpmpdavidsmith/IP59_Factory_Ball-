using System;

namespace IP59_Factory_Ball
{
    public class BaseballMaker : BallFactory
    {
        public SportsBall createBall()
        {
            SportsBall b = new SportsBall();
            b.type = "Baseball";
            b.materialsused = new string[6];
            b.materialsused[0] = "cork";
            b.materialsused[1] = "wool";
            b.materialsused[2] = "poly/cotton";
            b.materialsused[3] = "cowhide";
            b.materialsused[4] = "yarn";
            b.materialsused[5] = "composite rubber";
            b.radius = 1.45f;
            b.make = "Rawlings";
            b.modelName = "MLB Official Baseball";
            return b;
        }
    }
}
