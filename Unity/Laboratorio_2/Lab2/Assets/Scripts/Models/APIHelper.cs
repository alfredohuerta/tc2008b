using UnityEngine; //Para la clase JsonUtility
using System.Net;
using System.IO;

public static class APIHelper
{
    public static Joke GetNewJoke()
    {
        // LLamada de tipo GET para obtener datos de la API
        HttpWebRequest request = (HttpWebRequest) WebRequest.Create("https://api.chucknorris.io/jokes/random");

        // Respuesta que da la API que envía datos a nuestro cliente
        HttpWebResponse response = (HttpWebResponse) request.GetResponse();

        // Lector que analiza la información dada por la API que permite 
        StreamReader reader = new StreamReader(response.GetResponseStream());

        // Convierte los datos en un JSON manipulable para nuestro programa 
        string json = reader.ReadToEnd();

        return JsonUtility.FromJson<Joke>(json); // Devuelve el JSON
    }
}