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
    public class Requests
    {
        public static SMTP getSMTP(string Email)
        {
            SMTP smtp = new SMTP();
            smtp.Address = "Not Found";
            try
            {
                string html = string.Empty;
                string url = $"https://emailsettings.firetrust.com/settings?q={Email}";

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.AutomaticDecompression = DecompressionMethods.GZip;

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    html = reader.ReadToEnd();
                }
                if (html.Contains("Not Found"))
                {
                    return smtp;
                }
                else
                {
                    Match match = Regex.Match(html, @"""protocol"":""SMTP"",""address"":""(.*?)"",""port"":(\d+),""secure"":""(.*?)"",""username"":""(.*?)""");
                    if (match.Groups[0].Value == "" || match.Groups[0].Value == null)
                        return smtp;
                    smtp.Address = match.Groups[1].Value;
                    smtp.Port = Convert.ToInt32(match.Groups[2].Value);
                    smtp.Security = (IEnums.Secure)Enum.Parse(typeof(IEnums.Secure), match.Groups[3].Value, true);
                    smtp.Username = match.Groups[4].Value;
                    return smtp;
                }
            }
            catch
            {
                return smtp;
            }
        }
        public static POP3 getPOP3(string Email)
        {
            POP3 pop3 = new POP3();
            pop3.Address = "Not Found";
            try
            {
                string html = string.Empty;
                string url = $"https://emailsettings.firetrust.com/settings?q={Email}";

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.AutomaticDecompression = DecompressionMethods.GZip;

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    html = reader.ReadToEnd();
                }
                if (html.Contains("Not Found"))
                {
                    return pop3;
                }
                else
                {
                    Match match = Regex.Match(html, @"""protocol"":""POP3"",""address"":""(.*?)"",""port"":(\d+),""secure"":""(.*?)"",""username"":""(.*?)""");
                    if (match.Groups[0].Value == "" || match.Groups[0].Value == null)
                        return pop3;
                    pop3.Address = match.Groups[1].Value;
                    pop3.Port = Convert.ToInt32(match.Groups[2].Value);
                    pop3.Security = (IEnums.Secure)Enum.Parse(typeof(IEnums.Secure), match.Groups[3].Value, true);
                    pop3.Username = match.Groups[4].Value;
                    return pop3;
                }
            }
            catch
            {
                return pop3;
            }
        }
        public static IMAP getIMAP(string Email)
        {
            IMAP imap = new IMAP();
            imap.Address = "Not Found";
            try
            {
                string html = string.Empty;
                string url = $"https://emailsettings.firetrust.com/settings?q={Email}";

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.AutomaticDecompression = DecompressionMethods.GZip;

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    html = reader.ReadToEnd();
                }
                if (html.Contains("Not Found"))
                {
                    return imap;
                }
                else
                {
                    Match match = Regex.Match(html, @"""protocol"":""IMAP"",""address"":""(.*?)"",""port"":(\d+),""secure"":""(.*?)"",""username"":""(.*?)""");
                    if (match.Groups[0].Value == "" || match.Groups[0].Value == null)
                        return imap;
                    imap.Address = match.Groups[1].Value;
                    imap.Port = Convert.ToInt32(match.Groups[2].Value);
                    imap.Security = (IEnums.Secure)Enum.Parse(typeof(IEnums.Secure), match.Groups[3].Value, true);
                    imap.Username = match.Groups[4].Value;
                    return imap;
                }
            }
            catch
            {
                return imap;
            }
        }
    }
}
