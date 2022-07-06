using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorMap : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] INPUT_Plane;
    public GameObject[] INPUT_Wall;
    private List<GameObject> Plane;
    private List<GameObject> Wall;
    void Start()
    {
        Plane.Add(Instantiate(INPUT_Plane[0], new Vector3(0, 0, 0), Quaternion.identity) as GameObject);
        //Instantiate(INPUT_Plane[0], new Vector3(0, 0, 0), Quaternion.identity);
        for (int i = 0; i < 20; i++)
        {
            int rand_z = Random.Range(-5,5);
            int rand_x = Random.Range(-5,5);
            int rand_y = Random.Range(5, 10);
            //Instantiate(INPUT_Wall[0], new Vector3(rand_x, rand_y, rand_z), Quaternion.identity);
            Wall.Add(Instantiate(INPUT_Wall[0], new Vector3(rand_x, rand_y, rand_z), Quaternion.identity) as GameObject);
        }
        Wall.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
