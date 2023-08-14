using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System58 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component281> _p1;
EcsPool<Component466> _p2;
EcsPool<Component200> _p3;
EcsPool<Component111> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component281>().Inc<Component466>().Inc<Component200>().Inc<Component111>().End();
   _p1 = _world.GetPool<Component281>();
   _p2 = _world.GetPool<Component466>();
   _p3 = _world.GetPool<Component200>();
   _p4 = _world.GetPool<Component111>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

}
