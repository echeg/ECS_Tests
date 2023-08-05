using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System68 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component102> _p1;
EcsPool<Component323> _p2;
EcsPool<Component195> _p3;
EcsPool<Component118> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component102>().Inc<Component323>().Inc<Component195>().Inc<Component118>().End();
   _p1 = _world.GetPool<Component102>();
   _p2 = _world.GetPool<Component323>();
   _p3 = _world.GetPool<Component195>();
   _p4 = _world.GetPool<Component118>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

}
