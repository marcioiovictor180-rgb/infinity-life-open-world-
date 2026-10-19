using UnityEngine;

public class MobileControls : MonoBehaviour
{
    public static float Horizontal;
    public static float Vertical;

    public void SetHorizontal(float value)
    {
        Horizontal = value;
    }

    public void SetVertical(float value)
    {
        Vertical = value;
    }

    public void StopHorizontal()
    {
        Horizontal = 0f;
    }

    public void StopVertical()
    {
        Vertical = 0f;
    }
}
