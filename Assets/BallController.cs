using UnityEngine;

public class BallController : MonoBehaviour
{
    Transform transform;
    [SerializeField] int up = -1;
    [SerializeField] int right = 1;
    [SerializeField] int speed = 10;
    [SerializeField] float half = 10f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed*right,speed*up);  
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Wall")
        {
            up *= -1;
        } else if (other.gameObject.tag == "Paddle")
        {
            right *= -1;
        }
    }
}
