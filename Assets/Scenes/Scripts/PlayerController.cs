using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit, 1000))
            {
                GameObject go = hit.collider.gameObject;
                if (go != null)
                {
                    Debug.Log(go.name);
                }
            }
        }
    }

    private void FixedUpdate()
    {
        
    }
}
