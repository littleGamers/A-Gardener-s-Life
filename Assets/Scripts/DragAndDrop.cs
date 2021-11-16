using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    [SerializeField] string objectTag;
    private bool isDragging;
    private Vector3 startPosition; 

    private void Start()
    {
        GameObject newObject = GameObject.FindGameObjectWithTag(objectTag);
        startPosition = newObject.transform.position;
    }

    public void OnMouseDown()
    {
        isDragging = true;
    }

    public void OnMouseUp()
    {
        isDragging = false;
        transform.position = startPosition;
    }
    void Update()
    {
        if (isDragging)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }
    }
}
