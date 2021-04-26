using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerController : MonoBehaviour
{
    public GameObject ball;
    Vector3 moveTo;
    [SerializeField] float moveSpeed = 10.0f;
    float topBound = 3.55f;
    float bottomBound = -3.6f;
    float half = -1.5f;
    [SerializeField] float rand;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Screen.width);
    }

    // Update is called once per frame
    void Update()
    {
        rand = Random.Range(1, 100);
        if (ball.transform.position.x <= half && rand < 40)
        {
            moveTo = new Vector2(transform.position.x, ball.transform.position.y);
            if (moveTo.y >= topBound)
            {
                moveTo = new Vector2(transform.position.x, topBound);
            } else if (moveTo.y <= bottomBound)
            {
                moveTo = new Vector2(transform.position.x, bottomBound);
            }
    
            transform.position = Vector2.Lerp(transform.position, moveTo, moveSpeed * Time.deltaTime);
        }

    }
}
