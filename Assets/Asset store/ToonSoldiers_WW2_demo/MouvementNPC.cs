using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementNPC : MonoBehaviour
{
    private float _positionX;

    private float _vitesse = 3;

    // Start is called before the first frame update
    void Start()
    {
        _positionX = transform.position.x;

    }

    // Update is called once per frame
    void Update()
    {
        Mouvement();
    }

    private void Mouvement() 
    {
        if(_positionX >= -50) 
        {
            _positionX = transform.position.x + (_vitesse * Time.deltaTime);
        }

        if(_positionX == -50) 
        {
            transform.position = new Vector3(-6, transform.position.y, transform.position.z);
        }

    }
}
