using System.Collections.Generic;

namespace LearningEfc.Extensions
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> SingleElement<T>(T element)
        {
            yield return element;
        }
    }
}