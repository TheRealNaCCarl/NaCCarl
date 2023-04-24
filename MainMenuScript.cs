using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    public GameObject MainMenuUI;
    public LevelsButton levelsButton;

    void Update()
    {
        if (levelsButton.LevelsMenuBool)
        {
            MainMenuUI.SetActive(false);
        }
        else
        {
            MainMenuUI.SetActive(true);
        }
    }
}