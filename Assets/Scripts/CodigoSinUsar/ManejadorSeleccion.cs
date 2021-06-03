using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManejadorSeleccion : MonoBehaviour
{
    // [SerializeField] private Material highlightMaterial;
    private void Update()//funciona sin el click (buttondown).
    {
        // if(Input.GetMouseButtonDown(0))
        // {
            // var ray = Camera.current.ScreenPointToRay(Input.mousePosition);
            // RaycastHit hit;
            // if (Physics.Raycast(ray, out hit, 50.0f))
            // {
            //     var selection = hit.transform;
            //     var selectionRenderer = selection.GetComponent<Renderer>();
            //     if (selectionRenderer != null)
            //     {
            //         Debug.Log(hit.transform.name);
            //         // selectionRenderer.material = highlightMaterial;
            //     }
            // }
        // }
        OnMouseDown();
    }

    void OnMouseDown()
    {
        var ray = Camera.current.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 50.0f))
        {
            var selection = hit.transform;
            var selectionRenderer = selection.GetComponent<Renderer>();
            if (selectionRenderer != null)
            {
                Debug.Log(hit.transform.name);
                // selectionRenderer.material = highlightMaterial;
            }
        }
    }
}
