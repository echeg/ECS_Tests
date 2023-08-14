using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System97 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component174> _p1;
EcsPool<Component110> _p2;
EcsPool<Component425> _p3;
EcsPool<Component493> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component174>().Inc<Component110>().Inc<Component425>().Inc<Component493>().End();
   _p1 = _world.GetPool<Component174>();
   _p2 = _world.GetPool<Component110>();
   _p3 = _world.GetPool<Component425>();
   _p4 = _world.GetPool<Component493>();
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
