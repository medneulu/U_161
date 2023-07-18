using UnityEngine;

public class finish : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // Eğer Esc tuşuna basıldıysa
        {
            ExitGame(); // Oyundan çıkış fonksiyonunu çağır
        }
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Unity Editor'da çalışırken oyunu durdur
#else
        Application.Quit(); // Derlenmiş oyunu çalıştırırken oyunu kapat
#endif
    }
}

