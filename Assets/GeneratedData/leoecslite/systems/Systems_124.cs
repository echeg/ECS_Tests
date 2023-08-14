using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System124 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component405> _p1;
EcsPool<Component286> _p2;
EcsPool<Component178> _p3;
EcsPool<Component51> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component405>().Inc<Component286>().Inc<Component178>().Inc<Component51>().End();
   _p1 = _world.GetPool<Component405>();
   _p2 = _world.GetPool<Component286>();
   _p3 = _world.GetPool<Component178>();
   _p4 = _world.GetPool<Component51>();
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
