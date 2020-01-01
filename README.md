# EmailLookup
This library makes it easy to find the SMTP, POP3, and IMAP servers (when available) for any email address.


This library uses the Firetrust API and is compatible with .NET languages.


The library has a few different classes that all operate in the same way.
The classes are SMTP, POP3, and IMAP and they all have four properties.
  Address - String
  Port - Integer
  Security - Enum (TLS, SSL)
  Username - String
The library also contains three methods (contained in the Requests class), which return their respective classes. 
They all function in the same way.
  getSMTP(Email)
  getPOP3(Email)
  getIMAP(Email)
  
I hope you are able to make use of this library for any .NET projects requiring mail servers.
