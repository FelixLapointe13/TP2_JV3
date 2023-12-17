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
        GameObject[] objectsToPreserve = GameObject.FindGameObjectsWithTag(tagToPreserve);

        foreach (GameObject obj in objectsToPreserve)
        {
            DontDestroyOnLoad(obj);
        }
    }

}