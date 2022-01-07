using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock_move : MonoBehaviour {

    // Use this for initialization
    private Rigidbody rock;
    void Start () {
        rock = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rock.velocity = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
