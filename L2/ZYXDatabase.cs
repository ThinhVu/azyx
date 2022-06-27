using System.Runtime.CompilerServices;

namespace L2
{
    public class ZYXDatabase : L1.BaseDatabase
    {
        // http://www.ticklishtechs.net/2010/03/04/be-careful-when-using-getcallingassembly-and-always-use-the-release-build-for-testing/
        // This looks like such a innocent method but it lead to big trouble in one of my projects.
        // But lets start with when someone would use this method that is declared as a static method 
        // in the Assembly class. In the MSDN you can read:
        // Returns the Assembly of the method that invoked the currently executing method.
        // In our project we had an assembly with a lot of helper methods.
        // On of these gets resources from the calling assembly.
        // In various places of our code we called this method to get icons or other resources.
        // This method used exactly this GetCallingAssembly() method to figure out what assembly to look for resources.
        // That worked pretty good in debug mode but exceptions were thrown in release mode.
        // We could not understand what is going on. It became even worse: when we build a release 
        // version and tried to debug that version (using Visual Studio Debugger) in worked again.

        // It looked like a heisenbug.
        // It took us some time to figure out what is also written in MSDN:
        // If the method that calls the GetCallingAssembly method is expanded inline by the compiler 
        // (that is, if the compiler inserts the function body into the emitted 
        // Microsoft intermediate language (MSIL), rather than emitting a function call), 
        // then the assembly returned by the GetCallingAssembly method is the assembly containing 
        // the inline code. This might be different from the assembly that contains the original method. 

        // To ensure that a method that calls the GetCallingAssembly method is not inlined by the compiler, 
        // you can apply the MethodImplAttribute attribute with MethodImplOptions.NoInlining.
        // The JIT compiler moves code around to optimize for performance. Small methods 
        // (up to about 56 Byte IL-Code if I remember it right) can be inlined where the 
        // method call was before. But the compiler does this only in release, 
        // not in debug mode. Also when attaching the debugger to our release build the
        // JIT compiler stopped inlining to enable debugging and our bug was gone.

        // After understanding this, the fix is easy. Just don’t allow the compiler 
        // to inline that particular method that calls Assembly.GetCallingAssembly(). 
        // Then the method stays in the assembly where the source code is written and 
        // everything will be fine.

        [MethodImplAttribute(MethodImplOptions.NoInlining)]
        public ZYXDatabase(string dbSource, string dbName, string username, string password)
            : base (dbSource, dbName, username, password)
        {            
        }
    }
}
