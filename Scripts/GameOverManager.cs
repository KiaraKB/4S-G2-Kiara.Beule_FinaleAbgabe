using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    [SerializeField] private GameObject panelLost;

    [SerializeField] Button buttonTryAgain;
    [SerializeField] Button buttonBackToMenu;


    void Start() // makes the buttons clickable and disables the game over screen at the start of the game
    {
        panelLost.SetActive(false);
        Time.timeScale = 1f;


        buttonTryAgain.onClick.AddListener(ReloadCurrentLevel);

        buttonBackToMenu.onClick.AddListener(LoadMainMenu);

    }

    public void ShowLostPanel() // unlocks the cursor and reanables the game over screen
    {
        Cursor.lockState = CursorLockMode.None;
        panelLost.SetActive(true);
        Time.timeScale = 0f;

    }


    void ReloadCurrentLevel() // reloads the scene
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    void LoadMainMenu() // loads main menu
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
