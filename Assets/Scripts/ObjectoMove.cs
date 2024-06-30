using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectoMove : MonoBehaviour
{

    public GameObject Cube;
    public GameObject playerr;
    public float speed;
  

    // Update is called once per frame
    void Update()
    {
        Cube.transform.position = Vector3.MoveTowards(Cube.transform.position, playerr.transform.position, speed);
    }
}
