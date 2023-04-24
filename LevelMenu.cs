using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelMenu : MonoBehaviour
{
    public GameObject LevelSelectorUI;
    public LevelsButton levelsButton;
    public GameObject MainMenuUI;

    void Update()
    {
        if (levelsButton.LevelsMenuBool)
        {
            LevelSelectorUI.SetActive(true);
        }
    }

    public void LoadLevel_1()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level_1");
    }

    public void LoadLevel_2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level_2");
    }

    public void LoadLevel_3()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level_3");
    }

    public void LoadBack()
    {
        LevelSelectorUI.SetActive(false);
        MainMenuUI.SetActive(true);
        levelsButton.LevelsMenuBool = false;
    }
}

