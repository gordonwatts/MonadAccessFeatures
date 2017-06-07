using System;

namespace CommonObjects
{
    public static class FutureUtils
    {
        /// <summary>
        /// Dummy that will "kick" off a future calculation.
        /// </summary>
        /// <typeparam name="T">Type of the future we will return</typeparam>
        /// <param name="value">The value that should be rendered - for demo purposes only</param>
        /// <returns></returns>
        public static IFutureValue<T> FutureCalculate<T>(T value)
        {
            return new FVConstant<T>(value);
        }

        /// <summary>
        /// The select pattern. Allows for direct access to the monad in the middle of a LINQ expression.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="M"></typeparam>
        /// <param name="self"></param>
        /// <param name="map"></param>
        /// <returns></returns>
        public static IFutureValue<T> Select<T, M>(this IFutureValue<M> self, Func<M, T> map)
        {
            // self is captured, and Value isn't called until later
            return new FVDelayed<T>(() => map(self.Value));
        }

        /// <summary>
        /// Implement the SelectMany pattern
        /// </summary>
        /// <typeparam name="T">The source type (often a collection, but not for us!)</typeparam>
        /// <typeparam name="U">The accumulator function</typeparam>
        /// <typeparam name="V">The result type of the SelectMany call</typeparam>
        /// <param name="self"></param>
        /// <param name="select"></param>
        /// <param name="project"></param>
        /// <returns></returns>
        public static IFutureValue<V> SelectMany<T, U, V>(
            this IFutureValue<T> self,
            Func<T, IFutureValue<U>> select,
            Func<T, U, V> project)
        {
            // Capture self, select, and project - and evaluate only when we are ready to go.
            return new FVDelayed<V>(() =>
            {
                var u = select(self.Value);
                return project(self.Value, u.Value);
            });
        }

    }
}
