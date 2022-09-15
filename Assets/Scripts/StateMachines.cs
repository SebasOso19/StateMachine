using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachines : MonoBehaviour
{
    [SerializeField] private float speed;


    public void OnAnimatorMove(Vector3 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    public void Ataack()
    {
        Debug.Log("Attack");
    }

    public abstract class CharacterStateBase
    {

    }
}
