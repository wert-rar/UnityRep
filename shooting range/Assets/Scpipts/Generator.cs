using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public int numberOfTargets=10;
    public GameObject target;
    private int max= 50;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < numberOfTargets; i++)
        {           
            Instantiate(target, new Vector3(Random.Range(-max, max), 0f, Random.Range(-max, max)), new Quaternion());
        }
    }
}
