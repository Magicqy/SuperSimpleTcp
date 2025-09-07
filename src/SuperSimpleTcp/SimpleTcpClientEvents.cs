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
        public Action<object, ConnectionEventArgs> Connected;

        /// <summary>
        /// Action to call when the connection is destroyed.
        /// </summary>
        public Action<object, ConnectionEventArgs> Disconnected;

        /// <summary>
        /// Action to call when byte data has become available from the server.
        /// </summary>
        public Action<object, DataReceivedEventArgs> DataReceived;

        /// <summary>
        /// Action to call when byte data has been sent to the server.
        /// </summary>
        public Action<object, DataSentEventArgs> DataSent;

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

        internal void HandleConnected(object sender, ConnectionEventArgs args)
        {
            Connected?.Invoke(sender, args);
        }

        internal void HandleClientDisconnected(object sender, ConnectionEventArgs args)
        {
            Disconnected?.Invoke(sender, args);
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
