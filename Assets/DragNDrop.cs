using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragNDrop : MonoBehaviour
{
    public bool isDraggable;
    public bool isDragging;
    public Collider2D objectColliderPresidente;
    public Collider2D objectColliderPresidenteEleito;
    public Collider2D objectColliderRDR;
    public Collider2D objectColliderRotary;
    public Collider2D objectColliderGovernador;
    // Start is called before the first frame update
    void Start()
    {
        objectColliderPresidente = GetComponent<Collider2D>();
        objectColliderPresidenteEleito = GetComponent<Collider2D>();
        objectColliderRDR = GetComponent<Collider2D>();
        objectColliderRotary = GetComponent<Collider2D>();
        objectColliderGovernador = GetComponent<Collider2D>();
        isDraggable = false;
        isDragging = false;
    }

    // Update is called once per frame
    void Update()
    {
        DragAndDrop(objectColliderPresidente);
        DragAndDrop(objectColliderPresidenteEleito);
        DragAndDrop(objectColliderRDR);
        DragAndDrop(objectColliderRotary);
        DragAndDrop(objectColliderGovernador);
    }

    void DragAndDrop(Collider2D character)
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            if (character == Physics2D.OverlapPoint(mousePosition))
            {
                isDraggable = true;
            }
            else
            {
                isDraggable = false;
            }

            if (isDraggable)
            {
                isDragging = true;
            }
        }
        if (isDragging)
        {
            this.transform.position = mousePosition;
        }

        if (Input.GetMouseButtonUp(0))
        {
            isDraggable = false;
            isDragging = false;
        }
    }
}
