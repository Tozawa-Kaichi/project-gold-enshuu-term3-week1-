using UnityEngine;

public class Crosshair : MonoBehaviour
{
    void OnEnable()
    {
        //カーソル表示を消す
        Cursor.visible = false;
    }

    void OnDisable()
    {
        Cursor.visible = true;
    }

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;
        this.transform.position = mousePosition;
    }
}
