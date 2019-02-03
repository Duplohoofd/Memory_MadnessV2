using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{

    public List<Word> words;

    public WordSpawner wordSpawner;

    private bool hasActiveWord;
    private Word activeWord;

    


    public void AddWord()
    {
      

        Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
        Debug.Log(word.word);

        words.Add(word);
    }

    public void TypeLetter (char letter)
    {
        if (hasActiveWord)
        {
            //bekijk of het volgende letter in het getypte (actieve) woord goed is
            //verwijder de letter van het woord
            if (activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
            }
        } else
        {
            //Niet het bovenstaand geval, bekijk of het de eerste letter van het woord is.
            foreach(Word word in words)
            {   //Als de getype letter als eerst is, markeer als actieve woord
                if (word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }

        if (hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            words.Remove(activeWord);
        }
    }

}