using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLerpMovement : MonoBehaviour
{
    public Transform targetDestination; // Endpoint B
    public float speed;             

    private Vector3 startPosition; // StartPoint A
    private float travelLength;  // Range value of A and B
    private float startTime;

    // Start is called before the first frame update
    
  
    void Start()
    {
        startPosition = transform.position; //Pos of Cube
        travelLength = Vector3.Distance(startPosition,targetDestination.position); //Gets the distance of the cube and the cylinder
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float timeElapsed = (Time.time - startTime) * speed; // Controls the rate of the interepolation value to make sure the cube moves smoothly to the target pos
        float fractionOfJourney = timeElapsed / travelLength; // Gets the interpolation value of the range

        float x = Mathf.Lerp(startPosition.x, targetDestination.position.x,fractionOfJourney);
        float y = Mathf.Lerp(startPosition.y, targetDestination.position.y,fractionOfJourney);
        float z = Mathf.Lerp(startPosition.z, targetDestination.position.z,fractionOfJourney);

        float currentDistance = Vector3.Distance(transform.position, targetDestination.position);

        Debug.Log(speed + "");
        Debug.Log("Distance to target via lerping:" + currentDistance);
        transform.position = new Vector3(x,y,z);
        //float distCovered = (Time.time * speed);
        //float fractionofJourney = distCovered / travelLength;

        //transform.position = Vector3.Lerp(startPosition, targetDestination.position, fractionofJourney);
    }
}
