using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace DisplayStudents.Model
{
    static class Extensions
    {
        /// <summary>
        /// Extension method to sort an observable collection by moving the items in the collection.
        /// </summary>
        /// <typeparam name="TSource">The type of the observable collection to sort.</typeparam>
        /// <typeparam name="TKey">The type of the key to sort the collection on.</typeparam>
        /// <param name="collection">The collection to sort.</param>
        /// <param name="keySelector">The function that selects the key in TSource.</param>
        public static void Sort<TSource, TKey>(this ObservableCollection<TSource> collection, Func<TSource, TKey> keySelector)
        {
            List<TSource> sorted = collection.OrderBy(keySelector).ToList();
            for (var i = 0; i < sorted.Count(); i++)
                collection.Move(collection.IndexOf(sorted[i]), i);
        }
    }
}
