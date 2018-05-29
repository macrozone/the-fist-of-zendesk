using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour {

    [SerializeField] private float speed;



    // Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -speed), ForceMode.VelocityChange);
	}

	private void OnCollisionEnter(Collision collision)
	{
        if(collision.gameObject.tag == "Player") {
            LoseLogic.instance.OnLose();
           
        }
	}
}
