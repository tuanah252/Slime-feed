using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepOnScreen : MonoBehaviour
{
    private float screenLeft;
    private float screenRight;
    private float screenTop;
    private float screenBottom;
    private float objectWidth;
    private float objectHeight;

    void Start()
    {
        // Lấy thông tin về kích thước màn hình
        screenLeft = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).x;
        screenRight = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x;
        screenTop = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0)).y;
        screenBottom = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).y;

        // Lấy thông tin về kích thước của đối tượng
        objectWidth = GetComponent<Renderer>().bounds.size.x / 2;
        objectHeight = GetComponent<Renderer>().bounds.size.y / 2;
    }

    void Update()
    {
        // Xác định vị trí mới cho đối tượng
        float xPos = Mathf.Clamp(transform.position.x, screenLeft + objectWidth, screenRight - objectWidth);
        float yPos = Mathf.Clamp(transform.position.y, screenBottom + objectHeight, screenTop - objectHeight);
        transform.position = new Vector3(xPos, yPos, transform.position.z);
    }
}
