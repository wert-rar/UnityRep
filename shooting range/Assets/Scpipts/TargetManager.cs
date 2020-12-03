using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetManager : MonoBehaviour
{

    public bool isDown;
    public Target target;

    private float upTime= 2f;

    private IEnumerator TargetUp()
    {
        yield return new WaitForSeconds(upTime);
        transform.Rotate(-90f, 0f, 0f);
        isDown = false;

    }
   

    void Start()
    {
        isDown = false;

    }

    // Update is called once per frame
    void Update()
    {   
        if (target.isCollision)
        {
            // rotate Target down  and up after upTime
            transform.Rotate(90f, 0f, 0f);
            isDown = true;
            target.isCollision = false;
            StartCoroutine(TargetUp());
        }
    }
}
