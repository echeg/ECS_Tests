using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System148 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component186> _p1;
EcsPool<Component460> _p2;
EcsPool<Component50> _p3;
EcsPool<Component214> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component186>().Inc<Component460>().Inc<Component50>().Inc<Component214>().End();
   _p1 = _world.GetPool<Component186>();
   _p2 = _world.GetPool<Component460>();
   _p3 = _world.GetPool<Component50>();
   _p4 = _world.GetPool<Component214>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

}
