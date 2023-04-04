using System.Net;

namespace PaoloCattaneo.UsefulExtensions;

public static class IPAddressExtensions
{
    public static IPAddress Next(this IPAddress ipAddress, uint increment = 1)
    {
        if (ipAddress == null)
        {
            throw new ArgumentNullException(nameof(ipAddress));
        }

        byte[] addressBytes = ipAddress.GetAddressBytes().Reverse().ToArray();
        uint ipAsUint = BitConverter.ToUInt32(addressBytes, 0);
        var nextAddress = BitConverter.GetBytes(ipAsUint + increment);
        return IPAddress.Parse(string.Join(".", nextAddress.Reverse()));
    }
}
