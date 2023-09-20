using Assets.Scripts.Bhv.NewRealisation.Interfaces;
using BehaviourTree;
using UnityEngine;

namespace Assets.Scripts.Bhv.NewRealisation.Conditions
{
    public class CheckIfEnemyInAttackRange : Node
    {
        private Collider[] targetBuffer = new Collider[2];
        private IDetecting detecting;
        private IMovable movable;
        private int enemyLayerMask = 1 << LayerMask.NameToLayer("Enemy");

        public CheckIfEnemyInAttackRange(IDetecting detecting, IMovable movable)
        {
            this.detecting = detecting;
            this.movable = movable;
        }

        public override NodeState Evaluate()
        {
            var hits = Physics.OverlapSphereNonAlloc(movable.CurrentPosition, detecting.DetectRange, targetBuffer, enemyLayerMask);

            if (hits > 0)
            {
                var target = targetBuffer[0].GetComponent<IHit>();

                detecting.SetDetected(target);

                state = NodeState.SUCCESS;
                return state;
            }

            state = NodeState.FAILURE;
            return state;
        }
    }
}
