using System.Collections.Generic;
using UnityEngine;

public class CharacterCustomization : MonoBehaviour
{
    [SerializeField] private Renderer rend;

    [SerializeField] private List<Color> bodyColors = new List<Color>
    {
        new Color(0.905f, 0.298f, 0.235f), // Red
        new Color(0.905f, 0.541f, 0.235f), // Orange
        new Color(1.0f, 1.0f, 0.0f),       // Yellow
        new Color(0.153f, 0.827f, 0.569f), // Green
        new Color(0.298f, 0.235f, 0.905f), // Blue
        new Color(0.478f, 0.235f, 0.905f), // Violet
        new Color(0.102f, 0.102f, 0.102f), // Black
        new Color(0.498f, 0.498f, 0.498f), // Gray
        new Color(0.933f, 0.933f, 0.933f)  // White
    };

    [SerializeField] private List<Color> screenColors = new List<Color>
    {
        new Color(0.905f, 0.298f, 0.235f), // Red
        new Color(0.905f, 0.541f, 0.235f), // Orange
        new Color(1.0f, 1.0f, 0.0f),       // Yellow
        new Color(0.153f, 0.827f, 0.569f), // Green
        new Color(0.298f, 0.235f, 0.905f), // Blue
        new Color(0.478f, 0.235f, 0.905f), // Violet
        new Color(0.102f, 0.102f, 0.102f), // Black
        new Color(0.498f, 0.498f, 0.498f), // Gray
        new Color(0.933f, 0.933f, 0.933f)  // White
    };

    [SerializeField] private Texture[] eyes;
    [SerializeField] private Texture[] mouths;

    private int eyeIndex;
    private int mouthIndex;
    private int bodyColorIndex;
    private int screenColorIndex;

    private void Awake()
    {
        eyeIndex = PlayerPrefs.GetInt("eyeIndex", 0);
        mouthIndex = PlayerPrefs.GetInt("mouthIndex", 0);
        bodyColorIndex = PlayerPrefs.GetInt("bodyColorIndex", 3);
        screenColorIndex = PlayerPrefs.GetInt("screenColorIndex", 2);

        UpdateEye();
        UpdateMouth();
        UpdateBodyColor();
        UpdateScreenColor();
    }

    public void SelectEyes(bool isForward)
    {
        if (isForward)
        {
            eyeIndex = (eyeIndex + 1) % eyes.Length;
        }
        else
        {
            eyeIndex = (eyeIndex - 1 + eyes.Length) % eyes.Length;
        }
        PlayerPrefs.SetInt("eyeIndex", eyeIndex);
        UpdateEye();
    }

    public void SelectMouth(bool isForward)
    {
        if (isForward)
        {
            mouthIndex = (mouthIndex + 1) % mouths.Length;
        }
        else
        {
            mouthIndex = (mouthIndex - 1 + mouths.Length) % mouths.Length;
        }
        PlayerPrefs.SetInt("mouthIndex", mouthIndex);
        UpdateMouth();
    }

    public void SelectBodyColor(bool isForward)
    {
        if (isForward)
        {
            bodyColorIndex = (bodyColorIndex + 1) % bodyColors.Count;
        }
        else
        {
            bodyColorIndex = (bodyColorIndex - 1 + bodyColors.Count) % bodyColors.Count;
        }
        PlayerPrefs.SetInt("bodyColorIndex", bodyColorIndex);
        UpdateBodyColor();
    }

    public void SelectScreenColor(bool isForward)
    {
        if (isForward)
        {
            screenColorIndex = (screenColorIndex + 1) % screenColors.Count;
        }
        else
        {
            screenColorIndex = (screenColorIndex - 1 + screenColors.Count) % screenColors.Count;
        }
        PlayerPrefs.SetInt("screenColorIndex", screenColorIndex);
        UpdateScreenColor();
    }

    private void UpdateEye()
    {
        if (rend != null && eyes.Length > 0)
        {
            rend.material.SetTexture("_MainTex", eyes[eyeIndex]);
        }
    }

    private void UpdateMouth()
    {
        if (rend != null && mouths.Length > 0)
        {
            rend.material.SetTexture("_MouthTex", mouths[mouthIndex]);
        }
    }

    private void UpdateBodyColor()
    {
        if (rend != null)
        {
            rend.material.SetColor("_BodyColor", bodyColors[bodyColorIndex]);
        }
    }

    private void UpdateScreenColor()
    {
        if (rend != null)
        {
            rend.material.SetColor("_ScreenColor", screenColors[screenColorIndex]);
        }
    }
}
