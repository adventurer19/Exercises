using System;

namespace Box
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            try
            {
                var nwbox = new Box(a, b, c);
                Console.WriteLine($"Surface Area - {nwbox.SurfaceArea():f2}");
                Console.WriteLine($"Lateral Surface Area - {nwbox.LateralSurfaceArea():f2}");
                Console.WriteLine($"Volume - {nwbox.Volume():f2}");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
