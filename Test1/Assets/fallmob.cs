using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallmob : MonoBehaviour {

    public int speed = 1;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        checkoffscreen();
        transform.position -= Vector3.up * speed * Time.deltaTime;

        if (transform.position.y < -6) Destroy(gameObject);
    }

    void checkoffscreen()
    {
        if (transform.position.y > 6) Destroy(gameObject);
    }
}
