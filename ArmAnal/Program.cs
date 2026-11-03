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
        [DllImport("ArmAnal.dll", EntryPoint = "Check", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Check();
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            Check();
            
        }

        

    }
}
