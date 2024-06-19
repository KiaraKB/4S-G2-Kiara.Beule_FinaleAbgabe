
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Eflatun.SceneReference;

public class MainUIManager : MonoBehaviour
{
    [SerializeField] private CanvasGroup panelMain;

    [SerializeField] private Button buttonNewGame;
    [SerializeField] private Button buttonQuit;

    [SerializeField] private Transform levelsParent;
    [SerializeField] private GameObject prefabLevelButton;


    private void Start()
    {
        buttonNewGame.onClick.AddListener(LoadFirstLevel);
        buttonQuit.onClick.AddListener(QuitGame);


        int i = 0;
        foreach (SceneReference levels in GameManager.Instance.scenesLevel)
        {
            Button button = Instantiate(prefabLevelButton, levelsParent).GetComponent<Button>();
            button.GetComponentInChildren<TextMeshProUGUI>().text = levels.Name;
            int currentIndex = i;
            button.onClick.AddListener(() =>
            {
                GameManager.Instance.LoadLevel(currentIndex);
            });
            i++;
        }

    }

    void LoadFirstLevel()
    {
       GameManager.Instance.LoadLevel(0);
    }

    void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }


}
