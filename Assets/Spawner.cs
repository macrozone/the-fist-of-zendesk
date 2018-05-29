using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    [SerializeField] private GameObject obstacle;
    private float difficulty = 1f;
    GameObject obstacleInstance;
	// Use this for initialization
	void Start () {
        StartCoroutine(SpawnObstacles());
	}
	
	// Update is called once per frame
	void Update () {
		 
	}

    IEnumerator SpawnObstacles() {
        while (true)
        {
            float fallHeight = Random.Range(1f, 5f);
            float duration = Mathf.Max(0.5f,Random.Range(2f, 4f)-difficulty*Random.Range(0.5f, 0.2f));
            yield return new WaitForSeconds(duration);
            obstacleInstance = Instantiate(obstacle);
           
            float scale = Random.Range(0.3f, 1.2f)*difficulty;


            obstacleInstance.transform.localScale = new Vector3(scale, scale, scale);
            obstacleInstance.transform.position = new Vector3(0, fallHeight, 30);
            difficulty += 0.1f;
        }
    }
}
    