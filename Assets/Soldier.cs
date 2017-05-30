using UnityEngine;

namespace Lecture3_Example
{
    public class Soldier : MonoBehaviour
    {
        public int health = 100;
        public int damage = 10;
        public float AttackDistance = 1f;
        public float speed = 1f;
        public Soldier target;


        public virtual void Attack()
        {
            target.GetDamage(damage);
        }


        public virtual void GetDamage(int dmg)
        {
            health -= dmg; // halth=helth-dmg
        }

        private void Update()
        {
            if (health <= 0)
            {
                Destroy(gameObject);
            }
            if (target != null)
                return;

            Vector3 distanceToTarget = transform.position - target.transform.position;
            if (distanceToTarget.magnitude < AttackDistance)
            {
                Attack();
            }
            else
            {
                transform.position += distanceToTarget.normalized * speed;
            }
        }
    }

}