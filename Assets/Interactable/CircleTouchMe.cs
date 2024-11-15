using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Interactable
{
    public class CircleTouchMe : MonoBehaviour, IPointerClickHandler
    {
        private SpriteRenderer _sprite;

        public void Start()
        {
            _sprite = GetComponent<SpriteRenderer>();
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            Debug.Log(name + " Game Object Clicked!");
            _sprite.color = Color.red;
            StartCoroutine(TurnOff());
        }

        public IEnumerator TurnOff()
        {
            yield return new WaitForSeconds(0.3f);
            _sprite.color = Color.white;
        }
    }
}
