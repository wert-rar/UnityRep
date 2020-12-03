using UnityEngine;

public class Mouse : MonoBehaviour
{ 
    public Transform playerBody;

    private float mouseSense = 250;
    private float yRotathion = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X")* mouseSense * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSense * Time.deltaTime;

        yRotathion -= mouseY;
        yRotathion = Mathf.Clamp(yRotathion, -90f, 90f);
        
        transform.localRotation = Quaternion.Euler(yRotathion, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
