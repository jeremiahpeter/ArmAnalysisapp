using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ArmAnal
{
    internal class CPPCallables{


        // returns the max force required by the linear atuator at any of its positions. 
        [DllImport(@"C:\Users\sheburbingurbin.attmpt2\Desktop\Jemonium\06- code\ArmAnalysis_Folder\ArmAnal\x64\Debug\armanaldll.dll", EntryPoint = "getMaxForce", CallingConvention = CallingConvention.Cdecl)]
        public static extern double getMaxForce(double MaxActuatorLength, double MinActuatorLength, double ArmLength, double ArmConnectLength, double Height, double offset, int iterations, double appliedforce, double armweight, double accel, double actuatorWeight);




        [DllImport(@"C:\Users\sheburbingurbin.attmpt2\Desktop\Jemonium\06- code\ArmAnalysis_Folder\ArmAnal\x64\Debug\armanaldll.dll", EntryPoint = "aaaa", CallingConvention = CallingConvention.Cdecl)]

    }
}
