using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

private static bool hasPreserved = false;
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

        public string tagToPreserve = "EveryScene";


    private void Awake()
    {
        if (!hasPreserved)
        {
            GameObject[] objectsToPreserve = GameObject.FindGameObjectsWithTag(tagToPreserve);

            foreach (GameObject obj in objectsToPreserve)
            {
                DontDestroyOnLoad(obj);
            }

            hasPreserved = true;
        }
        else
        {
            // Si les objets ont déjà été préservés, détruire les nouveaux objets dupliqués
            Destroy(gameObject);
        }
    }

}