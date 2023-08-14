using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System178 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component412> _p1;
EcsPool<Component326> _p2;
EcsPool<Component484> _p3;
EcsPool<Component247> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component412>().Inc<Component326>().Inc<Component484>().Inc<Component247>().End();
   _p1 = _world.GetPool<Component412>();
   _p2 = _world.GetPool<Component326>();
   _p3 = _world.GetPool<Component484>();
   _p4 = _world.GetPool<Component247>();
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
