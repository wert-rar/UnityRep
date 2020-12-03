
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int magazineSize = 30;
    private static int currentMagazineSize;
    

    void Start()  =>  currentMagazineSize = magazineSize;

    // Update is called after every shoot
    public static void UpdateMagazineSize()
    {
        currentMagazineSize--;
        UIManager.UpdateMagazineText(currentMagazineSize);

    }
    //  called after Reload Or when Magazine Empty
    public static void ReloadMagazineSize( ) => currentMagazineSize = magazineSize;


    public static int  GetMagazineSize() => currentMagazineSize;


    public static void SetMagazineSize(int value) { 
        // always reload with FULL magazine
        currentMagazineSize = value; 
        UIManager.UpdateMagazineText(magazineSize); 
    }
}
