using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoBase : MonoBehaviour, IDano<int>
{
    public InimigoInfo s_Inimigo;

    private void Awake()
    {
        s_Inimigo.vidaAtual = s_Inimigo.vidaBase;
        Debug.Log(gameObject.name + " tem " + s_Inimigo.vidaAtual + " de vida.");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Dano(s_Inimigo.dano);
        }
    }
    public void Dano(int dano)
    {
        if (dano >= s_Inimigo.vidaAtual)
        {
            s_Inimigo.vidaAtual -= s_Inimigo.vidaAtual;
            Morte();
        }
        else
        {
            s_Inimigo.vidaAtual -= dano;
            Debug.Log(gameObject.name + " levou " + dano + " de dano, e está com " + s_Inimigo.vidaAtual);
        }
    }
    protected void Morte()
    {
        if (s_Inimigo.vidaAtual <= 0)
        {
            Debug.Log(gameObject.name + " morreu.");
            Destroy(gameObject);
        }
    }
}
