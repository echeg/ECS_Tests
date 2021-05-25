using UnityEngine;

namespace EcsGenerator
{
    public class ShowOnlyInEditor : MonoBehaviour
    {
        public GameObject obj;

        private void Awake()
        {
            if (obj == null)
            {
                obj = gameObject;
            }
#if UNITY_EDITOR
            obj.SetActive(true);
#else
            obj.SetActive(false);
#endif
        }
    }
}