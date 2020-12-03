
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{    

    public Text magazineTextObject;
    public static Text magazineText;
    public Text countTextObject;
    public static Text countText;

    private static int countOfTargets;

    
    void Start()
    {
        // init magazine display
        magazineText = magazineTextObject;
        // init Counter display
        countText = countTextObject;
        countOfTargets = 0;

    }

    
    public static void UpdateMagazineText(int countOfBullet)
    {
        magazineText.text = countOfBullet.ToString()+ "/30";

    }
    // metod will br called at every Target Destroing
    public static void UpdateCounterText()
    {
        ++countOfTargets;
        countText.text = "Targets destroed : " + countOfTargets.ToString();
    }
}
