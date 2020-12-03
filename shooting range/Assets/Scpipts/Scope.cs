using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scope : MonoBehaviour
{

    public GameObject gun;
    public GameObject camera;
    public Camera MainCamera;

    private float xscope = 4f;
    private bool  IsScopped= false;
    private float normalFOV;
    private Vector3 gunPossition;

    // Start is called before the first frame update
    void Start()
    {
        normalFOV = MainCamera.fieldOfView;
        gunPossition = new Vector3(0.269f, -0.193f, 0.476f);
    }

    IEnumerator OnScope()

    {
        yield return new WaitForSeconds(0.12f);
        camera.SetActive(false);
        MainCamera.fieldOfView /= xscope;
        gun.transform.position
    }

    void OutScope()
    {
        camera.SetActive(true);
        MainCamera.fieldOfView = normalFOV;
        gun.transform.position = gunPossition;
    }
    // Update is called once per frame
    void Update()
    {
       if (Input.GetButtonDown("Fire2"))
        {
            IsScopped = !IsScopped;
            if (IsScopped)
            {
               StartCoroutine(OnScope());
            }
            else
                OutScope();

        }
    }
}
