using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_Level : MonoBehaviour
{
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
