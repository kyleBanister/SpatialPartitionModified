using UnityEngine;

namespace SpatialPartitionPattern {
    public class EnemyBehavior : MonoBehaviour {
        public GameController gameController;

        private void Start() {
            gameController = FindAnyObjectByType<GameController>();
        }
        
        private void OnCollisionEnter(Collision other) {
            Debug.Log("In on collision");
            if (other.collider.GetComponent<SphereCollider>() && gameController != null) {
                gameController.Swap(gameObject);
            }
        }
    }
}