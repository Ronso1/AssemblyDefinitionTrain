using UnityEngine;
using Zenject;
namespace Game
{
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField] private Collider _player;
        public override void InstallBindings()
        {
            Container
                 .Bind<Collider>()
                 .FromInstance(_player)
                 .AsSingle();
        }
    }
}
