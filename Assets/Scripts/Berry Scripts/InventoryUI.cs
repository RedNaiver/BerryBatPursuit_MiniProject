using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    // For berry text displaying "10/10" etc
    public TextMeshProUGUI berryText;

    // For completion text / sound
    public GameObject congratulationsText; 
    public AudioClip congratulationsSound; 
    private AudioSource audioSource; 

    // Reference to the GameManager
    private GameManager gameManager;


    // Start is called before the first frame update
    void Start()
    {
        berryText = GetComponent<TextMeshProUGUI>();
        audioSource = GetComponent<AudioSource>();

        // ensures the berrytext is assigned :I cause idk
        berryText = GetComponentInChildren<TextMeshProUGUI>();
       
        gameManager = FindObjectOfType<GameManager>();

        // Find the player's inventory and subscribe to its events
        PlayerInventory playerInventory = FindObjectOfType<PlayerInventory>();
        if (playerInventory != null)
        {
            playerInventory.OnBerryCollected.AddListener(UpdateBerryText);
            playerInventory.OnAllBerriesCollected.AddListener(DisplayCongratulations); // Subscribe to the new event
            UpdateBerryText(playerInventory); // Initialize UI text
        }

        if (congratulationsText != null)
        {
            congratulationsText.SetActive(false); // Hide the message initially
        }
    }



    // Simply updates the "x/10" text and stuff
    public void UpdateBerryText(PlayerInventory playerInventory)
    {
         berryText.text = $"{playerInventory.NumberOfBerries}/10";
    }




    // Displays the victory text when collected 10/10
    public void DisplayCongratulations()
    {
        // Show the victory text
        if (congratulationsText != null)
        {
            congratulationsText.SetActive(true);
        }

        // Play sound effect
        if (audioSource != null && congratulationsSound != null)
        {
            audioSource.PlayOneShot(congratulationsSound);
        }

        // Show the restart button
        if (gameManager != null)
        {
            gameManager.ShowRestartButton();
        }
    }
}
