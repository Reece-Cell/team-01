using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Core : MonoBehaviour
{
    public Sprite coreImage;
    
    public void SetCoreAttributes(Sprite image, Color color, Vector3 scale)
    {
        // Set core's image, color, and scale
        GetComponent<SpriteRenderer>().sprite = image;
        GetComponent<SpriteRenderer>().color = color;
        GetComponent<SpriteRenderer>().transform.localScale = scale;
        color.a = 1.0f; // Set the alpha value to 1.0 (fully opaque)
        GetComponent<SpriteRenderer>().color = color;
        Debug.Log("Color is : " + color);
    }

    public void Update()
    {
        if (transform.position.z < -0.6f)
        {
            Destroy(gameObject);
        }
    }
}
