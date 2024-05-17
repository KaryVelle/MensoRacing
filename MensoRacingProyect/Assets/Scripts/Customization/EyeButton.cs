using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EyeButton : MonoBehaviour
{
    [SerializeField] private Button eyeButton;
 
    [SerializeField] private CustomizeCharacter customizeCharacter;

    private void Awake()
    {
        eyeButton.onClick.AddListener(() => { customizeCharacter.ChangeEyes(); Debug.Log("Cambio ojos"); });
    }
}
