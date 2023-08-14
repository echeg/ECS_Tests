using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System70 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component22> _p1;
EcsPool<Component457> _p2;
EcsPool<Component365> _p3;
EcsPool<Component24> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component22>().Inc<Component457>().Inc<Component365>().Inc<Component24>().End();
   _p1 = _world.GetPool<Component22>();
   _p2 = _world.GetPool<Component457>();
   _p3 = _world.GetPool<Component365>();
   _p4 = _world.GetPool<Component24>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

}
