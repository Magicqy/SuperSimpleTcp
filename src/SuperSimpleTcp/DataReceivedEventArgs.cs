namespace SuperSimpleTcp
{
    using System;

    /// <summary>
    /// Arguments for data received from connected endpoints.
    /// </summary>
    public class DataReceivedEventArgs : EventArgs
    {
        internal DataReceivedEventArgs(Guid clientId, string ipPort, ArraySegment<byte> data)
        {
            ClientId = clientId;
            IpPort = ipPort;
            Data = data;
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
        /// The data received from the endpoint.
        /// </summary>
        public ArraySegment<byte> Data { get; }
    }
}