using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Word
{

    public string word;
    //bekijk hoeveel letters er zijn getypt
    private int typeIndex;

    WordDisplay display;


    public Word(string _word, WordDisplay _display)
    {
        word = _word;
        typeIndex = 0;

        display = _display;
        display.SetWord(word);
    }

    public char GetNextLetter ()
    {
        return word[typeIndex];
    }


    public void TypeLetter()
    {
        typeIndex++;
        display.RemoveLetter();
        //verwijder de letter op het scherm.
    }

   public bool WordTyped ()
    {   //bekijkt of het hele woord is getypt
        bool wordTyped = (typeIndex >= word.Length);
        if (wordTyped) // als het woord is getypt
        {
            display.RemoveWord();
            //verwijder het woord van het scherm
        }
        return wordTyped;
    }
}