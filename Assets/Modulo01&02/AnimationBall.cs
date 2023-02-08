using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AnimationBall : MonoBehaviour
{
    public bool loop;
    [Header("FIRST")]
    public Vector3 firstPos;
    public Ease firstEase;
    public float firstDuration;
    [Header("SECOND")]
    public Vector3 secondPos;
    public Ease secondEase;
    public float secondDuration;
    [Header("THIRD")]
    public Vector3 thirdPos;
    public Ease thirdEase;
    public float thirdDuration;
    [Header("FOURTH")]
    public Vector3 fourthPos;
    public Ease fourthEase;
    public float fourthDuration;
    [Header("FIFTH")]
    public Vector3 fifthPos;
    public Ease fifthEase;
    public float fifthDuration;
    [Header("FINAL")]
    public Vector3 finalPos;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = firstPos;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == firstPos)
        {
            transform.DOMove(secondPos, firstDuration).SetEase(firstEase);
        }
        if (transform.position == secondPos)
        {
            transform.DOMove(thirdPos, secondDuration).SetEase(secondEase);
        }
        if (transform.position == thirdPos)
        {
            transform.DOMove(fourthPos, thirdDuration).SetEase(thirdEase);
        }
        if (transform.position == fourthPos)
        {
            transform.DOMove(fifthPos, fourthDuration).SetEase(fourthEase);
        }
        if (transform.position == fifthPos)
        {
            transform.DOMove(finalPos, fifthDuration).SetEase(fifthEase);
        }
        if (transform.position == finalPos && loop)
        {
            transform.position = firstPos;
        }
    }
}
