using UnityEngine;
using System.Collections;

public class CubeScript : MonoBehaviour
{

    public enum CubeState
    {
        StartCube,
        EndCube,
        GoodCube,
        BadCube
    }

    public CubeState cubeState;

    // Use this for initialization
    void Start()
    {
        switch (cubeState)
        {
            case CubeState.StartCube:
                ChangeColorTo(Color.yellow);
                break;
            case CubeState.EndCube:
                ChangeColorTo(Color.blue);
                break;
            case CubeState.GoodCube:
                ChangeColorTo(Color.green);
                break;
            case CubeState.BadCube:
                ChangeColorTo(Color.red);
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeColorTo(Color color)
    {
        //this.GetComponent<Renderer>().material.SetColor("color",color);
        //gameObject.renderer.material.color = new Color(1, 1, 1);
        this.GetComponent<Renderer>().material.color = color;

    }
}
