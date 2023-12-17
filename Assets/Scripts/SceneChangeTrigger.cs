using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeTrigger : MonoBehaviour
{
    public string sceneToLoad = "NomDeLaScene"; // Nom de la scène par défaut
    public SceneChanger sceneChanger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Assurez-vous que l'objet entrant a le tag "Player" (ajustez-le en fonction de vos besoins)
        {
            sceneChanger.ChangeScene(sceneToLoad);
        }
    }
}
