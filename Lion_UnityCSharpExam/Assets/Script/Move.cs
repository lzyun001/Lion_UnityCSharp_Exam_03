using UnityEngine;


public class Move : MonoBehaviour
{
    private bool stop = false;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (stop == false) transform.Translate(1 * Time.deltaTime * speed, 0, 0);
        if (transform.position.x >= 5)
        {
            stop = true;
            transform.Translate(0, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.P)) Application.LoadLevel("第二題");
    }
}
