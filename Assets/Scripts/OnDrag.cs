using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDrag : MonoBehaviour
{


    // Start is called before the first frame update
    public ParticleSystem particleSystemPrefab;
    private bool check;
    Vector3 offset;
    private Vector2 screenPoint;gggi
    private object collision;
    void Update()
    {
        screenPoint = transform.position;
    }
    private void OnDestroy()
    {

        Instantiate(particleSystemPrefab, screenPoint, Quaternion.identity);

    }

    void OnMouseDown()
    {
        check = true;
    }
    void OnMouseDrag()
    {
        if (check)
        {

            float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
            transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));


        }

    }
    void OnCollisionEnter(Collision other)
    {
        check = false;
    }


}


