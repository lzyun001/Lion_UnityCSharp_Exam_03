using UnityEngine;

public class Rhombus : MonoBehaviour
{
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 0; j <i*2-1; j++)
            {
                Vector3 pos = new Vector3(i, j, 0);
                Instantiate(cube, pos, Quaternion.identity);
            }
        }
       /* for (int i = 5; i <= 1; i--)
        {
            for (int j = 0; j < i * 2 - 1; j++)
            {
                Vector3 pos = new Vector3(i, j, 0);
                Instantiate(cube, pos, Quaternion.identity);
            }
        }*/

        if (Input.GetKeyDown(KeyCode.O)) Application.LoadLevel("第二題");
        if (Input.GetKeyDown(KeyCode.P)) Application.LoadLevel("第四題");
    }
}
