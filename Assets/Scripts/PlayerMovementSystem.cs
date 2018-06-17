
using Unity.Entities;
using UnityEngine;

public class PlayerMovementSystem : ComponentSystem {

    private struct Filter {
        public Rigidbody Rigidbody;
    }

    protected override void OnUpdate() {
        throw new System.NotImplementedException();
    }
}
