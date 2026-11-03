using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Runtime.InteropServices;
using URCarmAppPhysicsClasses;

namespace ArmAnal
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        [DllImport(@"C:\Users\sheburbingurbin.attmpt2\Desktop\Jemonium\06- code\ArmAnalysis_Folder\ArmAnal\x64\Debug\armanaldll.dll", EntryPoint = "do_cpp", CallingConvention = CallingConvention.Cdecl)]
        public static extern double do_cpp(double MaxActuatorLength, double MinActuatorLength, double ArmLength, double ArmConnectLength, double Height, double offset, int iterations, double appliedforce, double armweight, double accel, double actuatorWeight);
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            //double MaxActuatorLength, double MinActuatorLength, double ArmLength, double ArmConnectLength, double Height, double offset, int iterations, double appliedforce, double armweight, double accel, double actuatorWeight
            double max = do_cpp(0.42, 0.24, 1, 0.5, 0.3, 0.1, 100, 17, 5, 0.5, 5);

            System.Diagnostics.Debug.WriteLine($"Force {max}");
        }

        

    }
}
