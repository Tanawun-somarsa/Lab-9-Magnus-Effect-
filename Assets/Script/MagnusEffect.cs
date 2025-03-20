using UnityEngine;

public class MagnusEffect : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 velocity, spin;



    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Kick();
        }
        //kick

        //applt magnus effect
        ApplyMagnusEffect();
    }

    void Kick()
    {
        //�ç�еç
        rb.linearVelocity = velocity;

        //�ç��ع���
        rb.angularVelocity = spin;
    }

    void ApplyMagnusEffect()
    {
        Vector3 magnusForce = Vector3.Cross(rb.linearVelocity,rb.angularVelocity);

        rb.AddForce(magnusForce);
    }
}
