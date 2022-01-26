using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shot();
        Deplacement();
        Vise()
    }

    private void Shot()
    {
        if (Input.GetButtonUp("Fire1"))
            ballSpawnerController.SpawnBall();
    }


}

