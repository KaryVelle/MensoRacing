using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizeCharacter : MonoBehaviour
{
    [SerializeField] private List<Material> materials;
    [SerializeField] private List<Material> bodyMaterials;
    [SerializeField] private Renderer renderer; 
    [SerializeField] private List<GameObject> hats; 
    [SerializeField] private List<GameObject> eyes; 

    private int currentIndex = 0;
    private int currentBodyIndex = 0;
    private int currentHatIndex = -1;
    private int currentEyeIndex = -1;

    public void ChangeFirstColor()
    {
        if (materials.Count == 0)
        {
            Debug.LogError("Materials list is empty");
            return;
        }

        if (renderer != null)
        {
            ChangeFirstMaterial();
        }
        else
        {
            Debug.LogError("Renderer component not found on the player object");
        }
    }

    public void ChangeSecondColor()
    {
        if (bodyMaterials.Count == 0)
        {
            Debug.LogError("Body materials list is empty");
            return;
        }

        if (renderer != null)
        {
            ChangeSecondMaterial();
        }
        else
        {
            Debug.LogError("Renderer component not found on the player object");
        }
    }

    private void ChangeFirstMaterial()
    {
        if (renderer.materials.Length > 0)
        {
            Material[] newMaterials = renderer.materials;
            newMaterials[0] = materials[currentIndex];
            renderer.materials = newMaterials;

            currentIndex = (currentIndex + 1) % materials.Count;
        }
        else
        {
            Debug.LogError("Renderer does not have enough materials");
        }
    }

    private void ChangeSecondMaterial()
    {
        if (renderer.materials.Length > 1)
        {
            Material[] newBodyMaterials = renderer.materials;
            newBodyMaterials[1] = bodyMaterials[currentBodyIndex];
            renderer.materials = newBodyMaterials;

            currentBodyIndex = (currentBodyIndex + 1) % bodyMaterials.Count;
        }
        else
        {
            Debug.LogError("Renderer does not have enough materials");
        }
    }

    public void ChangeHat()
    {
        if (hats.Count == 0)
        {
            Debug.LogError("Hats list is empty");
            return;
        }
        
        if (currentHatIndex != -1)
        {
            hats[currentHatIndex].SetActive(false);
        }
        
        currentHatIndex = (currentHatIndex + 1) % hats.Count;
        
        hats[currentHatIndex].SetActive(true);
    }
    
    public void ChangeEyes()
    {
        if (eyes.Count == 0)
        {
            Debug.LogError("Eyes list is empty");
            return;
        }
        
        if (currentEyeIndex != -1)
        {
            eyes[currentEyeIndex].SetActive(false);
        }
        
        currentEyeIndex = (currentEyeIndex + 1) % eyes.Count;
        
        eyes[currentEyeIndex].SetActive(true);
    }
}
