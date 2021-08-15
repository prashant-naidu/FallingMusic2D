using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour
{
    public Camera MainCamera;

    private void OnMouseDrag()
    {
        Vector3 worldPoint = MainCamera.ScreenToWorldPoint(Input.mousePosition);
        gameObject.transform.position = new Vector3(worldPoint.x, worldPoint.y, 0);
    }
}
