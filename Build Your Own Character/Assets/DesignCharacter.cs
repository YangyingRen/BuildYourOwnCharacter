using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DesignCharacter : MonoBehaviour
{

    public Sprite[] Eye, Skin, Hair, Cloth, Bottom, Shoes;
    private int lenHair, lenSkin,lenEye,lenCloth,lenBottom,lenShoes, h,e,s,c,b,sh;
    public Image CurrentEye,CurrentSkin,CurrentHair,CurrentCloth,CurrentBottom,CurrentShoes;
    // Start is called before the first frame update
    void Start()
    {
        lenHair=Hair.Length;
        lenBottom=Bottom.Length;
        lenEye=Eye.Length;
        lenCloth=Cloth.Length;
        lenShoes=Shoes.Length;
        lenSkin=Skin.Length;
        e=0;
        h=0;
        s=0;
        c=0;
        b=0;
        sh=0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeHair(){
        if(h<lenHair-1){
        h+=1;
        }
        else{
        h=0;
        }
        CurrentHair.GetComponent<Image>().sprite=Hair[h];
    }
    public void ChangeEye(){
        if(e<lenEye-1){
        e+=1;
        }
        else{
        e=0;
        }
        CurrentEye.GetComponent<Image>().sprite=Eye[e];
    }
    public void ChangeSkin(){
        if(s<lenSkin-1){
        s+=1;
        }
        else{
        s=0;
        }
        CurrentSkin.GetComponent<Image>().sprite=Skin[s];
    }
    public void ChangeCloth(){
        if(c<lenCloth-1){
        c+=1;
        }
        else{
        c=0;
        }
        CurrentCloth.GetComponent<Image>().sprite=Cloth[c];
    }
    public void ChangeBottom(){
        if(b<lenBottom-1){
        b+=1;
        }
        else{
        b=0;
        }
        CurrentBottom.GetComponent<Image>().sprite=Bottom[b];
    }
    public void ChangeShoes(){
        if(sh<lenShoes-1){
        sh+=1;
        }
        else{
        sh=0;
        }
        CurrentShoes.GetComponent<Image>().sprite=Shoes[sh];
    }
   
}
