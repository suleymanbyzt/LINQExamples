// You can download ApiClient .net core complete library from github https://github.com/BTCTrader/broker-api-csharp-v2
using System;
using System.Net.WebSockets;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace HMAC
{
    public class Program
    {
        static void Main(string[] args)
        {
            HmacTest();

        }
        private static async Task HmacTest()
        {
            Uri _uri = new Uri("wss://ws-feed-pro.btcturk.com");
            ClientWebSocket client = new ClientWebSocket();
            await client.ConnectAsync(_uri, CancellationToken.None);

            string publicKey = "fa6ab239-4664-499b-84d0-17c790e23183";
            string privateKey = "vM0VNvr+PyGx9/AbMtHXBBE+SAKmMr7u";
            long nonce = 3000;
            string baseString = $"{publicKey}{nonce}";
            string signature = ComputeHash(privateKey, baseString);
            long timestamp = ToUnixTime(DateTime.UtcNow);
            object[] hmacMessageObject = { 114, new { type = 114, publicKey = publicKey, timestamp = timestamp, nonce = nonce, signature = signature } };
            string message = JsonSerializer.Serialize(hmacMessageObject);

            await client.SendAsync(buffer: new ArraySegment<byte>(array: Encoding.UTF8.GetBytes(message),
                    offset: 0,
                    count: message.Length),
                messageType: WebSocketMessageType.Text,
                endOfMessage: true,
                cancellationToken: CancellationToken.None);
        }

        private static string ComputeHash(string privateKey, string baseString)
        {
            var key = Convert.FromBase64String(privateKey);
            string hashString;

            using (var hmac = new HMACSHA256(key))
            {
                var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(baseString));
                hashString = Convert.ToBase64String(hash);
            }

            return hashString;
        }

        private static long ToUnixTime(DateTime date)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return Convert.ToInt64((date - epoch).TotalMilliseconds);
        }
    }
}



