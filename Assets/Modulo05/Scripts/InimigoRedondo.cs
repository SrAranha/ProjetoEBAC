using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoRedondo : InimigoBase/*, IDano<int>*/
{
    public float velocidade;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Mover(-velocidade, 'x');
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Mover(+velocidade, 'x');
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Mover(+velocidade, 'y');
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Mover(-velocidade, 'y');
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Dano(s_Inimigo.dano);
        }
    }

    public void Mover(float velocidade, char axis)
    {
        if (axis == 'x')
        {
            gameObject.transform.Translate(new Vector3(velocidade, 0, 0));
        }
        if (axis == 'y')
        {
            gameObject.transform.Translate(new Vector3(0, velocidade, 0));
        }
    }
}
