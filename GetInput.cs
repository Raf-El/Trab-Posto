using UnityEngine.UI;
using UnityEngine;

public class GetInput : MonoBehaviour
{

    public InputField valorGasolina;
    public InputField valorEtanol;
    private float gasolina;
    private float etanol;
    public Text testo;
    public Text etanolText;
    public Text gasolinaText;

    private void Start()
    {
        etanolText.enabled = false;
        gasolinaText.enabled = false;
    }
    public void Setget() 
    {
        if (valorEtanol == null) 
        {
            testo.text = "É nescessario preencher todos os componentes";
            return;
        }
        else if (valorGasolina == null)
        {
            testo.text = "É nescessario preencher todos os componentes";
            return;
        }
        else
        {
            gasolina = float.Parse(valorGasolina.text);
            etanol = float.Parse(valorEtanol.text);
            float valor3 = etanol / gasolina;

            if (valor3 < 0.7)
            {
                etanolText.enabled = true;
                testo.text = "O melhor rendimento é de etanol ";
                gasolinaText.enabled = false;
            }
            else
            {
                gasolinaText.enabled = true;
                testo.text = "O melhor rendimento é de gasolina ";
                etanolText.enabled = false;
            }
        }
    }
 }
