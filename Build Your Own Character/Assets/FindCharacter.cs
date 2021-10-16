using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindCharacter : MonoBehaviour
{
    public Transform Characters;
    public Transform Backgrounds;
    public int CharacterNum;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     Characters=GameObject.FindWithTag("Character").transform;
     Backgrounds=GameObject.FindWithTag("Story").transform;
     CharacterNum=Characters.childCount;
     
        
    }
    
    public void selectCharacter(){
        for(int i=0;i<CharacterNum;i++){
            if(gameObject.name==Characters.GetChild(i).name){
                Characters.GetChild(i).gameObject.SetActive(true);
                Backgrounds.GetChild(i).gameObject.SetActive(true);
            }
            else{
                Characters.GetChild(i).gameObject.SetActive(false);
                Backgrounds.GetChild(i).gameObject.SetActive(false);

            }
            Debug.Log("");

        }

    }
}
