using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonObjects
{
    /// <summary>
    /// Delayed evaluation of a future value
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class FVDelayed<T> : IFutureValue<T>
    {
        private Func<T> _generator;
        private bool _cached = false;
        private T _cached_value = default(T);

        public FVDelayed(Func<T> generate)
        {
            _generator = generate;
        }

        /// <summary>
        /// Evaluate the value and return it (cache so we generate only once).
        /// </summary>
        public T Value {
            get
            {
                if (!_cached)
                {
                    _cached_value = _generator();
                    _cached = false;
                }
                return _cached_value;
            }
        }
    }
}
