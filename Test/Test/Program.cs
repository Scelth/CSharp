using System;
using System.IO;
using System.Net;

string logFilePath = args[0];
string outputFilePath = args[1];
IPAddress addressStart = IPAddress.Parse(args[2]);
int addressMask = int.Parse(args[3]);
DateTime timeStart = DateTime.ParseExact(args[4], "dd.MM.yyyy", null);
DateTime timeEnd = DateTime.ParseExact(args[5], "dd.MM.yyyy", null);

using (StreamReader reader = new StreamReader(logFilePath))
{
    using (StreamWriter writer = new StreamWriter(outputFilePath))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            string[] parts = line.Split(':');
            IPAddress address = IPAddress.Parse(parts[0]);
            DateTime time = DateTime.ParseExact(parts[1], "yyyy-MM-dd HH:mm:ss", null);

            if (address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork &&
                address.GetAddressBytes()[0] >= addressStart.GetAddressBytes()[0] &&
                address.GetAddressBytes()[0] <= addressMask &&
                time >= timeStart &&
                time <= timeEnd)
            {
                writer.WriteLine(line);
            }
        }
    }
}