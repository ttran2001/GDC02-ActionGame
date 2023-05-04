using UnityEngine;

public class CursorInvisible : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.None;
    }
}
