using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CibleComp : MonoBehaviour
{
    // Start is called before the first frame update


    void onCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Instantiate(cube, collision.contact(0).point, Quaternion.FromToRotation(Vector3.up, contact.normal));
        Instantiate(Cible, GetRandomSpawnPosition(), GetRandomRotation());
    }

    private Vector3 GetRandomSpawnPosition()
    {
        return new Vector3(
            Random.Range(spawnBounds.min.x, spawnBounds.max.x),
            Random.Range(spawnBounds.min.y, spawnBounds.max.y),
            Random.Range(spawnBounds.min.z, spawnBounds.max.z));
    }

    private static Quaternion GetRandomRotation()
    {
        return Quaternion.Euler(0f, Random.Range(0f, 360f), 0f);
    }
}
