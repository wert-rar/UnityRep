
using UnityEngine;

public class Target : MonoBehaviour
{   

    private int helth = 3;
    public TargetManager manager;
    public bool isCollision = false;

    private void OnCollisionEnter(Collision collision) 
    { if (!manager.isDown)
        {   // when target helth end
            helth--;
            // Target was destroed
            if (helth <= 0)
            {
                UIManager.UpdateCounterText();
                Destroy(gameObject);
            }
            // was damaged
            else
                isCollision = true;
        }
    }

    
}
