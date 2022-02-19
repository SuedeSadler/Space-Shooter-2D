using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
   public Vector3 bulletOffset = new Vector3(0, 0.5f, 0);
    public GameObject bulletPrefab;
    int bulletLayer;
    public float fireDelay = 0.75f;
    float cooldownTimer = 0;

    void Start() {
        bulletLayer = gameObject.layer;
    }

    // Update is called once per frame
    void Update() {
        cooldownTimer -= Time.deltaTime;

        if ( cooldownTimer <=0 ) {
            //SHOOT
            Debug.Log ("PEW");
            cooldownTimer = fireDelay;

            Vector3 offset = transform.rotation * bulletOffset;

           GameObject bulletGo = (GameObject)Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
           bulletGo.layer = bulletLayer;
        } 
    }
}
