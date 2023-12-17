using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class EnveloppeScript : MonoBehaviour
{
    public UIScoreScript uiScoreScript;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        if (uiScoreScript == null)
        {
            Debug.LogError("Le script UIScoreScript n'est pas attribué. Assurez-vous de l'attacher à un objet dans la scène.");
        }
    }

    public void OnSelectEntered(XRBaseInteractor interactor)
    {
        if (uiScoreScript != null)
        {
            uiScoreScript.IncreaseScore();
        }

        Debug.Log("Entre++");
    }

    public void OnSelectExited(XRBaseInteractor interactor)
    {
        if (uiScoreScript != null)
        {
            uiScoreScript.DecreaseScore();
        }

        Debug.Log("Extit--");
    }
}

