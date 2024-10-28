using UnityEngine;
using UnityEngine.UI;

public class CardVisual : MonoBehaviour
{
    public Image cardImage;         // The Image component to display the card visual
    public string cardKey; // Key for PlayerPrefs, e.g., "card1". Adjust for each card as needed.

    private void Awake()
    {
        cardKey = gameObject.name;
    }
    void Start()
    {
        cardKey = gameObject.name;
        UpdateCardVisual(); 
    }
    private void OnEnable()
    {
        UpdateCardVisual();
    }

    // Function to update the card visual based on PlayerPrefs
    public void UpdateCardVisual()
    {
        cardKey = gameObject.name;
        if (PlayerPrefs.GetInt(cardKey) == 0){
            cardImage.gameObject.SetActive(true); // Show the image
        }
        else
        {
            cardImage.gameObject.SetActive(false); // Hide the image if the player doesn't own the card

        }// Check if the player owns the card

       
    }

    // Function to toggle card ownership status (for testing or in-game changes)
    public void ToggleCardOwnership()
    {
        bool hasCard = PlayerPrefs.GetInt(cardKey, 0) == 1;
        PlayerPrefs.SetInt(cardKey, hasCard ? 0 : 1); // Toggle between owned (1) and not owned (0)
        PlayerPrefs.Save();

        UpdateCardVisual(); // Update the visual based on the new ownership status
    }
}
