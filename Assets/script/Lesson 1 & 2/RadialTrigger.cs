using System;
using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

public class RadialTrigger : MonoBehaviour
{
    public Transform enemyTF;
    [Range(0f, 5f)]
    public float radius;
#if UNITY_EDITOR
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
        Vector2 enemyPosition = enemyTF.position;
        Vector2 origin = transform.position;
        float distance = Vector2.Distance(origin, enemyPosition);
        bool isInside = distance <= radius;
    
        Handles.color = isInside ? Color.red : Color.green;
        Handles.DrawWireDisc(origin, new Vector3(0, 0, 1), radius);         
    }
#endif
}

