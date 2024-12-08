using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleBerry : MonoBehaviour
{
    public AudioClip BerrySound; // Assign the sound effect in the inspector

    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null)
        {
            // Play the collection sound at the berry's position
            AudioSource.PlayClipAtPoint(BerrySound, transform.position);

            // Collect the berry
            playerInventory.BerryCollected();

            // Immediately deactivate the berry GameObject
            gameObject.SetActive(false);
        }
    }
   
}
