using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // I only really use this script to reload the scene from the beginning
    // So when the player finish the level they can click the button to run through it again etc etc
    public GameObject restartButton;

    // To reload the current sceneeeee
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Show the restart button when the game endssss
    public void ShowRestartButton()
    {
        if (restartButton != null)
        {
            restartButton.SetActive(true);
        }
    }
}
