using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPlane : MonoBehaviour
{
    Camera maincam;
    RaycastHit hitInfo;
    public Transform cubePrefab;
    public Transform spherePrefab;


    // Start is called before the first frame update
    void Awake()
    {
        maincam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = maincam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity))
            {
                Color c = new Color(Random.Range(0.5f, 1f), Random.Range(0.5f, 1f), Random.Range(0.5f, 1f));
                //CubePlacer.PlaceCube(hitInfo.point, c, cubePrefab);
                ICommand command;
                if (UIScript.state == 0)
                {
                    command = new PlaceCubeCommand(hitInfo.point, c, cubePrefab);
                }
                else
                {
                    command = new PlaceSphereCommand(hitInfo.point, c, spherePrefab);
                }
                CommandInvoker.AddCommand(command);
            }
        }
        
    }
}
