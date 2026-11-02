using URCarmAppPhysicsClasses;
namespace ArmAnal
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            PistonLever Action = new PistonLever(
                0.25,
                0.45,
                0.1,
                1,
                0.5,
                10,
                98.1,
                10,
                10,
                1,
                100
                );
            System.Diagnostics.Debug.WriteLine("Ordering 66");
            Action.Order_66();
           Action.Solutions.Print();
        }
    }
}
