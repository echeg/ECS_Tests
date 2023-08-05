using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System15 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component380> _p1;
EcsPool<Component483> _p2;
EcsPool<Component382> _p3;
EcsPool<Component103> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component380>().Inc<Component483>().Inc<Component382>().Inc<Component103>().End();
   _p1 = _world.GetPool<Component380>();
   _p2 = _world.GetPool<Component483>();
   _p3 = _world.GetPool<Component382>();
   _p4 = _world.GetPool<Component103>();
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
