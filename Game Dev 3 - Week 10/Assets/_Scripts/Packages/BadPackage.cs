using GameDevWithMarco.Interfaces;
using GameDevWithMarco.Managers;
using UnityEngine;

namespace GameDevWithMarco.Packages
{
    public class BadPackage : MonoBehaviour, ICollidable
    {
        [SerializeField] GameEvent badPackageCollected;

        public void CollidedLogic()
        {
            badPackageCollected.Raise();
        }
    }
}
