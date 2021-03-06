﻿
using System;
using System.Collections.Generic;
using System.Linq;

namespace Thismaker.Core.Utilities
{
    public class EnumUtility
    {
        /// <summary>
        /// Gets all the values of an Enum as an <see cref="IEnumerable{T}"/> list
        /// Useful for iterating all the defined values of an enum
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<T> GetValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }

    }
}
