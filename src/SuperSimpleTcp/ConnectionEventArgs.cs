namespace SuperSimpleTcp
{
    using System;

    /// <summary>
    /// Arguments for connection events.
    /// </summary>
    public class ConnectionEventArgs : EventArgs
    {
        internal ConnectionEventArgs(Guid clientId, string ipPort, DisconnectReason reason = DisconnectReason.None)
        {
            ClientId = clientId;
            IpPort = ipPort;
            Reason = reason;
        }

        /// <summary>
        /// The unique identifier of the connected client.
        /// </summary>
        public Guid ClientId { get; }

        /// <summary>
        /// The IP address and port number of the connected peer socket.
        /// </summary>
        public string IpPort { get; }

        /// <summary>
        /// The reason for the disconnection, if any.
        /// </summary>
        public DisconnectReason Reason { get; } = DisconnectReason.None;
    }
}