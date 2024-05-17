using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class ColorButton : MonoBehaviour
{

  [SerializeField] private Button colButton;
 
  [SerializeField] private CustomizeCharacter customizeCharacter;

  private void Awake()
  {
      colButton.onClick.AddListener(() => { customizeCharacter.ChangeFirstColor(); Debug.Log("Cambio Color"); });
  }
}
