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
        public Action<object, ConnectionEventArgs> ClientConnected;

        /// <summary>
        /// Action to call when a client disconnects.
        /// </summary>
        public Action<object, ConnectionEventArgs> ClientDisconnected;

        /// <summary>
        /// Action to call when byte data has become available from the client.
        /// </summary>
        public Action<object, DataReceivedEventArgs> DataReceived;

        /// <summary>
        /// Action to call when byte data has been sent to a client.
        /// </summary>
        public Action<object, DataSentEventArgs> DataSent;

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

        internal void HandleClientConnected(object sender, ConnectionEventArgs args)
        {
            ClientConnected?.Invoke(sender, args);
        }

        internal void HandleClientDisconnected(object sender, ConnectionEventArgs args)
        {
            ClientDisconnected?.Invoke(sender, args);
        }

        internal void HandleDataReceived(object sender, DataReceivedEventArgs args)
        {
            DataReceived?.Invoke(sender, args);
        }

        internal void HandleDataSent(object sender, DataSentEventArgs args)
        {
            DataSent?.Invoke(sender, args);
        }

        #endregion
    }
}
