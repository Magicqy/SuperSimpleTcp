namespace SuperSimpleTcp
{
    using System;

    /// <summary>
    /// Arguments for data sent to a connected endpoint.
    /// </summary>
    public class DataSentEventArgs : EventArgs
    {
        internal DataSentEventArgs(Guid clientId, long bytesSent)
        {
            ClientId = clientId;
            BytesSent = bytesSent;
        }

        /// <summary>
        /// The unique identifier of the connected client.
        /// </summary>
        public Guid ClientId { get; }

        /// <summary>
        /// The number of bytes sent.
        /// </summary>
        public long BytesSent { get; }
    }
}