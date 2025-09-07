namespace SuperSimpleTcp
{
    using System;

    /// <summary>
    /// Arguments for connection events.
    /// </summary>
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