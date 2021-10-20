using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceSphereCommand : ICommand
{
    Vector3 position;
    Color color;
    Transform sphere;

    public PlaceSphereCommand(Vector3 position, Color color, Transform sphere)
    {
        this.position = position;
        this.color = color;
        this.sphere = sphere;
    }

    public void Execute()
    {
        SpherePlacer.PlaceSphere(position, color, sphere);
    }

    public void Undo()
    {
        SpherePlacer.RemoveSphere(position, color);
    }
}
