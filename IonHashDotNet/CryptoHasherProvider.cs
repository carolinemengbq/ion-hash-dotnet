﻿namespace Amazon.IonHash
{
    public class CryptoHasherProvider : IIonHasherProvider
    {
        private readonly string algorithm;

        public CryptoHasherProvider(string algorithm)
        {
            this.algorithm = algorithm;
        }

        public IIonHasher NewHasher()
        {
            return new IonHasher(this.algorithm);
        }
    }
}
