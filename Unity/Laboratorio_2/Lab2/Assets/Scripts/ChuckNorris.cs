using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Nos permitirá trabajar con texto

public class ChuckNorris : MonoBehaviour
{
    public TextMeshProUGUI jokeText;
    public void NewJoke(){
        // Creamos un objeto tipo Joke que se conecte con APIHelper y mande a llamar la función que nos
        // permite obtener el JSON con la información de la página.
        Joke j = APIHelper.GetNewJoke();
        jokeText.text = j.value;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
