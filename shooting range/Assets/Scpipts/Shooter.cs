using System.Collections;
using UnityEngine;
public class Shooter : MonoBehaviour
{

    // Create Bullet 
    public GameObject bullet;
    public Transform generator;
    private Rigidbody rbBullet;
    //

    // Time of Full Reload
    private const float reloadGunTime = 2f;
    // Time of One Shot Reload
    private const float reloadBulletTime = 0.2f;
    // Count of Bullets
    private int nowMagazineSize;
    // Speed of Bullet
    private const float speed = 1000f;


    private bool IsReload = false;

    private IEnumerator Reloading(float time)
    {
        yield return new WaitForSeconds(time);
        IsReload = false;

    }

    private void Shoot()
    {      

        GameObject newBullet = Instantiate(bullet, generator.position, generator.rotation);
        rbBullet = newBullet.GetComponent<Rigidbody>();
        rbBullet.AddForce(generator.transform.forward * speed * Time.deltaTime, ForceMode.Impulse);

        GameManager.UpdateMagazineSize();

    }

    // Full reload
    private void Reload()
    {
        IsReload = true;
        
        
        StartCoroutine(Reloading(reloadGunTime));
        GameManager.SetMagazineSize(GameManager.magazineSize);
    }

    private void Update()
    {
        nowMagazineSize = GameManager.GetMagazineSize();

        if (Input.GetButton("Fire1") && nowMagazineSize != 0 && !IsReload)
        {
            // Shoot and reload Bullet
            Shoot();
            IsReload = true;
            StartCoroutine(Reloading(reloadBulletTime));
        }
        else if( (Input.GetKeyDown(KeyCode.R) | nowMagazineSize== 0)&& !IsReload)
        {
            // reload gun
            Reload();
        }
    }
}
