using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Ray ray;
    private RaycastHit hit;
    public FishingRod fishingRod;
    private Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        GetPlayerInputs();
    }

    private void GetPlayerInputs()
    {
        if (Input.GetMouseButtonDown(0) && !fishingRod.getIsRodCast())
        {
            
            ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.CompareTag("water"))
                {
                    if (!fishingRod.getIsRodCast())
                    {
                        print(hit.point);
                        fishingRod.castRod(hit.point);
                        
                    }
                }
            }
        }
        else if (Input.GetMouseButtonDown(0) && fishingRod.getIsRodCast())
        {
            fishingRod.reelIn();
        }
    }
}
