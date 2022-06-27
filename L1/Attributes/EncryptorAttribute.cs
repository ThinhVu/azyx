using L1.Encryptors;
using System;

namespace L1.Attributes
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public class EncryptorAttribute : Attribute
    {
        public IEncryptor Encryptor { get; set; }
        public EncryptorAttribute(IEncryptor encryptor)
        {
            Encryptor = encryptor;
        }
    }
}
