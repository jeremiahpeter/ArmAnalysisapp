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
        
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            //double MaxActuatorLength, double MinActuatorLength, double ArmLength, double ArmConnectLength, double Height, double offset, int iterations, double appliedforce, double armweight, double accel, double actuatorWeight
            

        }
    }
}
