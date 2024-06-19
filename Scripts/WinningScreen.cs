using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinningScreen : MonoBehaviour
{
    public GameObject winScreen;

    private void OnCollisionEnter2D(Collision2D colission)
    {
        if (colission.collider.CompareTag("Player"))
        {
            winScreen.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    
}
