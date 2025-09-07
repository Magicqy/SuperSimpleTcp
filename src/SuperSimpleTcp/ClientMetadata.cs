namespace SuperSimpleTcp
{
    using System;
    using System.Net.Security;
    using System.Net.Sockets;
    using System.Threading;

    /// <summary>
    /// Client metadata including connection details.
    /// </summary>
    public class ClientMetadata : IDisposable
    {
        #region Public-Members

        /// <summary>
        /// The underlying TCP client.
        /// </summary>
        public TcpClient Client
        {
            get { return _tcpClient; }
        }
         
        /// <summary>
        /// The network stream for the client.
        /// </summary>
        public NetworkStream NetworkStream
        {
            get { return _networkStream; }
        }

        /// <summary>
        /// The SSL stream for the client (if SSL is enabled).
        /// </summary>
        public SslStream SslStream
        {
            get { return _sslStream; }
            set { _sslStream = value; }
        }

        /// <summary>
        /// The unique identifier for the client.
        /// </summary>
        public Guid ClientId
        {
            get { return _clientId; }
        }

        /// <summary>
        /// The IP address and port number of the client.
        /// </summary>
        public string IpPort
        {
            get { return _ipPort; }
        }

        internal SemaphoreSlim SendLock = new SemaphoreSlim(1, 1);
        internal SemaphoreSlim ReceiveLock = new SemaphoreSlim(1, 1);

        internal CancellationTokenSource TokenSource { get; set; }

        internal CancellationToken Token { get; set; }

        #endregion

        #region Private-Members
         
        private TcpClient _tcpClient = null;
        private NetworkStream _networkStream = null;
        private SslStream _sslStream = null;
        private Guid _clientId = Guid.NewGuid();
        private string _ipPort = null; 

        #endregion

        #region Constructors-and-Factories

        internal ClientMetadata(System.Net.Sockets.TcpClient tcp)
        {
            if (tcp == null) throw new ArgumentNullException(nameof(tcp));

            _tcpClient = tcp;
            _networkStream = tcp.GetStream();
            _ipPort = tcp.Client.RemoteEndPoint.ToString();
            TokenSource = new CancellationTokenSource();
            Token = TokenSource.Token;
        }

        #endregion

        #region Public-Methods

        /// <summary>
        /// Dispose of the client metadata and associated resources.
        /// </summary>
        public void Dispose()
        { 
            if (TokenSource != null)
            {
                if (!TokenSource.IsCancellationRequested)
                {
                    TokenSource.Cancel();
                    TokenSource.Dispose();
                }
            }

            if (_sslStream != null)
            {
                _sslStream.Close(); 
            }

            if (_networkStream != null)
            {
                _networkStream.Close(); 
            }

            if (_tcpClient != null)
            {
                _tcpClient.Close();
                _tcpClient.Dispose(); 
            }

            SendLock.Dispose();
            ReceiveLock.Dispose();
        }

        #endregion
    }
}
