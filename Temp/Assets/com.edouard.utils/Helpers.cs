using UnityEngine;

namespace  com.edouard.utils
{
    public static class Helpers
    {
        public static void ResetTransfrom(this Transform t)
        {
            t.localPosition = Vector3.zero;
            t.localEulerAngles = Vector3.zero;
            t.localScale = Vector3.one;
        }
    }
}
