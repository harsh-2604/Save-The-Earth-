using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class touchDetection : MonoBehaviour
{
    public LayerMask meteoroidLayer;
    public Vector2 rayPosition;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rayPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            RaycastHit2D hit2D = Physics2D.Raycast(rayPosition, Vector2.zero, 10, meteoroidLayer);

            if (hit2D.collider != null )
            {
                //Destroy(hit2D.collider.gameObject);
                hit2D.collider.GetComponent<meteroidController>().destroy();
                
            }
        }
    }
    
}
