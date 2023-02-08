using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxLife;
    public int points;
    public Color[] lifeColors;

    private int life;
    private int toLifeStages;
    [SerializeField]private List<int> listLifeStages; // deixar serializado ou não funciona (?)
    private int currentStage;
    private ScoreHandler scoreHandler;

    private void Awake()
    {
        life = maxLife;
        gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color", lifeColors[0]);
        LifeStages();
        scoreHandler = GameObject.Find("/Canvas/Score").GetComponent<ScoreHandler>();
    }
    public void TakeDamage(int damage)
    {
        if (life > damage) life -= damage;
        else if (life <= damage)
        {
            life -= life;
            scoreHandler.UpdateScore(points);
            Destroy(gameObject);
        }
        ChangeColorOnLife();
    }
    private void LifeStages()
    {
        var lifei = maxLife;
        toLifeStages = maxLife / lifeColors.Length;
        listLifeStages.Add(lifei);
        for (int i = 0; i < lifeColors.Length-1; i++)
        {
            listLifeStages.Add(listLifeStages[i] - toLifeStages);
        }
    }
    private void ChangeColorOnLife()
    {
        for (int i = 0; i < lifeColors.Length; i++)
        {
            if (life == listLifeStages[i])
            {
                currentStage = i;
            }
        }
        gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color", lifeColors[currentStage]);
    }
}
