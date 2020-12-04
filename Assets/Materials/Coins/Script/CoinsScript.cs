using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinsScript : MonoBehaviour
{
    public static int theScore;
    

     void Update()
    {
        
           this.gameObject.GetComponent<TextMeshProUGUI>().text = theScore.ToString();
             
    }
}
