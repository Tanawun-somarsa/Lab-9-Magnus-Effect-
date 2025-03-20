using UnityEngine;

public class Rotate : MonoBehaviour
{      
    Rigidbody rb;
    [SerializeField] Vector3 angularV;
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.angularVelocity = angularV;
        }
        
    }
}
