using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
    public GameObject startCube;

    Color startCubeColor;
    GameObject[] allCubs;

    // Use this for initialization
    void Start()
    {
        //startCubeColor = Color.yellow;
        //allCubs = GameObject.FindGameObjectsWithTag("Cube");
        //this.gameObject.transform.position = GetSpawnPointFromCubesArray(allCubs, startCubeColor);
        this.gameObject.transform.position = GetSpwanPointFromStartCube(startCube);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.acceleration.x, 0, -Input.acceleration.z);
    }

    public Vector3 GetSpwanPointFromStartCube(GameObject startCube)
    {
        Vector3 point = startCube.transform.position;
        point.y++;
        return point;
    }

    public Vector3 GetSpawnPointFromCubesArray(GameObject[] cubesArray, Color startCubeColor)
    {
        Vector3 point = new Vector3(0, 0, 0);

        foreach (GameObject cube in cubesArray)
        {
            if (cube.GetComponent<Renderer>().material.color == startCubeColor)
            {
                point = cube.transform.position;
            }
        }
        point.y++;
        return point;
    }
}
