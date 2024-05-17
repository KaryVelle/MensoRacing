using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class BodyColorButton : MonoBehaviour
{

    [SerializeField] private Button colButton;
 
    [SerializeField] private CustomizeCharacter customizeCharacter;

    private void Awake()
    {
        colButton.onClick.AddListener(() => { customizeCharacter.ChangeSecondColor(); Debug.Log("Cambio Color Body"); });
    }
}