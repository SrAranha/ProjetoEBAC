using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    [Header("Aumentar/Diminuir Bot�es")]
    public Vector2 botoesTamanhoPequeno;
    public Vector2 botoesTamanhoGrande;
    private GridLayoutGroup gridLayoutGroup;
    private bool botoesGrande = true;
    [Header("Ligar/Desligar Bot�es")]
    public GameObject[] botoesLigarDesligar;
    private bool ligaDesliga = true;

    private void Awake()
    {
        gridLayoutGroup = GetComponent<GridLayoutGroup>();
    }
    public void AumentarDiminuir()
    {
        if (botoesGrande) // Diminuir os bot�es
        {
            gridLayoutGroup.cellSize = botoesTamanhoPequeno;
            botoesGrande = false;
        }
        else // Aumentar os bot�es
        {
            gridLayoutGroup.cellSize = botoesTamanhoGrande;
            botoesGrande = true;
        }
    }
    public void LigarDesligarBotao()
    {
        if (ligaDesliga) // Desligar os bot�es
        {
            foreach (GameObject botao in botoesLigarDesligar)
            {
                botao.SetActive(false);
            }
            ligaDesliga = false;
        }
        else // Ligar os bot�es
        {
            foreach (GameObject botao in botoesLigarDesligar)
            {
                botao.SetActive(true);
            }
            ligaDesliga = true;
        }
    }
}
