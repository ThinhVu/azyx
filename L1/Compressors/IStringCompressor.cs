using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L1.Compressors
{
    public interface IStringCompressor : ICompressor
    {
        string Compress(string input);
        string Decompress(string input);
    }    
}
