namespace SuperSimpleTcp
{
    using System;

    /// <summary>
    /// SimpleTcp client events.
    /// </summary>
    public class SimpleTcpClientEvents
    {
        #region Public-Members

        /// <summary>
        /// Action to call when the connection is established.
        /// </summary>
        public Action<SimpleTcpClient, ClientConnectionEventArgs> Connected;

        /// <summary>
        /// Action to call when the connection is destroyed.
        /// </summary>
        public Action<SimpleTcpClient, ClientConnectionEventArgs> Disconnected;

        /// <summary>
        /// Action to call when byte data has become available from the server.
        /// </summary>
        public Action<SimpleTcpClient, DataReceivedEventArgs> DataReceived;

        /// <summary>
        /// Action to call when byte data has been sent to the server.
        /// </summary>
        public Action<SimpleTcpClient, DataSentEventArgs> DataSent;

        #endregion

        #region Constructors-and-Factories

        /// <summary>
        /// Instantiate the object.
        /// </summary>
        public SimpleTcpClientEvents()
        {

        }

        #endregion

        #region Public-Methods

        internal void HandleConnected(SimpleTcpClient sender, ClientConnectionEventArgs args)
        {
            Connected?.Invoke(sender, args);
        }

        internal void HandleClientDisconnected(SimpleTcpClient sender, ClientConnectionEventArgs args)
        {
            Disconnected?.Invoke(sender, args);
        }

        internal void HandleDataReceived(SimpleTcpClient sender, DataReceivedEventArgs args)
        {
            DataReceived?.Invoke(sender, args);
        }

        internal void HandleDataSent(SimpleTcpClient sender, DataSentEventArgs args)
        {
            DataSent?.Invoke(sender, args);
        }

        #endregion
    }
}
