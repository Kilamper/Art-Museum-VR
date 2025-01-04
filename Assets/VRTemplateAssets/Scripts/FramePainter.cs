using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class FramePainter : MonoBehaviour, IPointerEnterHandler, IPointerDownHandler
{
    [SerializeField]
    private GameObject leftColorSphere, rightColorSphere;

    [SerializeField]
    private RawImage frame;

    public void OnPointerDown(PointerEventData eventData)
    {
        ChangeFrameColor();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (Pointer.current.press.isPressed)
        {
            ChangeFrameColor();
        }
    }

    private void ChangeFrameColor()
    {
        Renderer leftRenderer = leftColorSphere.GetComponent<Renderer>();
        frame.color = leftRenderer.material.color;
    }
}