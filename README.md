# EmailLookup
This library makes it easy to find the SMTP, POP3, and IMAP servers (when available) for any email address.


This library uses the Firetrust API and is compatible with .NET languages.


The library has a few different classes that all operate in the same way.
The classes are SMTP, POP3, and IMAP and they all have four properties.<br/>
Address - String<br/>
Port - Integer<br/>
Security - Enum (TLS, SSL)<br/>
Username - String<br/>
The library also contains three methods (contained in the Requests class), which return their respective classes. 
They all function in the same way.<br/>
getSMTP(Email)<br/>
getPOP3(Email)<br/>
getIMAP(Email)<br/>
  
I hope you are able to make use of this library for any .NET projects requiring mail servers.
