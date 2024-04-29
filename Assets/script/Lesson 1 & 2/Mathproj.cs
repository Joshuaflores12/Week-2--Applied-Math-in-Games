using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Mathproj : MonoBehaviour
{
    public Transform aTransform;
    public Transform bTransform;
    public Transform cTransform;
    //public float disAtoB;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos() 
    {
        Vector2 a = aTransform.position;
        Vector2 b = bTransform.position;
        Vector2 c = cTransform.position;

        //Gizmos.color = Color.red;
        //Vector2 point = transform.position;
        //Vector2 dirTopoint = point.normalized; // converts the value of the pos origin to whole #
        //Gizmos.DrawLine(Vector3.zero, dirTopoint);


        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(a, b);
        Gizmos.DrawLine(c, b);
        Gizmos.DrawLine(a, c);
    }
}
