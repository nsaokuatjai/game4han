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
            // �p�[�e�B�N���̎c��������0.1�ȉ��ł���Ώ��ł����Ƃ݂Ȃ�
            if (particle.remainingLifetime <= 0.1f)
            {
                for (int j = 0; j < numParticlesAlive; j++)
                {// ���ł����p�[�e�B�N���̍��W���o�͂���
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