using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelsButton : MonoBehaviour
{
    public bool LevelsMenuBool;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(LoadPauseMenu);
    }

    private void LoadPauseMenu()
    {
        LevelsMenuBool = true;
    }
}

