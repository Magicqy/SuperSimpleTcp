namespace SuperSimpleTcp
{
    using System;

    /// <summary>
    /// Arguments for client-side connection events.
    /// </summary>
    public class ClientConnectionEventArgs : EventArgs
    {
        internal ClientConnectionEventArgs(string serverIpPort, DisconnectReason reason = DisconnectReason.None)
        {
            ServerIpPort = serverIpPort;
            Reason = reason;
        }

        /// <summary>
        /// The IP:port of the server.
        /// </summary>
        public string ServerIpPort { get; }

        /// <summary>
        /// The reason for the disconnection, if any.
        /// </summary>
        public DisconnectReason Reason { get; } = DisconnectReason.None;
    }

    /// <summary>
    /// Arguments for server-side connection events.
    /// </summary>
    public class ServerConnectionEventArgs : EventArgs
    {
        internal ServerConnectionEventArgs(Guid clientId, DisconnectReason reason = DisconnectReason.None)
        {
            ClientId = clientId;
            Reason = reason;
        }

        /// <summary>
        /// The unique identifier of the connected client.
        /// </summary>
        public Guid ClientId { get; }

        /// <summary>
        /// The reason for the disconnection, if any.
        /// </summary>
        public DisconnectReason Reason { get; } = DisconnectReason.None;
    }

    /// <summary>
    /// Arguments for connection events (legacy - use ClientConnectionEventArgs or ServerConnectionEventArgs).
    /// </summary>
    [Obsolete("Use ClientConnectionEventArgs or ServerConnectionEventArgs instead")]
    public class ConnectionEventArgs : EventArgs
    {
        internal ConnectionEventArgs(Guid clientId, DisconnectReason reason = DisconnectReason.None)
        {
            ClientId = clientId;
            Reason = reason;
        }

        /// <summary>
        /// The unique identifier of the connected client.
        /// </summary>
        public Guid ClientId { get; }

        /// <summary>
        /// The reason for the disconnection, if any.
        /// </summary>
        public DisconnectReason Reason { get; } = DisconnectReason.None;
    }
}