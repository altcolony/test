using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace PageToPage
{
    public class Class
    {
        static public int publicCount = 0;
    }

    public class JavaScriptInvokable
    {
        [JSInvokable]
        public static Task<string> myfunc()
        {
            return Task.FromResult("from C#");
        }
    }
}
