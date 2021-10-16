using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DesignCharacter : MonoBehaviour
{

    public Sprite[] Eye, Skin, Hair, Cloth, Bottom, Shoes;
    private int lenHair, lenSkin,lenEye,lenCloth,lenBottom,lenShoes;
    public int h,e,s,c,b,sh;
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
    }

    // Update is called once per frame
    void Update()
    {
        CurrentHair.GetComponent<Image>().sprite=Hair[h];
        CurrentEye.GetComponent<Image>().sprite=Eye[e];
        CurrentSkin.GetComponent<Image>().sprite=Skin[s];
        CurrentCloth.GetComponent<Image>().sprite=Cloth[c];
        CurrentBottom.GetComponent<Image>().sprite=Bottom[b];
        CurrentShoes.GetComponent<Image>().sprite=Shoes[sh];      
    }
    public void ChangeHair(){
        if(h<lenHair-1){
        h+=1;
        }
        else{
        h=0;
        }
    }
    public void ChangeEye(){
        if(e<lenEye-1){
        e+=1;
        }
        else{
        e=0;
        }
    }
    public void ChangeSkin(){
        if(s<lenSkin-1){
        s+=1;
        }
        else{
        s=0;
        }
    }
    public void ChangeCloth(){
        if(c<lenCloth-1){
        c+=1;
        }
        else{
        c=0;
        }
    }
    public void ChangeBottom(){
        if(b<lenBottom-1){
        b+=1;
        }
        else{
        b=0;
        }
    }
    public void ChangeShoes(){
        if(sh<lenShoes-1){
        sh+=1;
        }
        else{
        sh=0;
        }
    }
   
}
