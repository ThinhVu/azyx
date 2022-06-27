namespace L1.Encryptors
{
    interface IStringEncryptor
    {
        string Encrypt(string input);
        string Decrypt(string input);
    }
}
