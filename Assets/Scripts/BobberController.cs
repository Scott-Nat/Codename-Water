using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using UnityEngine;
using Component = UnityEngine.Component;

public class BobberController : MonoBehaviour
{
    public Transform resetTransform;

    private Component joint;
    private Rigidbody rigidBody;
    private HingeJoint hingeJoint;
    private Rigidbody connectedBody;
    public bool isBobberInWater;
    public float speed;
    public bool isFishHooked;

    public float distanceToFish;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = this.GetComponent<Rigidbody>();
        hingeJoint = this.GetComponent<HingeJoint>();
        connectedBody = hingeJoint.connectedBody;
        isBobberInWater = false;
        isFishHooked = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void castBobber(Vector3 mousePosition)
    {
        hingeJoint.connectedBody = null;
        Destroy(hingeJoint);
        float step = speed * Time.deltaTime;
        transform.position = mousePosition;
        rigidBody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
        isBobberInWater = true;
    }

    public void reelBobber()
    {
        transform.position = resetTransform.position;
        hingeJoint = gameObject.AddComponent<HingeJoint>();
        hingeJoint.connectedBody = connectedBody;
        rigidBody.constraints = RigidbodyConstraints.None;
        isBobberInWater = false;
        isFishHooked = false;
    }
    
}
