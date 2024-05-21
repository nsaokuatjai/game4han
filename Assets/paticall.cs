using System.Diagnostics;
using UnityEngine;

public class paticall : MonoBehaviour
{
    private ParticleSystem particleSystem;
    public GameObject obj;
    private bool isRmain=false;
    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        ParticleSystem.Particle[] particles = new ParticleSystem.Particle[particleSystem.main.maxParticles];
        int numParticlesAlive = particleSystem.GetParticles(particles);

        for (int i = 0; i < numParticlesAlive; i++)
        {
            ParticleSystem.Particle particle = particles[i];
          //  UnityEngine.Debug.Log(particle.remainingLifetime);
            // パーティクルの残存寿命が0.1以下であれば消滅したとみなす
            if (particle.remainingLifetime <= 0.1f)
            {
                for (int j = 0; j < numParticlesAlive; j++)
                {// 消滅したパーティクルの座標を出力する
                    Instantiate<GameObject>(obj, particleSystem.transform.TransformPoint(particles[j].position), Quaternion.identity);
                    //UnityEngine.Debug.Log("Particle Disappeared at Position: " + particle.position);
                    isRmain = true;
                }
                break;

            }
            
        }
        if (isRmain)
        {
            Destroy(gameObject);
        }

        }
}