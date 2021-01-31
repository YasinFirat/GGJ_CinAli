using UnityEngine;

[System.Serializable]
public class Points 
{
    public Transform point;
    
    public Vector2 getPosition()
    {
        return (Vector2)point.position;
    }

}
