using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace JinVoice.Dlls
{
    public static class ExternalDll
    {
        [DllImport("Kernel32.dll")] //引入命名空间 using System.Runtime.InteropServices;  
        public static extern bool Beep(int frequency, int duration);// 第一个参数是指频率的高低，越大越高，第二个参数是指响的时间多

    }
}
