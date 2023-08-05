using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System81 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component156> _p1;
EcsPool<Component21> _p2;
EcsPool<Component317> _p3;
EcsPool<Component75> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component156>().Inc<Component21>().Inc<Component317>().Inc<Component75>().End();
   _p1 = _world.GetPool<Component156>();
   _p2 = _world.GetPool<Component21>();
   _p3 = _world.GetPool<Component317>();
   _p4 = _world.GetPool<Component75>();
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
