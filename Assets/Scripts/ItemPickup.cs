using UnityEngine;

namespace Guild.Core
{
    [RequireComponent(typeof(CircleCollider2D), typeof(SpriteRenderer))]
    public class ItemPickup : MonoBehaviour
    {
        [SerializeField] private Item _item;

        void OnValidate()
        {
            var collider = GetComponent<CircleCollider2D>();
            var spriteRenderer = GetComponent<SpriteRenderer>();

            collider.isTrigger = true;
            spriteRenderer.sprite = _item.Sprite;
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.tag == "Player")
            {
                Destroy(gameObject);
            }
        }
    }
}