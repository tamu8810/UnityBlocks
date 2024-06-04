using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.velocity = new Vector3(speed, speed, 0);
    }

    void Update()
    {
        
    }
}
