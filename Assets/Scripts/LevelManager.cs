using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Méthode pour charger une nouvelle scène par son index dans les Build Settings
    public void LoadSceneByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    // Méthode pour quitter le jeu
    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    // Méthode appelée lorsque le niveau est complété
    public void LevelCompleted()
    {
        Debug.Log("Level Completed!");

        // Charger la scène avec l'index 1
        LoadSceneByIndex(1);
    }
}
