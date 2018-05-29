using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    [SerializeField] private float jumpForce;
    private Rigidbody player;
    bool isgrounded = true;

	// Use this for initialization
	void Start () {
        this.player = GetComponent<Rigidbody>();
		
	}

    void OnCollisionEnter(Collision theCollision)
    {
        if (theCollision.gameObject.name == "floor")
        {
            isgrounded = true;
        }
    }

    //consider when character is jumping .. it will exit collision.
    void OnCollisionExit(Collision theCollision)
    {
        if (theCollision.gameObject.name == "floor")
        {
            isgrounded = false;
        }
    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow)) {
            player.AddForce(new Vector3(0,jumpForce,0), mode: ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.DownArrow) && !isgrounded)
        {
            player.AddForce(new Vector3(0, -jumpForce, 0), mode: ForceMode.Impulse);
        }
      
	}
}
