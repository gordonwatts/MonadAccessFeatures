namespace CommonObjects
{
    /// <summary>
    /// This is a Future or a Promise - a value that will be availible at some time in the future
    /// </summary>
    /// <remarks>
    /// As the code stands, it is meant to be a syntatic demo, not a working demo
    /// </remarks>
    public interface IFutureValue<T>
    {
        /// <summary>
        /// Returns the value. This is blocking - 
        ///   and perhaps for a very long time (hours!)
        /// </summary>
        T Value { get; }
    }
}
