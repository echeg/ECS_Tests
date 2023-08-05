using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System20 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component202> _p1;
EcsPool<Component289> _p2;
EcsPool<Component279> _p3;
EcsPool<Component437> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component202>().Inc<Component289>().Inc<Component279>().Inc<Component437>().End();
   _p1 = _world.GetPool<Component202>();
   _p2 = _world.GetPool<Component289>();
   _p3 = _world.GetPool<Component279>();
   _p4 = _world.GetPool<Component437>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

}
