using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlow : MonoBehaviour
{

    public Transform grassblock;
    public Transform clayblock;
    public int zMod = 0;
    // Start is called before the first frame update
    void Start()
    {
        for(int xPos = -5; xPos < 6; ++xPos)
        {
            for(int zPos = -5; zPos < 10; ++zPos)
            {
                Instantiate(clayblock, new Vector3(xPos, -1, zPos), clayblock.rotation);
                Instantiate(grassblock, new Vector3(xPos, 0, zPos), grassblock.rotation);
                
            }
            
        }

        for (int xPos = -5; xPos < 6; ++xPos)
        {
            for (int zPos = -3; zPos < 9; ++zPos)
            {
                Instantiate(grassblock, new Vector3(xPos, 1, zPos), grassblock.rotation);

            }

        }

        for (int xPos = -5; xPos < 6; ++xPos)
        {
            for (int zPos = -2; zPos < 8; ++zPos)
            {
                Instantiate(grassblock, new Vector3(xPos, 2, zPos), grassblock.rotation);

            }

        }

        for (int xPos = -5; xPos < 6; ++xPos)
        {
            for (int zPos = -1; zPos < 7; ++zPos)
            {
                Instantiate(grassblock, new Vector3(xPos, 3, zPos), grassblock.rotation);

            }

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}