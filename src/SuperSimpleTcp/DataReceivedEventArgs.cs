namespace SuperSimpleTcp
{
    using System;

    /// <summary>
    /// Arguments for data received from connected endpoints.
    /// </summary>
    public class DataReceivedEventArgs : EventArgs
    {
        internal DataReceivedEventArgs(Guid clientId, ArraySegment<byte> data)
        {
            ClientId = clientId;
            Data = data;
        }

        /// <summary>
        /// The unique identifier of the connected client.
        /// </summary>
        public Guid ClientId { get; }

        /// <summary>
        /// The data received from the endpoint.
        /// </summary>
        public ArraySegment<byte> Data { get; }
    }
}