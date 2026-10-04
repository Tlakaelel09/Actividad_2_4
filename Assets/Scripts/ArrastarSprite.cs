using UnityEngine;

public class ArrastrarSprite : MonoBehaviour
{
    private Vector3 offset;

    void OnMouseDown()
    {
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
    }

    void OnMouseDrag()
    {
        Vector3 nuevaPosicion = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0)) + offset;
        transform.position = new Vector3(nuevaPosicion.x, nuevaPosicion.y, transform.position.z);
    }
}