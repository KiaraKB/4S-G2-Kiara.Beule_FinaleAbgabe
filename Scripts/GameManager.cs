using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using System.Security.Cryptography;
using Eflatun.SceneReference;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] private SceneReference sceneMenu;
    public SceneReference[] scenesLevel;

    private void Awake() // destroys or doesnt destroy this 
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }

        DontDestroyOnLoad(this);

    }

    public void LoadMenu() // loads main menu
    {
        SceneManager.LoadScene(sceneMenu.BuildIndex);
    }

    public void LoadLevel(int listIndex) // makes a list and loads the levels tied to it
    {
        SceneManager.LoadScene(scenesLevel[listIndex].BuildIndex);
    }

}
