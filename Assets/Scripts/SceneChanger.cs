using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public string tagToPreserve = "EveryScene";

    private void Awake()
    {
        PreserveObjectsWithTag();
    }

    private void PreserveObjectsWithTag()
    {
        GameObject[] objectsToPreserve = GameObject.FindGameObjectsWithTag(tagToPreserve);

        foreach (GameObject obj in objectsToPreserve)
        {
            DontDestroyOnLoad(obj);
        }
    }

    public void LevelCompleted()
    {
        // Récupérer tous les objets préservés avec le tag "EveryScene"
        GameObject[] preservedObjects = GameObject.FindGameObjectsWithTag(tagToPreserve);
        ChangeScene("MenuAccueilFin");
        // Détruire ces objets
        foreach (GameObject obj in preservedObjects)
        {
            Destroy(obj);
        }

        // Charger une nouvelle scène (ajuster l'index ou le nom selon vos besoins)

    }
}