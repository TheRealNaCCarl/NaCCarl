using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ContinueButton : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(LoadLastPlayedLevel);
    }

    private void LoadLastPlayedLevel()
    {
        int lastPlayedLevelIndex = PlayerPrefs.GetInt("lastPlayedLevelIndex", 0);
        SceneManager.LoadScene(lastPlayedLevelIndex);
    }
}
