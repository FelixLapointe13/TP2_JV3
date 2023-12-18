using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Failsafe : MonoBehaviour
{

    public GameObject joueur;

     private float positionJoueur;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        positionJoueur = joueur.transform.position.y;

        if(positionJoueur <= -50){

            positionJoueur = 2;

        }
    }
}
