using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpherePlacer : MonoBehaviour
{
    static List<Transform> spheres;

    public static void PlaceSphere(Vector3 position, Color color, Transform sphere)
    {
        Transform newSphere = Instantiate(sphere, position, Quaternion.identity);
        newSphere.GetComponentInChildren<MeshRenderer>().material.color = color;
        if (spheres == null)
        {
            spheres = new List<Transform>();
        }
        spheres.Add(newSphere);
    }

    public static void RemoveSphere(Vector3 position, Color color)
    {
        for (int i = 0; i < spheres.Count; i++)
        {
            if (spheres[i].position == position && spheres[i].GetComponentInChildren<MeshRenderer>().material.color == color)
            {
                GameObject.Destroy(spheres[i].gameObject);
                spheres.RemoveAt(i);
                break;
            }
        }
    }
}
