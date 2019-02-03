using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{

    private static string[] wordList = {"Andorra", "Bulgarije", "Corsica", "Cyprus","Denemarken","Duitsland","Engeland","Estland","Finland","Frankrijk","Fuerteventura","Gibraltar","Gran Canaria","Griekenland","Groenland","Hongarije","Ierland","IJsland",
"Kreta","Letland","Liechtenstein","Litouwen","Luxemburg","Montenegro","Nederland","Noorwegen","Oostenrijk","Mallorca","Malta","Polen","Portugal","Roemenië",
"Rusland",
"Schotland",
"San Marin",
"Slowakije",
"Spanje",
"Tenerife",
"Turkije",
"Wales",
"Zweden",
"Zwitserland"};


    //statische method die een woord genereert
    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }
}