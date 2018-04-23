using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

    public GameObject bulletSpawnPoint;
    public GameObject bulletPrefab;

    void Start()
    {
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            
            GameObject bullet = GameObject.Instantiate<GameObject>(bulletPrefab);

            bullet.transform.position = bulletSpawnPoint.transform.position;
            bullet.transform.rotation = transform.rotation;
        }
    }
}

   /* public float damage = 10f;
    public float range = 100f;
    public float impactForce = 50f;

    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    public GameObject impactEffect;
	
	// Update is called once per frame
	void Update ()
    {

        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
		
	}

    void Shoot()
    {
        //muzzleFlash.Play(); 

       /* RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if(target != null)
            {
                target.TakeDamage(damage);
            }

            if(hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }

            GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGO, 2f);
            }
            
       
        
    
} */

