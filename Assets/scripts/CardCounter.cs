using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CardCounter : MonoBehaviour
{
    public int minCard = 1;         // Set minimum card number in the inspector
    public int totalCard = 10;        // Set maximum card number in the inspector
    public TextMeshProUGUI cardCounterText;    // Reference to the UI Text component to display the card count
    public bool isCounted = false;
    void Start()
    {
        cardCounterText = gameObject.GetComponent<TextMeshProUGUI>();
        UpdateCardCount();
    }
    private void OnEnable()
    {
        UpdateCardCount();
    }

    // Function to update the card counter display
    public void UpdateCardCount()
    {
        int activeCardCount = 0;
        int maxCard = minCard + totalCard - 1;
        // Iterate through all cards from minCard to maxCard
        for (int i = minCard; i <= maxCard; i++)
        {
            string cardKey = "card" + i;
            if (PlayerPrefs.GetInt(cardKey, 0) == 1) // Check if the card is active
            {
                activeCardCount++;
            }
        }

        // Update the UI text with the active card count
        if (isCounted)
        {
            cardCounterText.text = activeCardCount + " / " + (totalCard);

        }
        else
        {
            cardCounterText.text = activeCardCount.ToString();
        }
        
    }

    // Optional function to reset all card preferences within the range (for testing purposes)
    public void ResetAllCards()
    {
        int maxCard = minCard + totalCard - 1;
        for (int i = minCard; i <= maxCard; i++)
        {
            PlayerPrefs.SetInt("card" + i, 0); // Set all cards to inactive within the range
        }
        PlayerPrefs.Save();
        UpdateCardCount(); // Update UI after reset
    }
}
