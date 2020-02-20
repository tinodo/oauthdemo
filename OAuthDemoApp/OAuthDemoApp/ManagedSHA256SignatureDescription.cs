namespace OAuthDemoApp
{
    using System;
    using System.Security.Cryptography;

    public class ManagedSHA256SignatureDescription : SignatureDescription
    {
        public ManagedSHA256SignatureDescription()
        {
            KeyAlgorithm = typeof(RSACryptoServiceProvider).FullName;
            DigestAlgorithm = typeof(SHA256Managed).FullName;
        }

        public override AsymmetricSignatureDeformatter CreateDeformatter(AsymmetricAlgorithm key)
        {
            if (key == null)
                throw new ArgumentNullException(nameof(key));

            var deformatter = new RSAPKCS1SignatureDeformatter(key);
            deformatter.SetHashAlgorithm(typeof(SHA256Managed).FullName);
            return deformatter;
        }

        public override AsymmetricSignatureFormatter CreateFormatter(AsymmetricAlgorithm key)
        {
            if (key == null)
                throw new ArgumentNullException(nameof(key));

            var provider = (RSACryptoServiceProvider)key;
            var cspParams = new CspParameters();
            cspParams.ProviderType = 24;
            cspParams.KeyContainerName = provider.CspKeyContainerInfo.KeyContainerName;
            cspParams.KeyNumber = (int)provider.CspKeyContainerInfo.KeyNumber;
            if (provider.CspKeyContainerInfo.MachineKeyStore)
                cspParams.Flags = CspProviderFlags.UseMachineKeyStore;

            cspParams.Flags |= CspProviderFlags.UseExistingKey;
            provider = new RSACryptoServiceProvider(cspParams);
            var formatter = new RSAPKCS1SignatureFormatter(provider);
            formatter.SetHashAlgorithm(typeof(SHA256Managed).FullName);
            return formatter;
        }
    }
}
