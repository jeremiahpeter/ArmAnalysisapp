using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ArmAnal
{
    internal class CPPCallables{

        
        // returns the max force required by the linear atuator at any of its positions. 
        [DllImport(@"C:\Users\sheburbingurbin.attmpt2\Desktop\Jemonium\06- code\ArmAnalysis_Folder\ArmAnal\x64\Debug\armanaldll.dll", EntryPoint = "check", CallingConvention = CallingConvention.Cdecl)]
        public static extern double check();


        



    }
}
