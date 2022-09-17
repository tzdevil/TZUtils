using System.Collections.Generic;
using UnityEngine;

namespace tzdevil.DevilUtils
{
    public static class ArrayOp
    {
        #region List/Array Swap
        /// <summary>
        /// Use this method to change two indices of a list.
        /// </summary>
        /// <remarks>
        /// <code>list.Swap(indexOne, indexTwo);</code>
        /// </remarks>
        public static IList<T> Swap<T>(this IList<T> list, int indexOne, int indexTwo)
        {
            (list[indexTwo], list[indexOne]) = (list[indexOne], list[indexTwo]);
            return list;
        }
        /// <summary>
        /// Use this method to change two indices of an array.
        /// </summary>
        /// <remarks>
        /// <code>array.Swap(indexOne, indexTwo);</code>
        /// </remarks>
        public static T[] Swap<T>(this T[] list, int indexOne, int indexTwo)
        {
            (list[indexTwo], list[indexOne]) = (list[indexOne], list[indexTwo]);
            return list;
        }
        #endregion
        
        #region Remove Duplicates
        /// <summary>
        /// Remove duplicates from a list.
        /// </summary>
        /// <remarks>
        /// <code>list.RemoveDuplicates();</code>
        /// </remarks>
        public static IList<T> RemoveDuplicates<T>(this IList<T> list)
        {
            var newList = new List<T>();
            foreach (var item in list)
            {
                if (!newList.Contains(item))
                    newList.Add(item);
            }
            return newList;
        }
        #endregion
    }
}