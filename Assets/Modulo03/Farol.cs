using Unity.VisualScripting;
using UnityEngine;

public class Farol : MonoBehaviour
{
    public Object[] lights;
    public Color[] colors;
    private KeyCode key = KeyCode.A;
    private int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < lights.Length; i++)
        {
            lights[i].GetComponent<Light>().color = Color.black;
        }
        if (index == 0)
        {
            lights[index].GetComponent<Light>().color = Color.red;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            ChangeLight();
        }
    }
    private void ChangeLight()
    {
        lights[index].GetComponent<Light>().color = Color.black;
        index++;
        if (index > 2)
        {
            index = 0;
        }
        lights[index].GetComponent<Light>().color = colors[index];
    }
}
