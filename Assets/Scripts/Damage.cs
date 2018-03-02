using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {
    public int damageAmount = 10; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D coll)
    {  

        Health collHealth = coll.gameObject.GetComponent<Health>(); 

        if (collHealth != null)
        {       //if there is a heath component (otherwise its null)
            collHealth.health -= damageAmount;  //reduce the health of the gameObject hit by damageAmount
        }

        Destroy(gameObject); 
    }
}
