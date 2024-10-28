using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public Sprite[] iconList;
    public Image[] buttonList;
    public GameObject[] screenPage;
    public GameObject ARCameraObject;
    public GameObject HomeScreen;

    // Function to set a button active and others inactive
    public void SetActiveButton(int activeButtonIndex)
    {
        for (int i = 0; i < buttonList.Length; i++)
        {
            // Set button to active style if it matches the active index, else set it to inactive style
            buttonList[i].sprite = i == activeButtonIndex ? iconList[i * 2 + 1] : iconList[i * 2];
        }
    }

    public void Home()
    {
        SetActiveButton(0); // Set Home button active
        HomeScreen.SetActive(true);
        ARCameraObject.SetActive(false);
    }

    public void Collectibles()
    {
        SetActiveButton(1); // Set Collectibles button active
    }

    public void ARCamera()
    {
        SetActiveButton(2); // Set AR Camera button active
        HomeScreen.SetActive(false);
        ARCameraObject.SetActive(true);
    }
}
