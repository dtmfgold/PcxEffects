using UnityEngine;

namespace Pcfx
{
    public static class Utility
    {
        public static void Destroy(Object o)
        {
            if (o == null) return;
            if (Application.isPlaying)
                Object.Destroy(o);
            else
                Object.DestroyImmediate(o);
        }
    }
}
