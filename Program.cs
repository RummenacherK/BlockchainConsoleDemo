using System;
using NBitcoin;

namespace BlockchainConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Key privateKey = new Key(); // generate a random private key

            PubKey publicKey = privateKey.PubKey; // generate a random public key connected to private key
            Console.WriteLine(publicKey);  // display public key

            // Console.WriteLine(publicKey.GetAddress(Network.Main));
            Console.WriteLine(publicKey.GetAddress(Network.TestNet)); // display insecure blockchain address

            var publicKeyHash = publicKey.Hash; // generate a public key hash
            Console.WriteLine(publicKeyHash); // display public key hash
            // var mainNetAddress = publicKeyHash.GetAddress(Network.Main);
            var testNetAddress = publicKeyHash.GetAddress(Network.TestNet); // generate secure blockchain address

            // Console.WriteLine(mainNetAddress); 
            Console.WriteLine(testNetAddress); // display secure blockchain address

            Console.Read();
        }
    }
}
