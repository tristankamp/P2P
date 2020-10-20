using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P2P.Model
{
    public class Peer
    {

        private string _iPAddress;
        private int _portNumber;

        public Peer()
        {

        }

        public Peer(string iPAddress, int portNumber)
        {
            _iPAddress = iPAddress;
            _portNumber = portNumber;
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
                $"{nameof(IPAddress)}: {IPAddress}, {nameof(PortNumber)}: {PortNumber}";
        }
    }
}
