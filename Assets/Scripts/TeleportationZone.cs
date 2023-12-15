using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportationZone : MonoBehaviour
{
    // Nom de la scène de destination
    public string sceneToLoad;

    // Méthode appelée lorsqu'un objet XR entre en collision avec la zone
    private void OnTriggerEnter(Collider other)
    {
        // Vérifier si l'objet est un XR (vous pouvez remplacer cette vérification par un tag spécifique)
        if (other.CompareTag("XRObject"))
        {
            // Charger la scène de destination
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
