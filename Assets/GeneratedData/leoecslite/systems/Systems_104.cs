using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System104 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component342> _p1;
EcsPool<Component391> _p2;
EcsPool<Component15> _p3;
EcsPool<Component434> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component342>().Inc<Component391>().Inc<Component15>().Inc<Component434>().End();
   _p1 = _world.GetPool<Component342>();
   _p2 = _world.GetPool<Component391>();
   _p3 = _world.GetPool<Component15>();
   _p4 = _world.GetPool<Component434>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

}
