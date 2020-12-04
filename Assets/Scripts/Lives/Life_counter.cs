using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life_counter : MonoBehaviour
{  
    
    private static int current_lives;
    


    public static int Current_lives() {
        
        return current_lives;
        
    } 
    

    public static int max_lives = 3;

    void Start()
    {
        max_lives = 3;
        current_lives = max_lives;
        Debug.Log(current_lives);

    }

    public static void lifeDecrement()
    {
            Debug.Log(current_lives);
        if (current_lives > 0)
        {
            Debug.Log("subtract life");
            current_lives--;

        }

    }
       
}
