using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmove : MonoBehaviour {

    public int speed = 3;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
        checkoffscreen();
    }
    void checkoffscreen()
    {
        if (transform.position.y > 6) Destroy(gameObject);
    }
}
