using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testmaths : MonoBehaviour
{
    public float magnitude, speed;
    public Vector3 startpos;
    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(0, PingPongAmount(),0);
        transform.position = new Vector3(0, SineAmount(),0);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(startpos, 0.25f);
    }

    public float PingPongAmount() 
    {
        return Mathf.PingPong(Time.time * speed, magnitude);
    }

    public float SineAmount() 
    {
        return Mathf.Sin(Time.time * speed);

    }

    // apply slerp 
    // apply lerp
}
