using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleScript : MonoBehaviour
{

    // Public variables are editable per-object in the inspector!
    public float speed = 2;
    public float amplitude = 1;

    // Private variables can't be accessed outside this class
    private float _timePassed;

    // Start is called before the first frame update
    void Start()
    {
        // Same thing as print
        Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        _timePassed += Time.deltaTime;
        // Use the sin of time passed to calculate position
        transform.position = new Vector3(0, Mathf.Sin(_timePassed * speed) * amplitude, 0);
    }
}
