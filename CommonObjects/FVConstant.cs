using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonObjects
{
    public class FVConstant<T> : IFutureValue<T>
    {
        private T _v;

        /// <summary>
        /// Initialize with a constant
        /// </summary>
        /// <param name="value"></param>
        public FVConstant(T value)
        {
            _v = value;
        }

        /// <summary>
        /// We are a constant - always hand back the file right away.
        /// </summary>
        public T Value => _v;
    }
}
