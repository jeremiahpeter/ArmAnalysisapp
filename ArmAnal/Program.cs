using URCarmAppPhysicsClasses;
using System.Runtime.InteropServices;

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
            Check();
            


        }

        [DllImport("ArmAnal.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Check() ; 




    }
}
