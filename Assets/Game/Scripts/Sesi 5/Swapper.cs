using UnityEngine;

namespace TrainingTripledot
{
    public static class Swapper<T>
    {

        public static void Swap(T a, T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
