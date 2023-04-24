using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private int currentLevelIndex = 0;

    public int[] levelOrder;

    public int AmountOfGameCompleted;

    void Start()
    {
        currentLevelIndex = SceneManager.GetActiveScene().buildIndex - 1; // Set current level index to the index of the current scene
    }

    public void LoadNextLevel()
    {
        currentLevelIndex++;

        if (currentLevelIndex >= levelOrder.Length) // Check if all levels have been completed
        {
            if (AmountOfGameCompleted >= 2)
            {
                 GameCompleted();
            }
            
            currentLevelIndex = 0; // Reset current level index to 0
            AmountOfGameCompleted++;
            SceneManager.LoadScene(levelOrder[currentLevelIndex]); // Load first level in predetermined order
        }
        else
        {
            SceneManager.LoadScene(levelOrder[currentLevelIndex]); // Load next level in predetermined order
        }
    }

    public void GameCompleted()
    {
        // Add any necessary game completion logic here
    }
}
