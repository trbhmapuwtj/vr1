using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject objectToToggle;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Toggle();
        }
    }

    private void Toggle()
    {
        if (objectToToggle.activeSelf)
        {
            objectToToggle.SetActive(false);
        }
        else
        {
            objectToToggle.SetActive(true);
        }
    }
}

