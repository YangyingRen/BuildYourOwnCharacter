using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubmitCharacter : MonoBehaviour
{
    public Text  NameInput, BackgroundInput;
    private int e,s,h,c,b,sh;
    public GameObject ch, CharacterPanel, Character, NamePanel, Name,StoryPanel, Background;
    public string ID;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        e=ch.GetComponent<DesignCharacter>().e;
        s=ch.GetComponent<DesignCharacter>().s;
        h=ch.GetComponent<DesignCharacter>().h;
        c=ch.GetComponent<DesignCharacter>().c;
        b=ch.GetComponent<DesignCharacter>().b;
        sh=ch.GetComponent<DesignCharacter>().sh;
        ID=e.ToString()+s.ToString()+h.ToString()+c.ToString()+b.ToString()+sh.ToString();

        
    }

    public void InstantCharacter(){
        GameObject newName=Instantiate(Name,NamePanel.transform);
        GameObject NameText=newName.transform.Find("Text").gameObject;
        NameText.GetComponent<Text>().text=NameInput.GetComponent<Text>().text;
        GameObject newCharacter=Instantiate(Character, CharacterPanel.transform);
        newCharacter.GetComponent<DesignCharacter>().e=e;
        newCharacter.GetComponent<DesignCharacter>().s=s;
        newCharacter.GetComponent<DesignCharacter>().h=h;
        newCharacter.GetComponent<DesignCharacter>().c=c;
        newCharacter.GetComponent<DesignCharacter>().b=b;
        newCharacter.GetComponent<DesignCharacter>().sh=sh;
        newCharacter.SetActive(false); 
        Background.gameObject.SetActive(false); 
        newCharacter.name=ID; 
        newName.name=ID;
        GameObject Story=Instantiate(Background,StoryPanel.transform);
        Story.GetComponent<Text>().text=BackgroundInput.text;
        Story.name=ID;  
}
  public void Back(){
      gameObject.SetActive(false);
  }
}
