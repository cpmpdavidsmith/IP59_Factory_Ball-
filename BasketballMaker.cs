using System;
namespace IP59_Factory_Ball
{
	public class BasketballMaker : BallFactory
	{
		SportsBall BallFactory.createBall()
		{
			SportsBall b = new SportsBall();
			b.type = "Basketball";
			b.materialsused = new string[3];
			b.materialsused[0] = "rubber";
			b.materialsused[1] = "fiber";
			b.materialsused[2] = "synthetic composite";
			b.radius = 4.8f;
			b.make = "Spalding";
			b.modelName = "Series Basketball";
			return b;

		}
	}
}

