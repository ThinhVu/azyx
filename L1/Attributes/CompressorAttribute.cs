using System;

namespace L1.Attributes
{
    /// <summary>
    /// Mark a property as a field should be compress/decompress while working with database
    /// OMG this should lead to a lot of bugs
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public class CompressorAttribute : Attribute
    {
        public Type CompressorType;
        public CompressorAttribute(Type compressorType)
        {
            CompressorType = compressorType;
        }
    }
}
