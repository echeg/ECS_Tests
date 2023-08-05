using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System85 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component138> _p1;
EcsPool<Component397> _p2;
EcsPool<Component171> _p3;
EcsPool<Component329> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component138>().Inc<Component397>().Inc<Component171>().Inc<Component329>().End();
   _p1 = _world.GetPool<Component138>();
   _p2 = _world.GetPool<Component397>();
   _p3 = _world.GetPool<Component171>();
   _p4 = _world.GetPool<Component329>();
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
