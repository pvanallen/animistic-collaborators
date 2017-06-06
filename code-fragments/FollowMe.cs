using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MovementType {
    MoveTowards,
    Lerp
};

public class FollowMe : MonoBehaviour {

    public float speed = 1;
    public Vector3 offset = new Vector3(0, 0, 0);
    public MovementType movementType;

    void Start () {

	}

	// Update is called once per frame
  //
	void Update () {
        float step = speed * Time.deltaTime;
        var headPosition = Camera.main.transform.position;
        // switch statement to selecty which kind of motion to use
        switch(movementType) {
            case MovementType.MoveTowards:
                transform.position = Vector3.MoveTowards(transform.position, headPosition + offset, step);
                break;
            case MovementType.Lerp:
                transform.position = Vector3.Lerp(transform.position, headPosition + offset, step);
                break;
        }
    }
}
