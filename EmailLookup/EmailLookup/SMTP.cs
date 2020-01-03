using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Net;

namespace EmailLookup
{
    public interface IEnums
    {
        public enum Secure { TLS, SSL};
    }
    public class SMTP
    {
        public string Address { get; set; }
        public int Port { get; set; }
        public IEnums.Secure Security { get; set; }
        public string Username { get; set; }

    }
    public class POP3
    {
        public string Address { get; set; }
        public int Port { get; set; }
        public IEnums.Secure Security { get; set; }
        public string Username { get; set; }

    }
    public class IMAP
    {
        public string Address { get; set; }
        public int Port { get; set; }
        public IEnums.Secure Security { get; set; }
        public string Username { get; set; }

    }
}
