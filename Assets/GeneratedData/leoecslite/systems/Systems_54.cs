using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System54 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component260> _p1;
EcsPool<Component423> _p2;
EcsPool<Component328> _p3;
EcsPool<Component1> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component260>().Inc<Component423>().Inc<Component328>().Inc<Component1>().End();
   _p1 = _world.GetPool<Component260>();
   _p2 = _world.GetPool<Component423>();
   _p3 = _world.GetPool<Component328>();
   _p4 = _world.GetPool<Component1>();
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
