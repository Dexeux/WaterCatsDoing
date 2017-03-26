using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMob : MonoBehaviour {

    public GameObject mob;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(SpawnMobs());

    }

    // Update is called once per frame
    void Update() {
    }


    IEnumerator SpawnMobs()
    {
        while (true)
        {
            Vector3 position = new Vector3(Random.Range(-5f, 5f), Random.Range(3f, 9f),-1);
            Instantiate(mob, position, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
        }

    }
}
