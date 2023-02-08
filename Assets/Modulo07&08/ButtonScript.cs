using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    [Header("Aumentar/Diminuir Botões")]
    public Vector2 botoesTamanhoPequeno;
    public Vector2 botoesTamanhoGrande;
    private GridLayoutGroup gridLayoutGroup;
    private bool botoesGrande = true;
    [Header("Ligar/Desligar Botões")]
    public GameObject[] botoesLigarDesligar;
    private bool ligaDesliga = true;

    private void Awake()
    {
        gridLayoutGroup = GetComponent<GridLayoutGroup>();
    }
    public void AumentarDiminuir()
    {
        if (botoesGrande) // Diminuir os botões
        {
            gridLayoutGroup.cellSize = botoesTamanhoPequeno;
            botoesGrande = false;
        }
        else // Aumentar os botões
        {
            gridLayoutGroup.cellSize = botoesTamanhoGrande;
            botoesGrande = true;
        }
    }
    public void LigarDesligarBotao()
    {
        if (ligaDesliga) // Desligar os botões
        {
            foreach (GameObject botao in botoesLigarDesligar)
            {
                botao.SetActive(false);
            }
            ligaDesliga = false;
        }
        else // Ligar os botões
        {
            foreach (GameObject botao in botoesLigarDesligar)
            {
                botao.SetActive(true);
            }
            ligaDesliga = true;
        }
    }
}
