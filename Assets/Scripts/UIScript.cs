using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    [SerializeField]
    private Text toggleBut;
    public static int state=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleTypeButton()
    {
        if (state == 0)
        {
            toggleBut.text = "Current Mode: Sphere";
            state = 1;
        }
        else if (state ==1)
        {
            toggleBut.text = "Current Mode: Cube";
            state = 0;
        }
    }

}
