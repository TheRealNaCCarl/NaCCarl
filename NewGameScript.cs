using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class NewGameScript : MonoBehaviour
{
    public string Level_1;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(LoadFirstLevel);
    }

   private void LoadFirstLevel()
    {
        PlayerPrefs.SetInt("lastPlayedLevelIndex", 0);  // Set the last played level index to 0
        SceneManager.LoadScene(Level_1); // Load the first level of the game
    }
}
