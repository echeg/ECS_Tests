using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System42 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component114> _p1;
EcsPool<Component206> _p2;
EcsPool<Component94> _p3;
EcsPool<Component261> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component114>().Inc<Component206>().Inc<Component94>().Inc<Component261>().End();
   _p1 = _world.GetPool<Component114>();
   _p2 = _world.GetPool<Component206>();
   _p3 = _world.GetPool<Component94>();
   _p4 = _world.GetPool<Component261>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

}
