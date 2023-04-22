using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour
{
    // Start is called before the first frame update

    private Vector3 screenPoint;




    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Mouth")
        {
            // Destroy đối tượng khác
            Destroy(gameObject);

        }
    }

}
