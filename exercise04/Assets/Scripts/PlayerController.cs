using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float forwardSpeed;
    [SerializeField] private float force;
    [SerializeField] private ForceMode forceMode;
    [SerializeField] private float gravity;

    private Rigidbody rb;
   

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(transform.forward * forwardSpeed * Time.deltaTime, Space.World);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * force, forceMode);
        }
        rb.AddForce(Vector3.down * gravity);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectable"))
        {

            Destroy(other.gameObject);
            UIController.collectItems--;
            Debug.Log(UIController.collectItems);


        }

        if (other.CompareTag("obstacle") || other . CompareTag ("Enemy"))
        {
            Vector3 startPos = new Vector3(0.13f, 10.7f, 0.55f);
            transform.position = startPos;

        }
    }
}
