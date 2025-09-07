namespace SuperSimpleTcp
{
    using System;

    /// <summary>
    /// Arguments for data sent to a connected endpoint.
    /// </summary>
    public class DataSentEventArgs : EventArgs
    {
        internal DataSentEventArgs(Guid clientId, string ipPort, long bytesSent)
        {
            ClientId = clientId;
            IpPort = ipPort;
            BytesSent = bytesSent;
        }

        /// <summary>
        /// The unique identifier of the connected client.
        /// </summary>
        public Guid ClientId { get; }

        /// <summary>
        /// The IP address and port number of the connected endpoint.
        /// </summary>
        public string IpPort { get; }

        /// <summary>
        /// The number of bytes sent.
        /// </summary>
        public long BytesSent { get; }
    }
}