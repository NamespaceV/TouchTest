using UnityEngine;

namespace Interactable
{
    public class CircleMarker : MonoBehaviour
    {
        public float lifespan;
        public void Start()
        {
            Destroy(gameObject, lifespan);
        }
    }
}