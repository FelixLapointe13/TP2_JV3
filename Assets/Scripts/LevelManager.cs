using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public string tagToPreserve = "EveryScene";
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

        // Récupérer tous les objets préservés avec le tag "EveryScene"
        GameObject[] preservedObjects = GameObject.FindGameObjectsWithTag(tagToPreserve);
SceneManager.LoadScene("MenuAccueilFin");
        // Détruire les objets préservés
        foreach (GameObject obj in preservedObjects)
        {
            Destroy(obj);
        }

        // Changer de scène après la destruction
        
    }
}

