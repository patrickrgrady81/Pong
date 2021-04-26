using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 mousePosition;
    [SerializeField] float moveSpeed = 10.0f;
    float topBound = 3.55f;
    float bottomBound = -3.6f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {   
        // oldPosition = transform.position;

            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (mousePosition.y >= topBound)
            {
                mousePosition = new Vector2(transform.position.x, topBound);
            }else if (mousePosition.y <= bottomBound)
            {
                mousePosition = new Vector2(transform.position.x, bottomBound);
            } else
            {
                mousePosition = new Vector2(transform.position.x, mousePosition.y); 
            }
            transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed * Time.deltaTime);

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        // Debug.Log("collision at " + Camera.main.ScreenToWorldPoint(Input.mousePosition));
    }

}
