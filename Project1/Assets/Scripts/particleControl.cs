using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleControl : MonoBehaviour
{
    public ParticleSystem particles;
    void Start()
    {
        particles.Emit(count: 100);
    }
}
