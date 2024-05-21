using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class patical : MonoBehaviour
{
 //   private ParticleSystem particleSystem;
    private ParticleSystem particle;
    private List<ParticleCollisionEvent> collisionEventList;
    public GameObject obj;
    private void Start()
    {
        // �p�[�e�B�N���V�X�e���R���|�[�l���g���擾����
        //particleSystem = GetComponent<ParticleSystem>();
        particle = GetComponent<ParticleSystem>();
        collisionEventList = new List<ParticleCollisionEvent>();
    }

    private void OnParticleCollision(GameObject other)
    {
       //particle.GetCollisionEvents(other, collisionEventList);
        //// �p�[�e�B�N���V�X�e�����̂��ׂẴp�[�e�B�N�����擾����
        //ParticleSystem.Particle[] particles = new ParticleSystem.Particle[particleSystem.particleCount];
        //int count = particleSystem.GetParticles(particles);

        //// �e�p�[�e�B�N���̍��W�����O�ɏo�͂���i�܂��͑��̏������s���j
        //for (int i = 0; i < count; i++)
        //{
        //    if (!particles[i].isAlive)
        //    {
        //        Vector3 particlePosition = particles[i].position;
        //        UnityEngine.Debug.Log("Particle " + i + " Position: " + particlePosition);
        //    }
        //}
        //Vector3 collisionPosition = other.transform.position;
        //UnityEngine.Debug.Log("Particle Disappeared at Position: " + collisionPosition);
        //particle.GetCollisionEvents(obj, collisionEventList);
        foreach (var collisionEvent in collisionEventList)
        {
            Vector3 pos = collisionEvent.intersection;
            UnityEngine.Debug.Log(pos);
           Instantiate<GameObject>(obj, pos, Quaternion.identity);
        }
    }
}

