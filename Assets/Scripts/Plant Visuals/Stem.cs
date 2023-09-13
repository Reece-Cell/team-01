using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stem : MonoBehaviour
{
    public Sprite stemImage;
    public Color stemColor; 
    public List<Sprite> coreImages; // List of core images
    public List<Core> cores = new List<Core>();
    private SpriteRenderer stemSpriteRenderer;
    public float yOffset = -0.2f; // Adjust this value to set the vertical position of cores relative to the stem
    private float zOffset = 0.1f;

    private void Start()
    {
        // Get the component for the stem image
        stemSpriteRenderer = GetComponent<SpriteRenderer>();
        
        // Set the stem image and color
        stemSpriteRenderer.sprite = stemImage;
        

        CreateCores();
    }

    public void SetStemColor(Color newColor)
    {
        stemColor = newColor;
    }

public Sprite GetCoreImage()
{
    if (coreImages.Count > 0)
    {
        return coreImages[0];
    }
    else
    {
        // Return a default sprite or handle the case where coreImages is empty.
        return null; // Change this to your default sprite or handle the case accordingly.
    }
}
    
    
    private void CreateCores()
    {
        foreach (Sprite coreImage in coreImages)
        {
            // Instantiate a new core
            Core newCore = Instantiate(cores[0], transform.position + new Vector3(0, yOffset, zOffset), Quaternion.identity);
        
            // Set core properties based on stem traits
            newCore.SetCoreAttributes(coreImage, stemColor, transform.localScale * 0.8f);
        
            // Make the new core a child of the stem
            newCore.transform.SetParent(transform);
        
            // Add the core to the list
            cores.Add(newCore);

            yOffset -= 0.1f; // Adjust the yOffset to control core spacing. The offsets will be more important
            // Once I move on to cherries and the like
        } 
    }
}
