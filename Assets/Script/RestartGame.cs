using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            RestartLevel();
        }
    }

    void RestartLevel()
    {
        // Aktif sahneyi yeniden yükle
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}


