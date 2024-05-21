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
        // パーティクルシステムコンポーネントを取得する
        //particleSystem = GetComponent<ParticleSystem>();
        particle = GetComponent<ParticleSystem>();
        collisionEventList = new List<ParticleCollisionEvent>();
    }

    private void OnParticleCollision(GameObject other)
    {
       //particle.GetCollisionEvents(other, collisionEventList);
        //// パーティクルシステム内のすべてのパーティクルを取得する
        //ParticleSystem.Particle[] particles = new ParticleSystem.Particle[particleSystem.particleCount];
        //int count = particleSystem.GetParticles(particles);

        //// 各パーティクルの座標をログに出力する（または他の処理を行う）
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

