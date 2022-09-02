using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public Text newText;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            newText.text = "Hello, my name is Devin!"; // replace my name with your actual name, a nickname, or whatever name you prefer to use
        }

        if (Input.GetKeyDown("f"))
        {
            newText.text = "There is nothing here!";
        }
    }
}
