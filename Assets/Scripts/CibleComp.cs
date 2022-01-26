using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controllers
{
    public class CibleComp : MonoBehaviour {

        [SerializeField] private BoxCollider spawnZone = default;
        [SerializeField] private GameObject Cube = default;
        [SerializeField] private GameObject Cible = default;
        private Bounds spawnBounds;


        private void Awake()
        {
            spawnBounds = spawnZone.bounds;
        }

        void onCollisionEnter(Collision collision)
        {
            Destroy(gameObject);
            Instantiate(Cube, collision.contacts[0].point, Quaternion.FromToRotation(Vector3.up, Vector3.down)) ;
            Instantiate(Cible, GetRandomSpawnPosition(), GetRandomRotation());
        }
        void OnControllerColliderHit(ControllerColliderHit col) {
            if (col.collider.name == "cylinder")
            {
        col.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
              }
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
}
