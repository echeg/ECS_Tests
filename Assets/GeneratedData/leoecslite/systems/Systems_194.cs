using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System194 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component32> _p1;
EcsPool<Component33> _p2;
EcsPool<Component218> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component32>().Inc<Component33>().Inc<Component218>().End();
   _p1 = _world.GetPool<Component32>();
   _p2 = _world.GetPool<Component33>();
   _p3 = _world.GetPool<Component218>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
