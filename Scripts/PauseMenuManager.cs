using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject panelPause;  //makes a field to connect the object needed

    [SerializeField] Button buttonResume;  //makes a field to connect the object needed
    [SerializeField] Button buttonBackToMenu; //makes a field to connect the object needed

    // Start is called before the first frame update
    void Start() //disables the pause panel at the beginning and makes the buttons work
    {
        panelPause.SetActive(false);
        Time.timeScale = 1f;


        buttonResume.onClick.AddListener(ResumeCurrentLevel);

        buttonBackToMenu.onClick.AddListener(LoadMainMenu);

    }


    void ResumeCurrentLevel()  //disables the pause panel and locks the mouse when button is pressed
    {

        Cursor.lockState = CursorLockMode.Locked;
        panelPause.SetActive(false);
        Time.timeScale = 1f;

    }

    void LoadMainMenu() // sends you to main menu when button is pressed
    {
        SceneManager.LoadScene("MainMenu");
    }
}
