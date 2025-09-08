namespace SuperSimpleTcp
{
    using System;

    /// <summary>
    /// Public information about a connected client.
    /// </summary>
    public class ClientInfo
    {
        /// <summary>
        /// The unique identifier for the client.
        /// </summary>
        public Guid ClientId { get; internal set; }

        /// <summary>
        /// The IP address and port number of the client.
        /// </summary>
        public string IpPort { get; internal set; }

        internal ClientInfo(Guid clientId, string ipPort)
        {
            ClientId = clientId;
            IpPort = ipPort;
        }
    }
}