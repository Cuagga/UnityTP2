using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Controls : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private BallSpawner ballSpawner = default;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shot();
        Deplacement();
        Vise();
    }

    private void Shot()
    {
        if (Input.GetButtonUp("Fire1"))
            ballSpawner.SpawnBall();
    }
    
    private void Deplacement() { }
    private void Vise() { }
}

