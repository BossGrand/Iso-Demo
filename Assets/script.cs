using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Transform[] children = transform.GetComponentsInChildren<Transform>(true);


        // Loop through each child object and change its sorting order
        foreach (Transform child in children)
        {
            // Get the renderer component of the child object
            Renderer renderer = child.GetComponent<Renderer>();

            // If the child object has a renderer component, change its sorting order
            if (renderer != null)
            {
                renderer.sortingOrder = -renderer.sortingOrder;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
