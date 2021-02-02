using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
     public GameObject[] waypoints;
    // Start is called before the first frame update
    void Awake()
    {
      

    }

    // Update is called once per frame
    void Update()
    {
       

    }

     public void OnDrawGizmos()
    {
        //foreach (GameObject way in waypoints)
       // {
           // Gizmos.DrawLine();
       // }
        Gizmos.color = Color.yellow;
        foreach (GameObject go in waypoints)
        Gizmos.DrawLine(transform.position, go.transform.position);

         foreach (GameObject go in waypoints)
         Gizmos.DrawWireSphere(go.transform.position, 1);
     
    }
}

