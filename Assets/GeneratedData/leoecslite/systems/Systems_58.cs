using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System58 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component99> _p1;
EcsPool<Component385> _p2;
EcsPool<Component110> _p3;
EcsPool<Component65> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component99>().Inc<Component385>().Inc<Component110>().Inc<Component65>().End();
   _p1 = _world.GetPool<Component99>();
   _p2 = _world.GetPool<Component385>();
   _p3 = _world.GetPool<Component110>();
   _p4 = _world.GetPool<Component65>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

}
