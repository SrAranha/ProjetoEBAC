using TMPro;
using UnityEngine;

public class SwitchAnimal : MonoBehaviour
{
    public enum Animal
    {
        Peixe,
        Gato,
        Calopsita
    }

    public TMP_Text tmp_Texto;
    public KeyCode[] keyCodes;

    private void Awake()
    {
        tmp_Texto = tmp_Texto.GetComponent<TMP_Text>();
        tmp_Texto.text = "";
    }
    void Update()
    {
        if (Input.GetKeyDown(keyCodes[0]))
        {
            Switch(0);
        }
        else if (Input.GetKeyDown(keyCodes[1]))
        {
            Switch(1);
        }
        else if (Input.GetKeyDown(keyCodes[2]))
        {
            Switch(2);
        }
    }
    private void Switch(int keyPressed)
    {
        switch (keyPressed)
        {
            case 0:
                tmp_Texto.text = MudarString(Animal.Peixe);
                break;
            case 1:
                tmp_Texto.text = MudarString(Animal.Gato);
                break;
            case 2:
                tmp_Texto.text = MudarString(Animal.Calopsita);
                break;
            default:
                tmp_Texto.text = "Não temos um animal.";
                break;
        }
    }
    private string MudarString(Animal animal)
    {
        string _string = "O animal é: ";
        switch (animal)
        {
            case Animal.Peixe:
                _string += "Peixe.";
                break;
            case Animal.Gato:
                _string += "Gato.";
                break;
            case Animal.Calopsita:
                _string += "Calopsita.";
                break;
        }
        Debug.Log(_string);
        return _string;
    }
}
