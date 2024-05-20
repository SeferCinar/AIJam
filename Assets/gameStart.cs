using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwitcher : MonoBehaviour
{
    public Button yourButton; // Hierarchy'den butonu buraya sürükleyin

    void Start()
    {
        if (yourButton != null)
        {
            yourButton.onClick.AddListener(LoadNextScene);
        }
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene("modern city 2");
    }
}
