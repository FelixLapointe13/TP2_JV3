using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportationZone : MonoBehaviour
{
    // Nom de la sc�ne de destination
    public string sceneToLoad;

    // M�thode appel�e lorsqu'un objet XR entre en collision avec la zone
    private void OnTriggerEnter(Collider other)
    {
        // V�rifier si l'objet est un XR (vous pouvez remplacer cette v�rification par un tag sp�cifique)
        if (other.CompareTag("XRObject"))
        {
            // Charger la sc�ne de destination
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
