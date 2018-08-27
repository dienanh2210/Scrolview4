using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demomove : MonoBehaviour {
    public GameObject end;
    public float speed;
	
	void Start () {
		
	}

    void Update()
    {
        // StartCoroutine(Move_Routine(this.transform, Vector3.zero, Vector3.one));
        this.transform.position = Vector3.SlerpUnclamped(this.transform.position, end.transform.position, Time.deltaTime * speed);
    }
}
