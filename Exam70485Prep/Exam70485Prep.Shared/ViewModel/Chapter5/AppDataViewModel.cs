using System;
using System.Collections.Generic;
using System.Text;
using Windows.Security.Cryptography;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;

namespace Exam70485Prep.ViewModel.Chapter5
{
    public class AppDataViewModel : BaseViewModel
    {
        private String _messageToHash;

        public String MessageToHash
        {
            get { return _messageToHash; }
            set
            {
                _messageToHash = value;
                NotifyPropertyChanged("MessageToHash");
            }
        }

        private String _hashedMessage;

        public String HashedMessage
        {
            get { return _hashedMessage; }
            set
            {
                _hashedMessage = value;
                NotifyPropertyChanged("HashedMessage");
            }
        }

        private String _randomNumber;

        public String RandomNumber
        {
            get { return _randomNumber; }
            set
            {
                _randomNumber = value;
                NotifyPropertyChanged("RandomNumber");
            }
        }

        private String _randomData;

        public String RandomData
        {
            get { return _randomData; }
            set
            {
                _randomData = value;
                NotifyPropertyChanged("RandomData");
            }
        }

        public AppDataViewModel()
        {
            MessageToHash = "sample message";
        }

        public void HashMessage()
        {
            String hashAlgorithmName = HashAlgorithmNames.Sha512;
            IBuffer binaryMessage = CryptographicBuffer.ConvertStringToBinary(MessageToHash, BinaryStringEncoding.Utf8);
            HashAlgorithmProvider hashProvider = HashAlgorithmProvider.OpenAlgorithm(hashAlgorithmName);
            IBuffer hashedMessage = hashProvider.HashData(binaryMessage);
            if (hashedMessage.Length != hashProvider.HashLength)
            {
                HashedMessage = "There was an error creating the hash";
            }
            else
            {
                HashedMessage = CryptographicBuffer.EncodeToBase64String(hashedMessage);
            }
        }

        public void GenerateRandom()
        {
            RandomNumber = CryptographicBuffer.GenerateRandomNumber().ToString();
        }

        public void GenerateRandomData()
        {
            UInt32 length = 32;
            IBuffer rndData = CryptographicBuffer.GenerateRandom(length);
            RandomData = CryptographicBuffer.EncodeToHexString(rndData);
        }
    }
}
