using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class MagicCast : MonoBehaviour
{
    private KeywordRecognizer KeywordRecognizer;
    private Dictionary<string, Action> actions = new Dictionary<string, Action>();

    //public bool isListening = false;
    public int spellIndex;

    //public Transform castPoint;
    public GameObject magicPrefab1;

    // Start is called before the first frame update
    void Start()
    {
        actions.Add("blue", Blue);
        actions.Add("up", Up);
        actions.Add("down", Down);
        actions.Add("back", Back);

        KeywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        KeywordRecognizer.OnPhraseRecognized += RecognizedSpeech;
        KeywordRecognizer.Start();
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetKeyDown(KeyCode.F))
        {
            //isListening = true;
            KeywordRecognizer.Start();
        }
        */

        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            if(spellIndex==1)
            {
                Instantiate(magicPrefab1, transform.position + new Vector3(0,10,0), transform.rotation);
                Debug.Log("Spell 1");
            }
            else if(spellIndex==2)
            {
                Debug.Log("Spell 2");
            }
            else if (spellIndex == 3)
            {
                Debug.Log("Spell 3");
            }
            else if (spellIndex == 4)
            {
                Debug.Log("Spell 4");
            }

            spellIndex = 0;
        }
    }


    private void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {
        Debug.Log(speech.text);
        actions[speech.text].Invoke();
    }

    private void Blue()
    {
        spellIndex = 1;
        //GameObject.Find("Cube").transform.Translate(10, 0, 0);
    }

    private void Back()
    {
        spellIndex = 2;
        //GameObject.Find("Cube").transform.Translate(-10, 0, 0);
    }

    private void Up()
    {
        spellIndex = 3;
        //GameObject.Find("Cube").transform.Translate(0, 10, 0);
    }

    private void Down()
    {
        spellIndex = 4;
        //GameObject.Find("Cube").transform.Translate(0, -10, 0);
    }
}
