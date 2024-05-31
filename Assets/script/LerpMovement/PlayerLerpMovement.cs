using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class PlayerLerpMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position, speed * Time.deltaTime);
        Debug.Log("speed is:" + speed);
        float currentDistance = Vector3.Distance(transform.position, target.position);
        Debug.Log("Distance to target via lerping:" + currentDistance);
    }
}
