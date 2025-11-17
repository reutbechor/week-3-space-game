using UnityEngine;

/**
 * רכיב שגורם לשחקן לעבור מצד ימין לשמאל בציר X (עולם עגול),
 * ולהישאר בתוך גבולות המסך בציר Y (עולם סגור אנכית).
 */
public class WrapAround : MonoBehaviour
{
    float halfWidth;
    float halfHeight;

    void Start()
    {
        // חישוב גובה המסך ביחידות עולם
        halfHeight = Camera.main.orthographicSize;

        // חישוב רוחב המסך ביחידות עולם
        halfWidth = halfHeight * Camera.main.aspect;
    }

    void Update()
    {
        Vector3 pos = transform.position;

        //עולם עגול בציר X
        if (pos.x > halfWidth)
        {
            pos.x = -halfWidth;
        }
        else if (pos.x < -halfWidth)
        {
            pos.x = halfWidth;
        }
        //עולם סגור בציר Y 
        if (pos.y > halfHeight)
        {

            pos.y = halfHeight;
        }
        else if (pos.y < -halfHeight)
        {
            pos.y = halfHeight;
        }

        transform.position = pos;
    }
}
