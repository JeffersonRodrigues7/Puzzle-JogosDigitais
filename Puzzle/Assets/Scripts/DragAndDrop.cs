using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    public string imageName = "puzzle1";
    Vector3 posicaoOriginal;
    private Pontuacao pontuacao;

    public void Start() {
        posicaoOriginal = transform.position;
        pontuacao = GameObject.Find("PontuacaoValue").GetComponent<Pontuacao>();
    }

    public void Drag() {
        GameObject.Find($"{imageName}_" + tag).transform.position = Input.mousePosition;
        //print("Arrastando" + gameObject.name);
    }

    public void Drop() {
        checkMatch();
    }

    public void posicaoInicialPartes(){
        posicaoOriginal = transform.position;
    }

    public void moveBack() {
        transform.position = posicaoOriginal;
    }

    public void snap(GameObject img, GameObject lm) {
        img.transform.position = lm.transform.position;
    }

    public void checkMatch() {
        GameObject img = gameObject;
        string tag = gameObject.tag;
        GameObject lm1 = GameObject.Find("LM" + tag);

        float distance = Vector3.Distance(lm1.transform.position, img.transform.position);
        //print("Distância: " + distance);
        if(distance <= 50) {
            snap(img, lm1);

            pontuacao.addPontuation();
        }  
        else {
            moveBack();
        }
               
    }

}
