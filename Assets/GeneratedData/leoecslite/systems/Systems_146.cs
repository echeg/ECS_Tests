using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System146 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component243> _p1;
EcsPool<Component208> _p2;
EcsPool<Component432> _p3;
EcsPool<Component40> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component243>().Inc<Component208>().Inc<Component432>().Inc<Component40>().End();
   _p1 = _world.GetPool<Component243>();
   _p2 = _world.GetPool<Component208>();
   _p3 = _world.GetPool<Component432>();
   _p4 = _world.GetPool<Component40>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

}
