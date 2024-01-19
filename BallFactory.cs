using System;

namespace IP59_Factory_Ball
{
    public interface BallFactory
    {
        SportsBall createBall();
    }

    public class SportsBallFactory : BallFactory
    {
        public SportsBall createBall()
        {
            SportsBall b = new SportsBall();
            b.type = "Basketball";
            b.materialsused = new String[3];
            b.materialsused[0] = "rubber";
            b.materialsused[1] = "fiber";
            b.materialsused[2] = "synthetic composite";
            b.radius = 4.8f;
            b.make = "Spalding";
            b.modelName = "Series Basketball";
            return b;
        }
    }

    public class SportsBall
    {
        // Define properties and methods for SportsBall class
        public string type;
        public string[] materialsused;
        public float radius;
        public string make;
        public string modelName;
        // Add any additional properties or methods as needed
    }
}

