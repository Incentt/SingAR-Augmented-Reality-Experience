using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCards : MonoBehaviour
{
    public string cardID = "card1";
    public GameObject foundAnim;

    public void toggleCards()
    {
        if(PlayerPrefs.GetInt(cardID) == 0)
        {
            PlayerPrefs.SetInt(cardID, 1);
            Debug.Log(PlayerPrefs.GetInt(cardID));
            toggleAnimation();
        }
        
    }
    public void toggleAnimation()
    {
        foundAnim.SetActive(true);
    }
    private void Update()
    {
        if (Input.GetKeyDown("m"))
        {

            ResetAllCards();
        }
    }
    public void ResetAllCards()
    {
        for (int i = 1; i <= 20; i++)
        {
            PlayerPrefs.SetInt("card" + i, 0); // Set all cards to inactive within the range
        }
        PlayerPrefs.Save();
    }
}
