using System.Security.Cryptography;
using System.Text;

namespace CryptoGate;

public static class Webhook
{
    /// <summary>
    /// Verify the HMAC-SHA256 signature on an incoming CryptoGate webhook.
    /// </summary>
    /// <param name="secret">Your webhook secret from the CryptoGate dashboard.</param>
    /// <param name="rawBody">The raw, unparsed request body bytes.</param>
    /// <param name="signature">The value of the X-CryptoGate-Signature header.</param>
    public static bool Verify(string secret, byte[] rawBody, string signature)
    {
        if (string.IsNullOrEmpty(secret) || rawBody is null || string.IsNullOrEmpty(signature))
            return false;

        var received = signature.StartsWith("sha256=") ? signature[7..] : signature;
        var key      = Encoding.UTF8.GetBytes(secret);

        using var hmac = new HMACSHA256(key);
        var expected   = Convert.ToHexString(hmac.ComputeHash(rawBody)).ToLowerInvariant();

        return CryptographicOperations.FixedTimeEquals(
            Encoding.UTF8.GetBytes(expected),
            Encoding.UTF8.GetBytes(received.ToLowerInvariant())
        );
    }
}
