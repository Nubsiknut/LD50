using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 1500f;

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(0, 0, speed * Time.deltaTime));
    }
}
