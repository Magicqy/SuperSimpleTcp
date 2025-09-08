namespace SuperSimpleTcp
{
    using System;

    /// <summary>
    /// SimpleTcp server events.
    /// </summary>
    public class SimpleTcpServerEvents
    {
        #region Public-Members

        /// <summary>
        /// Action to call when a client connects.
        /// </summary>
        public Action<SimpleTcpServer, ServerConnectionEventArgs> ClientConnected;

        /// <summary>
        /// Action to call when a client disconnects.
        /// </summary>
        public Action<SimpleTcpServer, ServerConnectionEventArgs> ClientDisconnected;

        /// <summary>
        /// Action to call when byte data has become available from the client.
        /// </summary>
        public Action<SimpleTcpServer, DataReceivedEventArgs> DataReceived;

        /// <summary>
        /// Action to call when byte data has been sent to a client.
        /// </summary>
        public Action<SimpleTcpServer, DataSentEventArgs> DataSent;

        #endregion

        #region Constructors-and-Factories

        /// <summary>
        /// Instantiate the object.
        /// </summary>
        public SimpleTcpServerEvents()
        {

        }

        #endregion

        #region Public-Methods

        internal void HandleClientConnected(SimpleTcpServer sender, ServerConnectionEventArgs args)
        {
            ClientConnected?.Invoke(sender, args);
        }

        internal void HandleClientDisconnected(SimpleTcpServer sender, ServerConnectionEventArgs args)
        {
            ClientDisconnected?.Invoke(sender, args);
        }

        internal void HandleDataReceived(SimpleTcpServer sender, DataReceivedEventArgs args)
        {
            DataReceived?.Invoke(sender, args);
        }

        internal void HandleDataSent(SimpleTcpServer sender, DataSentEventArgs args)
        {
            DataSent?.Invoke(sender, args);
        }

        #endregion
    }
}
