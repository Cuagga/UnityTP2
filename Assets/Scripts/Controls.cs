using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public float Speed=10f;
    [SerializeField] private LineRenderer aimRenderer = default;
    // Start is called before the first frame update
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
    
    void Deplacement()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-Vector3.right * Time.deltaTime * Speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * Speed);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * Speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.forward * Time.deltaTime * Speed);
        }
        
        
    }
    

    private void Shot()
    {
        if (Input.GetButtonUp("Fire1"))
            ballSpawner.SpawnBall();
    }
    
    

    private void Vise() {
        aimRenderer.positionCount = 2;
        Vector3 playerPosition = playerTransform.position;
        Vector3[] linePositions = { playerPosition, playerPosition + playerTransform.forward * 100f };
        aimRenderer.SetPositions(linePositions);
    }

}

