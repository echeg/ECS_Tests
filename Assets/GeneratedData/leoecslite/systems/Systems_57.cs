using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System57 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component161> _p1;
EcsPool<Component428> _p2;
EcsPool<Component324> _p3;
EcsPool<Component480> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component161>().Inc<Component428>().Inc<Component324>().Inc<Component480>().End();
   _p1 = _world.GetPool<Component161>();
   _p2 = _world.GetPool<Component428>();
   _p3 = _world.GetPool<Component324>();
   _p4 = _world.GetPool<Component480>();
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
