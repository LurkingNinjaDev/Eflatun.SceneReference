﻿using System;
using JetBrains.Annotations;

namespace Eflatun.SceneReference.Utility
{
    /// <summary>
    /// Utilities used by Eflatun.SceneReference.
    /// </summary>
    [PublicAPI]
    public static class Utils
    {
        /// <summary>
        /// Returns the given <paramref name="path"/> without file extension.
        /// </summary>
        public static string WithoutExtension(this string path) => path.BeforeLast('.');

        /// <summary>
        /// Returns whether flags enum <paramref name="composite"/> includes all flags in <paramref name="flag"/>.
        /// </summary>
        public static bool IncludesFlag<T>(this T composite, T flag) where T : Enum => composite.HasFlag(flag);

        /// <summary>
        /// Returns the portion of <paramref name="source"/> that comes before the last occurence of <paramref name="chr"/>.
        /// </summary>
        public static string BeforeLast(this string source, char chr) =>
            source.Substring(0, source.LastIndexOf(chr));
    }
}
