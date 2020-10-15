using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingRod : MonoBehaviour
{
    public Transform pivot;
    public GameObject fishingLine;
    private LineRenderer lineRender;
    public BobberController bobber;
    private float startingAngle;
    private bool isRodCast;
    public float angle;
    
    // Start is called before the first frame update
    void Start()
    {
        //lineRender = fishingLine.GetComponent<LineRenderer>();
        //startingAngle = fishingLine.transform.rotation.x;
        isRodCast = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void castRod(Vector3 mousePosition)
    {
        print("Casting Rod...");
        //float lineDistance = Vector3.Distance(fishingLine.transform.position, mousePosition);
        //print("distance: " + lineDistance);
        //fishingLine.transform.RotateAround(pivot.transform.position, transform.right, angle);
        //fishingLine.GetComponent<LineRenderer>().SetPosition(1,Vector3.);
        bobber.castBobber(mousePosition);
        
        setIsRodCast(true);
    }

    public void reelIn()
    {
        print("Reeling in...");
        //fishingLine.transform.RotateAround(pivot.transform.position, transform.right, startingAngle);
        //fishingLine.transform.pos
        bobber.reelBobber();
        setIsRodCast(false);
    }

    public void setIsRodCast(bool isRodCast)
    {
        this.isRodCast = isRodCast;
    }

    public bool getIsRodCast()
    {
        return isRodCast;
    }
}