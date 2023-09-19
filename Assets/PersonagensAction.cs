using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonagensAction : MonoBehaviour
{
    public Sprite[] spriteArrayPresidente;
    public Sprite[] spriteArrayRDR;
    public Sprite[] spriteArrayPresidenteEleito;
    public Sprite[] spriteArrayRotaryPadrinho;
    public Sprite[] spriteArrayGovernador;

    public SpriteRenderer spriteRendererPresidente;
    public SpriteRenderer spriteRendererRDR;
    public SpriteRenderer spriteRendererPresidenteEleito;
    public SpriteRenderer spriteRendererRotaryPadrinho;
    public SpriteRenderer spriteRendererGovernador;
    void Awake()
    {
        ChangeSprite();
    }

    void ChangeSprite()
    {
        spriteRendererPresidente.sprite = spriteArrayPresidente[Random.Range(0, spriteArrayPresidente.Length)];
        spriteRendererRDR.sprite = spriteArrayRDR[Random.Range(0, spriteArrayRDR.Length)];
        spriteRendererPresidenteEleito.sprite = spriteArrayPresidenteEleito[Random.Range(0, spriteArrayPresidenteEleito.Length)];
        spriteRendererRotaryPadrinho.sprite = spriteArrayRotaryPadrinho[Random.Range(0, spriteArrayRotaryPadrinho.Length)];
        spriteRendererGovernador.sprite = spriteArrayGovernador[Random.Range(0, spriteArrayGovernador.Length)];
    }
}
