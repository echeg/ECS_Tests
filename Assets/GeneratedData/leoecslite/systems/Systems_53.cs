using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System53 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component16> _p1;
EcsPool<Component126> _p2;
EcsPool<Component66> _p3;
EcsPool<Component381> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component16>().Inc<Component126>().Inc<Component66>().Inc<Component381>().End();
   _p1 = _world.GetPool<Component16>();
   _p2 = _world.GetPool<Component126>();
   _p3 = _world.GetPool<Component66>();
   _p4 = _world.GetPool<Component381>();
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
