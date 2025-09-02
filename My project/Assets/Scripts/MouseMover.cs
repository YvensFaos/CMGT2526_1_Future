using UnityEngine;
using UnityEngine.Serialization;

public class MouseMover : MonoBehaviour
{
    [SerializeField] private RectTransform maskTransform;
    [SerializeField] private Canvas maskCanvas;

    [SerializeField] private Vector2 mouseScreenPos;
    [SerializeField] private Vector2 normalizedPosition;
    [SerializeField] private Vector2 resolution;
    [SerializeField] private Vector2 ratioPosition;

    private void Update()
    {
        mouseScreenPos = Input.mousePosition;
        normalizedPosition = new Vector2(
            mouseScreenPos.x / Screen.width,
            mouseScreenPos.y / Screen.height
        );
        var canvasRect = maskCanvas.GetComponent<RectTransform>();
        resolution = new Vector2(canvasRect.rect.width / 2.0f, canvasRect.rect.height / 2.0f);
        ratioPosition = new Vector2(normalizedPosition.x * 2.0f - 1.0f, normalizedPosition.y * 2.0f - 1.0f);
        maskTransform.anchoredPosition = new Vector2(ratioPosition.x * resolution.x, ratioPosition.y * resolution.y);
    }
}