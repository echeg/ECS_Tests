using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System6 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component482> _p1;
EcsPool<Component314> _p2;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component482>().Inc<Component314>().End();
   _p1 = _world.GetPool<Component482>();
   _p2 = _world.GetPool<Component314>();
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
