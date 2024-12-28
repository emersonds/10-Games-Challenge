using UnityEngine;

public class BackgroundLooper : MonoBehaviour
{
    [SerializeField, Tooltip("The background object that will be instantiated offscreen")]
    private GameObject backgroundObj;

    private Sprite sprite;

    private void Start()
    {
        sprite = gameObject.GetComponent<SpriteRenderer>().sprite;
    }

    private void Update()
    {
        if (sprite.bounds.max.x < Camera.main.ScreenToViewportPoint(Vector3.zero).x)
        {
            Debug.Log("Background outside of bounds.");
        }
    }
}
