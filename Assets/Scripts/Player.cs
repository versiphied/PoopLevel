using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	public KeyCode poopKey = KeyCode.Space;
	public KeyCode upKey = KeyCode.UpArrow;
	public KeyCode downKey = KeyCode.DownArrow;
    public KeyCode rightKey = KeyCode.RightArrow;
    public KeyCode leftKey = KeyCode.LeftArrow;

	public float moveSpeed = 5f;

	public GameObject poopBullet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(upKey)) {
			transform.Translate(0, moveSpeed*Time.deltaTime, 0);
		}
		if (Input.GetKey(downKey)) {
			transform.Translate(0, -moveSpeed*Time.deltaTime, 0);
		}
        if (Input.GetKey(rightKey))
        {
            transform.Translate(moveSpeed * Time.deltaTime, 0 , 0);
        }
        if (Input.GetKey(leftKey))
        {
            transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKeyDown(poopKey)) {
			GameObject newProjectileObj = Instantiate(poopBullet); 
			newProjectileObj.transform.position = transform.position;
		}
	}
}
