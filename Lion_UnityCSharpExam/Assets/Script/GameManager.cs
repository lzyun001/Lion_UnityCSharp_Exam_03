
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Runner runner;
    public GameObject endscreen;
    private void Start()
    {
        runner.onFinish += EndScreen;
    }

    private void EndScreen()
    {
        endscreen.SetActive(true);
    }
}
