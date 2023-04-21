using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obj;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    public GameObject obj5;
    public Canvas canvas;
    private Vector3 screenPoint;

    void Start()
    {
        screenPoint = new Vector2(-63, 844);
    }
    public void onClick()
    {
        for (int i = 0; i <= 5; i++)
        {
            Instantiate(obj, screenPoint, Quaternion.identity, canvas.transform);
            Instantiate(obj2, screenPoint, Quaternion.identity, canvas.transform);
            Instantiate(obj3, screenPoint, Quaternion.identity, canvas.transform);
            Instantiate(obj4, screenPoint, Quaternion.identity, canvas.transform);
            Instantiate(obj5, screenPoint, Quaternion.identity, canvas.transform);
        }
    }
}
