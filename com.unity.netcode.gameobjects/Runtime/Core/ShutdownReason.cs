namespace Unity.Netcode
{
    public enum ShutdownReason
    {
        Unknown,
        UserDisconnect,
        DisconnectEvent,
        TransportFailure,
        ConnectionNotApproved,
        ConnectionTimedOut,
        ApplicationQuit,
    }
}
