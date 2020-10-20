using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P2P.Model
{
    public class Peer
    {
        private string _fileName;
        private string _iPAddress;
        private int _portNumber;

        public Peer()
        {

        }

        public Peer(string fileName, string iPAddress, int portNumber)
        {
            _fileName = fileName;
            _iPAddress = iPAddress;
            _portNumber = portNumber;
        }

        public string FileName
        {
            get => _fileName;
            set
            {
                _fileName = value;
            }
        }

        public string IPAddress
        {
            get => _iPAddress;
            set
            {
                _iPAddress = value;
            }
        }

        public int PortNumber
        {
            get => _portNumber;
            set
            {
                _portNumber = value;
            }
        }

        public override string ToString()
        {
            return
                $"{nameof(FileName)}: {FileName}, {nameof(IPAddress)}: {IPAddress}, {nameof(PortNumber)}: {PortNumber}";
        }
    }
}
