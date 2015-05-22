using UnityEngine;
using System.Collections;

public class MyThingController : MonoBehaviour
{

    public float horizontalSpeed = 5.0f;
    public float verticalSpeed = 5.0f;

	void Start () {
	
	}
	
	void Update ()
	{
        float xDelta = Input.GetAxis("Horizontal") * horizontalSpeed * Time.deltaTime;
        float yDelta = Input.GetAxis("Vertical") * verticalSpeed * Time.deltaTime;

	    float xFinal = transform.position.x + xDelta;
	    float yFinal = transform.position.y + yDelta;
        transform.position = new Vector3(xFinal, yFinal, 0);


	}
}
