using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HatButton : MonoBehaviour
{
    [SerializeField] private Button hatButton;
 
    [SerializeField] private CustomizeCharacter customizeCharacter;

    private void Awake()
    {
        hatButton.onClick.AddListener(() => { customizeCharacter.ChangeHat(); Debug.Log("Cambio hat"); });
    }
}
