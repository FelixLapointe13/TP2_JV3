using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimerCalcul : MonoBehaviour
{


    [SerializeField] private InfosNiveau infosNiveau;


    private bool decompteActif = false;


    public UnityEvent auChangementDuTemps;



    // Start is called before the first frame update
    void Start()
    {
        DemarrerDecompte();
    }

    // Update is called once per frame
    void Update()
    {
        if(decompteActif == true)
        {
            if(infosNiveau.temps < 9999)
            {

                infosNiveau.temps += Time.deltaTime;

                auChangementDuTemps.Invoke();

            }

        
        }
    }


    public void DemarrerDecompte()
    {

       
        decompteActif = true;

    }

}



 