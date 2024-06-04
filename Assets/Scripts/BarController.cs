using UnityEngine;

public class BarController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, 0, 0);
    }
}
