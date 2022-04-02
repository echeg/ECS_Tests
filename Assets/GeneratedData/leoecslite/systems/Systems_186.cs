using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System186 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component355> _p1;
EcsPool<Component159> _p2;
EcsPool<Component221> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component355>().Inc<Component159>().Inc<Component221>().End();
   _p1 = _world.GetPool<Component355>();
   _p2 = _world.GetPool<Component159>();
   _p3 = _world.GetPool<Component221>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
